using Microsoft.EntityFrameworkCore;
using P011_IsTakip.DataAccess.Abstract.IGenericRepository;
using P011_IsTakip.DataAccess.Context;
using System.Linq.Expressions;

namespace P011_IsTakip.DataAccess.Concrete.EntityFramework.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : class, new()     
    {
        private readonly DataContext _context;

        public GenericRepository(DataContext context)
        {
            _context = context;
        }      

        public void Add(TEntity item)
        {
            var model = _context.Entry(item);
            model.State = EntityState.Added;
        }

        public async Task AddAsync(TEntity item)
        {
            await _context.Set<TEntity>().AddAsync(item);
        }

        public bool Any(Expression<Func<TEntity, bool>> filter)
        {
            return _context.Set<TEntity>().Any(filter);
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await _context.Set<TEntity>().AnyAsync(filter);
        }

        public int Count(Expression<Func<TEntity, bool>> filter)
        {
            return _context.Set<TEntity>().Where(filter).Count();
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await _context.Set<TEntity>().Where(filter).CountAsync();
        }

        public void Delete(TEntity item)
        {
            var model = _context.Entry(item);
            model.State = EntityState.Deleted;
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter, string includeProperties = "")
        {

            IQueryable<TEntity> model = _context.Set<TEntity>().Where(filter);

            if (includeProperties != null || !string.IsNullOrWhiteSpace(includeProperties))
            {

                foreach (var incp in includeProperties.Split(new char[] { '½' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    model = model.Include(incp);
                }

                return model.FirstOrDefault();
            }

            return model.FirstOrDefault();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter, string includeProperties = "")
        {

            IQueryable<TEntity> model = _context.Set<TEntity>().Where(filter);

            if (includeProperties != null || !string.IsNullOrWhiteSpace(includeProperties))
            {

                foreach (var incp in includeProperties.Split(new char[] { '½' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    model = model.Include(incp);
                }

                return await model.FirstOrDefaultAsync();
            }

            return await model.FirstOrDefaultAsync();
        }


        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (includeProperties != null || !string.IsNullOrWhiteSpace(includeProperties))
            {
                foreach (var incp in includeProperties.Split(new char[] { '½' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(incp);
                }
            }
            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }

        }

        public async Task<IEnumerable<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (includeProperties != null || !string.IsNullOrWhiteSpace(includeProperties))
            {
                foreach (var incp in includeProperties.Split(new char[] { '½' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(incp);
                }
            }
            if (orderBy != null)
            {
                return await orderBy(query).ToListAsync();
            }
            else
            {
                return await query.ToListAsync();
            }

        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Update(TEntity item)
        {
            var model = _context.Entry(item);
            model.State = EntityState.Modified;
        }
    }
}
