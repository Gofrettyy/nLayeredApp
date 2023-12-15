using AutoMapper;
using Business.Abtracts;
using Business.Dtos.Request;
using Business.Dtos.Responses;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;

public class CategoryManager:ICategoryService
{
    private ICategoryDal _categoryDal;
    private IMapper _mapper;
    private CategoryBusinessRules _categoryBusinessRules;

    public CategoryManager(ICategoryDal categoryDal, IMapper mapper, CategoryBusinessRules categoryBusinessRules)
    {
        _categoryDal = categoryDal;
        _mapper = mapper;
        _categoryBusinessRules = categoryBusinessRules;
    }

    public  async Task<Paginate<GetListedCategoryResponse>> GetListAsync()
    {
        var data = await _categoryDal.GetListAsync();
        var result = _mapper.Map<Paginate<GetListedCategoryResponse>>(data);
        return result;
    }

    public async Task<CreatedCategoryResponse> Add(CreateCategoryRequest createCategoryRequest)
    {
        await  _categoryBusinessRules.MaximumCountIsTen();
        var category = _mapper.Map<Category>(createCategoryRequest);
        var createdCategory = await _categoryDal.AddAsync(category);
        return _mapper.Map<CreatedCategoryResponse>(createdCategory);
    }
    public async Task<DeletedCategoryResponse> DeleteAsync(DeleteCategoryRequest deleteCategoryRequest)
    {
        Category deleteCategory = await _categoryDal.GetAsync(c => c.Id == deleteCategoryRequest.Id);
        await _categoryDal.DeleteAsync(deleteCategory);
        return _mapper.Map<DeletedCategoryResponse>(deleteCategory);
    }
    public async Task<UpdatedCategoryResponse> UpdateAsync(UpdateCategoryRequest updateCategoryRequest)
    {
        Category updateCategory = await _categoryDal.GetAsync(c => c.Id == updateCategoryRequest.Id);
        _mapper.Map(updateCategoryRequest, updateCategory);
        Category updatedCategory = await _categoryDal.UpdateAsync(updateCategory);
        return _mapper.Map<UpdatedCategoryResponse>(updatedCategory);
    }
    
    
}