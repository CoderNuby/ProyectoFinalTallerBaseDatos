using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StockAndSale.Data.Repositories
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Gets an entity by ID asynchronously
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> GetAsync(int id);

        /// <summary>
        /// Gets an entity by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T Get(int id);

        /// <summary>
        /// Gets an entity by a query predicate asynchronously
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<T> GetAsync(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Gets an entity by a query predicate
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        T Get(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Gets an entity by a query predicate with include
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="include"></param>
        /// <returns></returns>
        T Get(Expression<Func<T, bool>> predicate, Expression<Func<T, object>> include);

        /// <summary>
        /// Gets a collection of all records of an entity asynchronously
        /// </summary>
        /// <returns></returns>
        Task<ICollection<T>> GetAllAsync();

        /// <summary>
        /// Gets a collection of all records of an entity
        /// </summary>
        /// <returns></returns>
        ICollection<T> GetAll();

        /// <summary>
        /// Gets a collection of all record of an entity by a predicate asynchronously
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<ICollection<T>> GetAllAsync(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Gets a collection of all record of an entity by a predicate
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        ICollection<T> GetAll(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Adds an entity asynchronously
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<T> AddAsync(T entity, bool saveChanges = false);

        /// <summary>
        /// Adds an entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        T Add(T entity, bool saveChanges = false);

        /// <summary>
        /// Updates an entity asynchronously
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<T> UpdateAsync(T entity, object key, bool saveChanges = false);

        /// <summary>
        /// Updates an entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        T Update(T entity, object key, bool saveChanges = false);

        /// <summary>1
        /// Deletes an entity asynchronously
        /// </summary>
        /// <param name="entity"></param>
        Task DeleteAsync(T entity);

        /// <summary>1
        /// Deletes an entity
        /// </summary>
        /// <param name="entity"></param>
        void Delete(T entity);

        /// <summary>
        /// Deletes an entity of any Type
        /// </summary>
        /// <typeparam name="TType"></typeparam>
        /// <param name="id"></param>
        void Delete<TType>(int id, bool saveChanges = false) where TType : class;

        /// <summary>
        /// Deletest an entity by ID asynchronously
        /// </summary>
        /// <param name="id"></param>
        Task DeleteAsync(int id);

        /// <summary>
        /// Deletest an entity by ID
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);

        /// <summary>
        /// Gets an entity count asynchronously
        /// </summary>
        /// <returns></returns>
        Task<int> CountAsync();

        /// <summary>
        /// Gets an entity count
        /// </summary>
        /// <returns></returns>
        int Count();

        /// <summary>
        /// For batch update
        /// </summary>
        void ApplyChanges();
    }
}
