using Business.Dtos.Request;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concrete;

namespace Business.Concretes;

public interface ICategoryService
{
    Task<Paginate<GetListedCategoryResponse>> GetListAsync();
    Task<CreatedCategoryResponse> Add(CreateCategoryRequest createCategoryRequest);
   
}