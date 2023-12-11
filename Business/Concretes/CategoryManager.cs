using AutoMapper;
using Business.Dtos.Request;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes;

public class CategoryManager:ICategoryService
{
    private ICategoryDal _categoryDal;
    private IMapper _mapper;

    public CategoryManager(ICategoryDal categoryDal,IMapper mapper)
    {
        _mapper = mapper;
        _categoryDal = categoryDal;
    }
    public  async Task<Paginate<GetListedCategoryResponse>> GetListAsync()
    {
        var category = _categoryDal.GetListAsync();
        var data = await _categoryDal.GetListAsync(include: c => c.Include(c => c.Products));
        var result = _mapper.Map<Paginate<GetListedCategoryResponse>>(data);
        return result;
    }

    public async Task<CreatedCategoryResponse> Add(CreateCategoryRequest createCategoryRequest)
    {
        var category = _mapper.Map<Category>(createCategoryRequest);
        var createdCategory = await _categoryDal.AddAsync(category);
        return _mapper.Map<CreatedCategoryResponse>(createdCategory);
    }
}