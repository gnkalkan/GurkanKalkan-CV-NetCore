using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Utilities.Generics
{
    public interface IRepository<TEntity> where TEntity : class
    {
        // Create
        Task CreateAsync(TEntity entity);
        Task CreateManyAsync(IEnumerable<TEntity> entities); // Add from Excell
        // Read
        Task<TEntity?> FindByIdAsync(int id);
        Task<TEntity?> FindFirstAsync(Expression<Func<TEntity, bool>>? predicate = null, params string[] includes);
        Task<IQueryable<TEntity>> FindManyAsync(Expression<Func<TEntity, bool>>? predicate = null, params string[] includes);
        // Update
        Task UpdateAsync(TEntity entity);
        Task UpdateManyAsync(IEnumerable<TEntity> entities);
        // Delete
        Task DeleteAsync(TEntity entity);
        Task DeleteManyAsync(IEnumerable<TEntity> entities);
        // Other
        Task<int> CountAsync(Expression<Func<TEntity, bool>>? predicate = null);
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>>? predicate = null);
    }

    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    { 
        protected readonly DbContext _context;
        protected readonly DbSet<TEntity> _dbSet;
        protected Repository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>>? predicate = null)
        {
            return predicate == null
                ? await _dbSet.AnyAsync()
                : await _dbSet.AnyAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>>? predicate = null)
        {
            return predicate == null
                ? await _dbSet.CountAsync()
                : await _dbSet.CountAsync(predicate);
        }

        public async Task CreateAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task CreateManyAsync(IEnumerable<TEntity> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await Task.Run(() => _dbSet.Remove(entity)); //To Async with Task.Run
        }

        public async Task DeleteManyAsync(IEnumerable<TEntity> entities)
        {
            await Task.Run(() => _dbSet.RemoveRange(entities));
        }

        public async Task<TEntity?> FindByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<TEntity?> FindFirstAsync(Expression<Func<TEntity, bool>>? predicate = null, params string[] includes)
        {
            IQueryable<TEntity> query = predicate == null ? _dbSet : _dbSet.Where(predicate);
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            return await query.FirstOrDefaultAsync();

            //(Without Params)
            //return predicate == null
            //    ? await _dbSet.FirstOrDefaultAsync()
            //    : await _dbSet.FirstOrDefaultAsync(predicate);
        }

        public async Task<IQueryable<TEntity>> FindManyAsync(Expression<Func<TEntity, bool>>? predicate = null, params string[] includes)
        {
            IQueryable<TEntity> query = predicate == null ? _dbSet : _dbSet.Where(predicate);
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            return await Task.Run(() => query);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await Task.Run(() => _dbSet.Update(entity));
        }

        public async Task UpdateManyAsync(IEnumerable<TEntity> entities)
        {
            await Task.Run(() => _dbSet.UpdateRange(entities));
        }
    }
}
