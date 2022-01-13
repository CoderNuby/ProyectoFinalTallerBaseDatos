using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StockAndSale.Data.Repositories.Implementation
{
    public class Repository<TContext, TEntity> : IRepository<TEntity>
        where TEntity : class
        where TContext : DbContext
    {
        protected TContext _context;

        public Repository(TContext context)
        {
            _context = context;
        }

        public TEntity Get(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().SingleOrDefault(predicate);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, object>> include)
        {
            return _context.Set<TEntity>().Include(include).SingleOrDefault(predicate);
        }

        public ICollection<TEntity> GetAll()
        {
            try
            {
                return _context.Set<TEntity>().ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        public ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate).ToList();
        }

        public async Task<ICollection<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<ICollection<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().Where(predicate).ToListAsync();
        }

        public async Task<TEntity> GetAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().SingleOrDefaultAsync(predicate);
        }

        public TEntity Add(TEntity entity, bool saveChanges = false)
        {
            _context.Set<TEntity>().Add(entity);

            if (saveChanges)
            {
                _context.SaveChanges();
            }

            return entity;
        }

        public async Task<TEntity> AddAsync(TEntity entity, bool saveChanges = false)
        {
            await _context.Set<TEntity>().AddAsync(entity);

            if (saveChanges)
            {
                _context.SaveChanges();
            }

            return entity;
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _context.Set<TEntity>().Find(id);
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }

        public void Delete<T>(int id, bool saveChanges = false) where T : class
        {
            var entity = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(entity);

            if (saveChanges)
                _context.SaveChanges();
        }

        public async Task DeleteAsync(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = _context.Set<TEntity>().Find(id);
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public TEntity Update(TEntity entity, object key, bool saveChanges = false)
        {
            if (entity == null) return null;

            TEntity entityToSave = _context.Set<TEntity>().Find(key);

            if (entityToSave != null)
            {
                _context.Entry(entityToSave).CurrentValues.SetValues(entity);
            }

            if (saveChanges)
            {
                _context.SaveChanges();
            }

            return entityToSave;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity, object key, bool saveChanges = false)
        {
            if (entity == null) return null;

            TEntity entityToSave = await _context.Set<TEntity>().FindAsync(key);

            if (entityToSave != null)
            {
                _context.Entry(entityToSave).CurrentValues.SetValues(entity);
            }

            if (saveChanges)
            {
                await _context.SaveChangesAsync();
            }

            return entityToSave;
        }

        public async Task<int> CountAsync()
        {
            return await _context.Set<TEntity>().CountAsync();
        }

        public int Count()
        {
            return _context.Set<TEntity>().Count();
        }

        public void ApplyChanges()
        {
            _context.SaveChanges();
        }
    }
}
