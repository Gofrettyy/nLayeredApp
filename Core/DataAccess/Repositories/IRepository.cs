using System.Linq.Expressions;
using Core.DataAccess.Dynamic;
using Core.DataAccess.Paging;
using Core.Entities;
using Microsoft.EntityFrameworkCore.Query;

namespace Core.DataAccess.Repositories;

public interface IRepository<TEntity, TEntityId>:IQuery<TEntity>
    where TEntity : Entity<TEntityId>
{
    TEntity? Get(
        Expression<Func<TEntity, bool>> predicate,//predicate orderby join atmak için
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
        bool withDeleted = false,// silinenleride getireyim mi demek withdeleted. softdelete ise veriyi silmiyorsun aslında
        bool enableTracking = true
    );

    Paginate<TEntity> GetList(
        Expression<Func<TEntity, bool>>? predicate = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true
    );

    Paginate<TEntity> GetListByDynamic(
        DynamicQuery dynamic,//DynamicQuery = 
        Expression<Func<TEntity, bool>>? predicate = null,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
        int index = 0,
        int size = 100,
        bool withDeleted = false,
        bool enableTracking = true
    );

    bool Any(Expression<Func<TEntity, bool>>? predicate = null, bool withDeleted = false, bool enableTracking = true);
    TEntity Add(TEntity entity);
    ICollection<TEntity> AddRange(ICollection<TEntity> entities);
    TEntity Update(TEntity entity);
    ICollection<TEntity> UpdateRange(ICollection<TEntity> entities);
    TEntity Delete(TEntity entity, bool permanent = false);
    ICollection<TEntity> DeleteRange(ICollection<TEntity> entity, bool permanent = false);
}