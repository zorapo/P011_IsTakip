using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.DataAccess.Abstract.IModelsRepository;
using P011_IsTakip.Entities.Classes;
using System.Linq.Expressions;

namespace P011_IsTakip.Business.Concrete.ModelsManager
{
	public class DepoEnvanterManager : IDepoEnvanterService
	{

		private readonly IDepoEnvanterRepository _depoEnvanterRepository;

		public DepoEnvanterManager(IDepoEnvanterRepository depoEnvanterRepository)
		{
			_depoEnvanterRepository = depoEnvanterRepository;
		}

		public void Add(DepoEnvanter item)
		{
			_depoEnvanterRepository.Add(item);
		}

		public async Task AddAsync(DepoEnvanter item)
		{
			await _depoEnvanterRepository.AddAsync(item);
		}

		public bool Any(Expression<Func<DepoEnvanter, bool>> filter)
		{
			return _depoEnvanterRepository.Any(filter);
		}

		public async Task<bool> AnyAsync(Expression<Func<DepoEnvanter, bool>> filter)
		{
			return await _depoEnvanterRepository.AnyAsync(filter);
		}

		public int Count(Expression<Func<DepoEnvanter, bool>> filter)
		{
			return _depoEnvanterRepository.Count(filter);
		}

		public async Task<int> CountAsync(Expression<Func<DepoEnvanter, bool>> filter)
		{
			return await _depoEnvanterRepository.CountAsync(filter);
		}

		public void Delete(DepoEnvanter item)
		{
			_depoEnvanterRepository.Delete(item);
		}

		public DepoEnvanter Get(Expression<Func<DepoEnvanter, bool>> filter, string includeProperties = "")
		{
			return _depoEnvanterRepository.Get(filter, includeProperties);
		}

		public async Task<DepoEnvanter> GetAsync(Expression<Func<DepoEnvanter, bool>> filter, string includeProperties = "")
		{
			return await _depoEnvanterRepository.GetAsync(filter, includeProperties);
		}

		public DepoEnvanter GetById(int id)
		{
			return _depoEnvanterRepository.GetById(id);
		}

		public async Task<DepoEnvanter> GetByIdAsync(int id)
		{
			return await _depoEnvanterRepository.GetByIdAsync(id);
		}

		public IEnumerable<DepoEnvanter> GetList(Expression<Func<DepoEnvanter, bool>> filter = null, Func<IQueryable<DepoEnvanter>, IOrderedQueryable<DepoEnvanter>> orderBy = null, string includeProperties = "")
		{
			return _depoEnvanterRepository.GetList(filter, orderBy, includeProperties);
		}

		public async Task<IEnumerable<DepoEnvanter>> GetListAsync(Expression<Func<DepoEnvanter, bool>> filter = null, Func<IQueryable<DepoEnvanter>, IOrderedQueryable<DepoEnvanter>> orderBy = null, string includeProperties = "")
		{
			return await _depoEnvanterRepository.GetListAsync(filter, orderBy, includeProperties);
		}

		public IEnumerable<DepoEnvanter> GetSelectDepoId()
		{
			return _depoEnvanterRepository.GetList(t => t.Depo.Id != 0, null, "");
		}

		public IEnumerable<DepoEnvanter> GetSelectDepoRafId()
		{
			return _depoEnvanterRepository.GetList(t => t.DepoRaf.Id != 0, null, "");
		}

		public IEnumerable<DepoEnvanter> GetSelectKalinlikId()
		{
			return _depoEnvanterRepository.GetList(t => t.Kalinlik.Id != 0, null, "");
		}

		public IEnumerable<DepoEnvanter> GetSelectMalzemeTipId()
		{
			return _depoEnvanterRepository.GetList(t => t.MalzemeTip.Id != 0, null, "");
		}
	
		public int Save()
		{
			return _depoEnvanterRepository.Save();
		}

		public async Task<int> SaveAsync()
		{
			return await _depoEnvanterRepository.SaveAsync();
		}

		public void Update(DepoEnvanter item)
		{
			_depoEnvanterRepository.Update(item);
		}

	}
}
