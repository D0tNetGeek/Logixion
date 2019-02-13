using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Logixion.Services.IService
{
    public interface IGenericService<TBusinessModel,TEntity,TKey> where TBusinessModel : class where TEntity:class where TKey:struct
    {
        Task<TBusinessModel> AddAsync(TBusinessModel entity);
        Task AddRangeAsync(List<TBusinessModel> entities);
        Task<TBusinessModel> GetAsync(TKey id);
        Task<IList<TBusinessModel>> GetAsync();
        IList<TBusinessModel> Get(int page, int take, out int count);
        Task<IList<TBusinessModel>> GetAsync(Expression<Func<TEntity, bool>> where);
        Task<IList<TBusinessModel>> GetAsync(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, bool>> orderBy, SortingType sortingType = SortingType.ASC);
        Task<IList<TBusinessModel>> GetAsync(params Expression<Func<TEntity, object>>[] includeProperties);
        Task<IList<TBusinessModel>> GetAsync(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, object>>[] includeProperties);
        Task<IList<TBusinessModel>> GetAsync(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, bool>> orderBy, SortingType sortingType, Expression<Func<TEntity, object>>[] includeProperties);
        IList<TBusinessModel> Get(int page, int take, out int count, Expression<Func<TEntity, bool>> where);
        IList<TBusinessModel> Get(int page, int take, out int count, Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, bool>> orderBy, SortingType sortingType = SortingType.ASC);
        IList<TBusinessModel> Get(int page, int take, out int count, Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includeProperties);
        IList<TBusinessModel> Get(int page, int take, out int count, Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, bool>> orderBy, SortingType sortingType = SortingType.ASC, params Expression<Func<TEntity, object>>[] includeProperties);
        Task DeleteAsync(TKey id);
        Task<TBusinessModel> UpdateAsync(TBusinessModel entity);
    }
}
