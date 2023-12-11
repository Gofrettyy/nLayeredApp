using System.Reflection;
using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccess.Concretes;

public class EfProductDal:EfRepositoryBase<Product,int,NorthwindContext>,IProductDal
{
    public EfProductDal(NorthwindContext context) : base(context)
    {
    }
}

