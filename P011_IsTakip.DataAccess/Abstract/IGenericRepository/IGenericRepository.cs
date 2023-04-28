using System.Linq.Expressions;

namespace P011_IsTakip.DataAccess.Abstract.IGenericRepository
{
    public interface IGenericRepository<T> where T : class, new()
    {
        T GetById(int id);

        T Get(Expression<Func<T, bool>> filter, string includeProperties = "");

        int Count(Expression<Func<T, bool>> filter);

        int Save();

        bool Any(Expression<Func<T, bool>> filter);

        IEnumerable<T> GetList(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");

        void Add(T item);

        void Update(T item);

        void Delete(T item);


        //Async

        Task<T> GetByIdAsync(int id);

        Task<T> GetAsync(Expression<Func<T, bool>> filter, string includeProperties = "");

        Task AddAsync(T item);

        Task<IEnumerable<T>> GetListAsync(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");

        Task<int> CountAsync(Expression<Func<T, bool>> filter);

        Task<bool> AnyAsync(Expression<Func<T, bool>> filter);

        Task<int> SaveAsync();


    }
}
