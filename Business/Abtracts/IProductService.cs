using Business.Dtos.Request;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;

namespace Business.Abtracts;

public interface IProductService
{
    //Task<Paginate<CreatedProductResponse>> GetListAsync(); 
    Task<IPaginate<GetListedProductResponse>> GetListAsync();
    Task <CreatedProductResponse>Add(CreateProductRequest createProductRequest);
    Task <DeletedProductResponse> Delete (DeleteProductRequest deleteProductRequest);
    Task <UpdatedProductResponse> Update (UpdateProductRequest updateProductRequest);
    
}