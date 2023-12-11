using Core.DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Abstracts;
//Biz bugüne kadar senkron çalıştık yani aynı anda bir işlem yapabiliyoruz 
public interface IProductDal:IRepository<Product,int>,IAsyncRepository<Product,int>
{
    
}