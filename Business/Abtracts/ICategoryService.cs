using Business.Dtos.Request;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;

namespace Business.Abtracts;

public interface ICategoryService
{
    Task<Paginate<GetListedCategoryResponse>> GetListAsync();
    Task<CreatedCategoryResponse> Add(CreateCategoryRequest createCategoryRequest);
    Task<UpdatedCategoryResponse> UpdateAsync(UpdateCategoryRequest updateCategoryRequest);
    Task<DeletedCategoryResponse> DeleteAsync(DeleteCategoryRequest deleteCategoryRequest);
   
}