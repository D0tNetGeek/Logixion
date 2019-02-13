using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logixion.Domain.IRepository;
using Logixion.Domain.Database;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Logixion.Domain.Repository
{
    public class GenericRepository<TEntity, TKey> : IGenericRepository<TEntity, TKey> where TEntity : class where TKey : struct
    {
        protected readonly LogixionDbContext LogixionDb;

        public GenericRepository(LogixionDbContext logixionDb)
        {
            LogixionDb = logixionDb;
        }
        public virtual async  Task<TEntity> AddAsync(TEntity entity)
        {
            LogixionDb.Entry(entity).State= EntityState.Added;
            await LogixionDb.SaveChangesAsync();
            return entity;
        }

        public virtual async  Task AddRangeAsync(List<TEntity> entities)
        {
            LogixionDb.Set<TEntity>().AddRange(entities);
            await LogixionDb.SaveChangesAsync();                       
        }

        public virtual async  Task DeleteAsync(TKey id)
        {
            var entity = await LogixionDb.Set<TEntity>().FindAsync(id);
            LogixionDb.Entry(entity).State = EntityState.Deleted;
            await LogixionDb.SaveChangesAsync();
        }
        public virtual async  Task<TEntity> UpdateAsync(TEntity entity)
        {
            LogixionDb.Entry(entity).State = EntityState.Modified;
            await LogixionDb.SaveChangesAsync();
            return entity;
        }

        public virtual async  Task<IQueryable<TEntity>> GetAsync()
        {
            return await Task.FromResult(LogixionDb.Set<TEntity>().AsQueryable());
        }

        public virtual async  Task<TEntity> GetAsync(TKey id)
        {
            return await LogixionDb.Set<TEntity>().FindAsync(id);
        } 
        public virtual async  Task<IList<TEntity>> GetAsync(Expression<Func<TEntity, bool>> where)
        {
            return await LogixionDb.Set<TEntity>().Where(where).ToListAsync();
        }
        public virtual async Task<IList<TEntity>> GetAsync(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, bool>> orderBy,SortingType sortingType=SortingType.ASC)
        {
            var query = LogixionDb.Set<TEntity>().Where(where);
            if (sortingType == SortingType.ASC)
                query = query.OrderBy(orderBy);
            else
                query = query.OrderByDescending(orderBy);

            return await query.ToListAsync();
        }
        public virtual async Task<IList<TEntity>> GetAsync(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var query = LogixionDb.Set<TEntity>().AsQueryable();
            foreach (var include in includeProperties)
                query = query.Include(include);
            return await query.ToListAsync();
        }
        public virtual async  Task<IList<TEntity>> GetAsync(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, object>>[] includeProperties)
        {
            var query = LogixionDb.Set<TEntity>().Where(where);
            foreach (var include in includeProperties)
                query = query.Include(include);          
            return await query.ToListAsync();
        }
        public virtual async  Task<IList<TEntity>> GetAsync(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, bool>> orderBy, SortingType sortingType, Expression<Func<TEntity, object>>[] includeProperties)
        {
            var query = LogixionDb.Set<TEntity>().Where(where);
            foreach (var include in includeProperties)
                query = query.Include(include);
            if (sortingType == SortingType.ASC)
                query = query.OrderBy(orderBy);
            else
                query = query.OrderByDescending(orderBy);
            return await query.OrderBy(orderBy).ToListAsync();
        }
        public virtual IList<TEntity> Get(int page, int take, out int count)
        {
            count = LogixionDb.Set<TEntity>().Count();
            return LogixionDb.Set<TEntity>().Skip((page - 1) * take).Take(take).ToList();
        }
        public virtual IList<TEntity> Get(int page, int take, out int count, Expression<Func<TEntity, bool>> where)
        {
            count = LogixionDb.Set<TEntity>().Where(where).Count();
            return LogixionDb.Set<TEntity>().Where(where).Skip((page - 1) * take).Take(take).ToList();
        }
        public virtual IList<TEntity> Get(int page, int take, out int count, Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, bool>> orderBy, SortingType sortingType = SortingType.ASC)
        {
            count = LogixionDb.Set<TEntity>().Where(where).Count();
            var query = LogixionDb.Set<TEntity>().Where(where).Skip((page - 1) * take);
            if (sortingType == SortingType.ASC)
                query = query.OrderBy(orderBy);
            else
                query = query.OrderByDescending(orderBy);
            return query.ToList();
        }
        public virtual IList<TEntity> Get(int page, int take, out int count, Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            count = LogixionDb.Set<TEntity>().Where(where).Count();
            var query = LogixionDb.Set<TEntity>().Where(where).Skip((page - 1) * take).Take(take);
            foreach (var include in includeProperties)
                query = query.Include(include);
           return query.ToList();
        }
        public virtual IList<TEntity> Get(int page, int take, out int count, Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, bool>> orderBy, SortingType sortingType = SortingType.ASC, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            count = LogixionDb.Set<TEntity>().Where(where).Count();
            var query = LogixionDb.Set<TEntity>().Where(where).Skip((page - 1) * take).Take(take);
            foreach (var include in includeProperties)
                query = query.Include(include);
            if (sortingType == SortingType.ASC)
                query = query.OrderBy(orderBy);
            else
                query = query.OrderByDescending(orderBy);
            return query.ToList();
        }
      
    }
}
