using P011_IsTakip.Business.Abstract.GenericService;
using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.DataAccess.Abstract.IModelsRepository;
using P011_IsTakip.Entities.Classes;
using System.Linq.Expressions;

namespace P011_IsTakip.Business.Concrete.ModelsManager
{
	public class DepoManager : IDepoService
	{
		private readonly IDepoRepository _depoRepository;

		public DepoManager(IDepoRepository depoRepository)
		{
			_depoRepository = depoRepository;
		}

		public void Add(Depo item)
		{
			_depoRepository.Add(item);
		}

		public async Task AddAsync(Depo item)
		{
			await _depoRepository.AddAsync(item);
		}

		public bool Any(Expression<Func<Depo, bool>> filter)
		{
			return _depoRepository.Any(filter);
		}

		public async Task<bool> AnyAsync(Expression<Func<Depo, bool>> filter)
		{
			return await _depoRepository.AnyAsync(filter);
		}

		public int Count(Expression<Func<Depo, bool>> filter)
		{
			return _depoRepository.Count(filter);
		}

		public async Task<int> CountAsync(Expression<Func<Depo, bool>> filter)
		{
			return await _depoRepository.CountAsync(filter);
		}

		public void Delete(Depo item)
		{
			_depoRepository.Delete(item);
		}

		public Depo Get(Expression<Func<Depo, bool>> filter, string includeProperties = "")
		{
			return _depoRepository.Get(filter, includeProperties);
		}

		public async Task<Depo> GetAsync(Expression<Func<Depo, bool>> filter, string includeProperties = "")
		{
			return await _depoRepository.GetAsync(filter, includeProperties);
		}

		public Depo GetById(int id)
		{
			return _depoRepository.GetById(id);
		}

		public async Task<Depo> GetByIdAsync(int id)
		{
			return await _depoRepository.GetByIdAsync(id);
		}

		public IEnumerable<Depo> GetList(Expression<Func<Depo, bool>> filter = null, Func<IQueryable<Depo>, IOrderedQueryable<Depo>> orderBy = null, string includeProperties = "")
		{
			return _depoRepository.GetList(filter, orderBy, includeProperties);
		}

		public async Task<IEnumerable<Depo>> GetListAsync(Expression<Func<Depo, bool>> filter = null, Func<IQueryable<Depo>, IOrderedQueryable<Depo>> orderBy = null, string includeProperties = "")
		{
			return await _depoRepository.GetListAsync(filter, orderBy, includeProperties);
		}

		public int Save()
		{
			return _depoRepository.Save();
		}

		public async Task<int> SaveAsync()
		{
			return await _depoRepository.SaveAsync();
		}

		public void Update(Depo item)
		{
			_depoRepository.Update(item);
		}

		
	}
}
