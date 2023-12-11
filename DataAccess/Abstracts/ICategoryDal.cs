using Core.DataAccess.Repositories;
using Entities.Concrete;

namespace DataAccess.Abstracts;

public interface ICategoryDal:IRepository<Category,int>,IAsyncRepository<Category,int>
{
    
}