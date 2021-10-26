using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace HR.LeaveManagement.Application.Persistence.Contracts
{

    public interface IGenericRepository<T> where T : class
    {
        Task<IList<T>> FindAll(
            Expression<Func<T, bool>> expression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null
            );
        Task<T> Find(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null);
        Task<bool> isExists(Expression<Func<T, bool>> expression = null);
        Task Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}


