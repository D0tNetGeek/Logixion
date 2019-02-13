using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Logixion.Services.IRepository
{
    public interface IGenericService<TBusinessModel,TEntity,TKey> where TBusinessModel : class where TEntity:class where TKey:struct
    {
        Task<TBusinessModel> AddAsync(TBusinessModel entity);
        Task AddRangeAsync(List<TBusinessModel> entities);
        Task<TBusinessModel> GetAsync(TKey id);
        Task<IQueryable<TBusinessModel>> GetAsync();
        IList<TBusinessModel> Get(int page, int take, out int count);
        Task<IList<TBusinessModel>> GetAsync(Expression<Func<TBusinessModel, bool>> where);
        Task<IList<TBusinessModel>> GetAsync(Expression<Func<TBusinessModel, bool>> where, Expression<Func<TBusinessModel, bool>> orderBy, SortingType sortingType = SortingType.ASC);
        Task<IList<TBusinessModel>> GetAsync(params Expression<Func<TBusinessModel, object>>[] includeProperties);
        Task<IList<TBusinessModel>> GetAsync(Expression<Func<TBusinessModel, bool>> where, Expression<Func<TBusinessModel, object>>[] includeProperties);
        Task<IList<TBusinessModel>> GetAsync(Expression<Func<TBusinessModel, bool>> where, Expression<Func<TBusinessModel, bool>> orderBy, SortingType sortingType, Expression<Func<TBusinessModel, object>>[] includeProperties);
        IList<TBusinessModel> Get(int page, int take, out int count, Expression<Func<TBusinessModel, bool>> where);
        IList<TBusinessModel> Get(int page, int take, out int count, Expression<Func<TBusinessModel, bool>> where, Expression<Func<TBusinessModel, bool>> orderBy, SortingType sortingType = SortingType.ASC);
        IList<TBusinessModel> Get(int page, int take, out int count, Expression<Func<TBusinessModel, bool>> where, params Expression<Func<TBusinessModel, object>>[] includeProperties);
        IList<TBusinessModel> Get(int page, int take, out int count, Expression<Func<TBusinessModel, bool>> where, Expression<Func<TBusinessModel, bool>> orderBy, SortingType sortingType = SortingType.ASC, params Expression<Func<TBusinessModel, object>>[] includeProperties);
        Task DeleteAsync(TKey id);
        Task<TBusinessModel> UpdateAsync(TBusinessModel entity);
    }
}
