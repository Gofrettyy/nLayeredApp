using Business.Dtos.Request;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concrete;

namespace Business.Concretes;

public interface IProductService
{
    //Task<Paginate<CreatedProductResponse>> GetListAsync(); 
    Task<Paginate<GetListedProductResponse>> GetListAsync();
    Task <CreatedProductResponse>Add(CreateProductRequest createProductRequest);
    Task <DeletedProductResponse> Delete (DeleteProductRequest deleteProductRequest);
    Task <UpdatedProductResponse> Update (UpdateProductRequest updateProductRequest);
    
}