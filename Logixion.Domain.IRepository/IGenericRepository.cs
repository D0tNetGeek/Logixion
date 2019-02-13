using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Logixion.Domain.IRepository
{
    public interface IGenericRepository<TEntity, TKey> where TEntity : class where TKey:struct
    {
        Task<TEntity> AddAsync(TEntity entity);
        Task AddRangeAsync(List<TEntity> entities);
        Task<TEntity> GetAsync(TKey id); 
        Task<IQueryable<TEntity>> GetAsync();
        IList<TEntity> Get(int page, int take, out int count);
        Task<IList<TEntity>> GetAsync(Expression<Func<TEntity, bool>> where);
        Task<IList<TEntity>> GetAsync(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, bool>> orderBy, SortingType sortingType = SortingType.ASC);
        Task<IList<TEntity>> GetAsync(params Expression<Func<TEntity, object>>[] includeProperties);
        Task<IList<TEntity>> GetAsync(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, object>>[] includeProperties);
        Task<IList<TEntity>> GetAsync(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, bool>> orderBy, SortingType sortingType, Expression<Func<TEntity, object>>[] includeProperties);
        IList<TEntity> Get(int page, int take, out int count, Expression<Func<TEntity, bool>> where);
        IList<TEntity> Get(int page, int take, out int count, Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, bool>> orderBy, SortingType sortingType = SortingType.ASC);
        IList<TEntity> Get(int page, int take, out int count, Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includeProperties);
        IList<TEntity> Get(int page, int take, out int count, Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, bool>> orderBy, SortingType sortingType = SortingType.ASC, params Expression<Func<TEntity, object>>[] includeProperties);
        Task DeleteAsync(TKey id);
        Task<TEntity> UpdateAsync(TEntity entity);
    }
}
