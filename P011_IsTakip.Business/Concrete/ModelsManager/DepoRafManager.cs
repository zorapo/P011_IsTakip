using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.DataAccess.Abstract.IModelsRepository;
using P011_IsTakip.Entities.Classes;
using System.Linq.Expressions;

namespace P011_IsTakip.Business.Concrete.ModelsManager
{
	public class DepoRafManager : IDepoRafService
	{
		private readonly IDepoRafRepository _depoRafRepository;

		public DepoRafManager(IDepoRafRepository depoRafRepository)
		{
			_depoRafRepository = depoRafRepository;
		}

		public void Add(DepoRaf item)
		{
			_depoRafRepository.Add(item);
		}

		public async Task AddAsync(DepoRaf item)
		{
			await _depoRafRepository.AddAsync(item);
		}

		public bool Any(Expression<Func<DepoRaf, bool>> filter)
		{
			return _depoRafRepository.Any(filter);
		}

		public async Task<bool> AnyAsync(Expression<Func<DepoRaf, bool>> filter)
		{
			return await _depoRafRepository.AnyAsync(filter);
		}

		public int Count(Expression<Func<DepoRaf, bool>> filter)
		{
			return _depoRafRepository.Count(filter);
		}

		public async Task<int> CountAsync(Expression<Func<DepoRaf, bool>> filter)
		{
			return await _depoRafRepository.CountAsync(filter);
		}

		public void Delete(DepoRaf item)
		{
			_depoRafRepository.Delete(item);
		}

		public DepoRaf Get(Expression<Func<DepoRaf, bool>> filter, string includeProperties = "")
		{
			return _depoRafRepository.Get(filter, includeProperties);
		}

		public async Task<DepoRaf> GetAsync(Expression<Func<DepoRaf, bool>> filter, string includeProperties = "")
		{
			return await _depoRafRepository.GetAsync(filter, includeProperties);
		}

		public DepoRaf GetById(int id)
		{
			return _depoRafRepository.GetById(id);
		}

		public async Task<DepoRaf> GetByIdAsync(int id)
		{
			return await _depoRafRepository.GetByIdAsync(id);
		}

		public IEnumerable<DepoRaf> GetList(Expression<Func<DepoRaf, bool>> filter = null, Func<IQueryable<DepoRaf>, IOrderedQueryable<DepoRaf>> orderBy = null, string includeProperties = "")
		{
			return _depoRafRepository.GetList(filter, orderBy, includeProperties);
		}

		public async Task<IEnumerable<DepoRaf>> GetListAsync(Expression<Func<DepoRaf, bool>> filter = null, Func<IQueryable<DepoRaf>, IOrderedQueryable<DepoRaf>> orderBy = null, string includeProperties = "")
		{
			return await _depoRafRepository.GetListAsync(filter, orderBy, includeProperties);
		}

		public int Save()
		{
			return _depoRafRepository.Save();
		}

		public async Task<int> SaveAsync()
		{
			return await _depoRafRepository.SaveAsync();
		}

		public void Update(DepoRaf item)
		{
			_depoRafRepository.Update(item);
		}

	}
}
