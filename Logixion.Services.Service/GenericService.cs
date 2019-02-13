using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Logixion.Services.IService;
using Logixion.Domain.IRepository;
using AutoMapper;
namespace Logixion.Services.Service
{
    public class GenericService<TBusinessModel, TEntity, TKey> : IGenericService<TBusinessModel, TEntity, TKey> where TBusinessModel : class where TEntity : class where TKey : struct
    {
        private readonly IGenericRepository<TEntity, TKey> _genericRepository; 
        public GenericService(IGenericRepository<TEntity,TKey> genericRepository )
        {
            _genericRepository = genericRepository;                
        }
        public async virtual Task<TBusinessModel> AddAsync(TBusinessModel entity)
        {
            var _entity = Mapper.Map<TBusinessModel, TEntity>(entity);
            _entity=await _genericRepository.AddAsync(_entity);
            return Mapper.Map<TEntity, TBusinessModel>(_entity);
        }

        public async virtual Task AddRangeAsync(List<TBusinessModel> entities)
        {
            var _entities = Mapper.Map<List<TBusinessModel>, List<TEntity>  >(entities);
              await _genericRepository.AddRangeAsync(_entities); 
        }

        public async virtual Task DeleteAsync(TKey id)
        {
            await _genericRepository.DeleteAsync(id);
        }

        public virtual IList<TBusinessModel> Get(int page, int take, out int count)
        {
            var _entities = _genericRepository.Get(page, take, out count);
            return Mapper.Map<IList<TEntity>, IList<TBusinessModel>>(_entities);
        }

        public virtual IList<TBusinessModel> Get(int page, int take, out int count, Expression<Func<TEntity, bool>> where)
        {
            var _entities = _genericRepository.Get(page, take, out count, where);
            return Mapper.Map<IList<TEntity>, IList<TBusinessModel>>(_entities);
        }

        public virtual IList<TBusinessModel> Get(int page, int take, out int count, Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, bool>> orderBy, SortingType sortingType = SortingType.ASC)
        {
            var _entities = _genericRepository.Get(page, take, out count, where,orderBy,sortingType);
            return Mapper.Map<IList<TEntity>, IList<TBusinessModel>>(_entities);
        }

        public virtual IList<TBusinessModel> Get(int page, int take, out int count, Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var _entities = _genericRepository.Get(page, take, out count, where,includeProperties);
            return Mapper.Map<IList<TEntity>, IList<TBusinessModel>>(_entities);
        }

        public virtual IList<TBusinessModel> Get(int page, int take, out int count, Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, bool>> orderBy, SortingType sortingType = SortingType.ASC, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var _entities = _genericRepository.Get(page, take, out count, where,orderBy,sortingType,includeProperties);
            return Mapper.Map<IList<TEntity>, IList<TBusinessModel>>(_entities);
        }

        public virtual async Task<TBusinessModel> GetAsync(TKey id)
        {
            var _entity = await _genericRepository.GetAsync(id);
            return Mapper.Map<TEntity, TBusinessModel>(_entity);
        }

        public virtual async Task<IList<TBusinessModel>> GetAsync()
        {
            var _entities = await _genericRepository.GetAsync();
            return Mapper.Map<IList<TEntity>, IList<TBusinessModel>>(_entities.ToList());
        }

        public virtual async Task<IList<TBusinessModel>> GetAsync(Expression<Func<TEntity, bool>> where)
        {
            var _entities = await _genericRepository.GetAsync(where);
            return Mapper.Map<IList<TEntity>, IList<TBusinessModel>>(_entities);
        }

        public virtual async Task<IList<TBusinessModel>> GetAsync(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, bool>> orderBy, SortingType sortingType = SortingType.ASC)
        {
            var _entities = await _genericRepository.GetAsync(where, orderBy, sortingType);
            return Mapper.Map<IList<TEntity>, IList<TBusinessModel>>(_entities);
        }
            public virtual async Task<IList<TBusinessModel>> GetAsync(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var _entities = await _genericRepository.GetAsync(includeProperties);
            return Mapper.Map<IList<TEntity>, IList<TBusinessModel>>(_entities);
        }

        public virtual async Task<IList<TBusinessModel>> GetAsync(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, object>>[] includeProperties)
        {
            var _entities = await _genericRepository.GetAsync(where,includeProperties);
            return Mapper.Map<IList<TEntity>, IList<TBusinessModel>>(_entities);
        }

        public async Task<IList<TBusinessModel>> GetAsync(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, bool>> orderBy, SortingType sortingType, Expression<Func<TEntity, object>>[] includeProperties)
        {
            var _entities = await _genericRepository.GetAsync(where,orderBy,sortingType,includeProperties);
            return Mapper.Map<IList<TEntity>, IList<TBusinessModel>>(_entities);
        }

        public virtual async Task<TBusinessModel> UpdateAsync(TBusinessModel entity)
        {
          var _entity= Mapper.Map<TBusinessModel, TEntity>(entity);
           _entity= await _genericRepository.UpdateAsync(_entity);
           return Mapper.Map<TEntity, TBusinessModel>(_entity);
        }
    }
}
