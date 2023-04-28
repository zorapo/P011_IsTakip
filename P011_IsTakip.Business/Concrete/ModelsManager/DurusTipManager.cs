using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.DataAccess.Abstract.IModelsRepository;
using P011_IsTakip.Entities.Classes;
using System.Linq.Expressions;

namespace P011_IsTakip.Business.Concrete.ModelsManager
{
	public class DurusTipManager : IDurusTipService
	{
		private readonly IDurusTipRepository _durusTipRepository;

		public DurusTipManager(IDurusTipRepository durusTipRepository)
		{
			_durusTipRepository = durusTipRepository;
		}

		public void Add(DurusTip item)
		{
			_durusTipRepository.Add(item);
		}

		public async Task AddAsync(DurusTip item)
		{
			await _durusTipRepository.AddAsync(item);
		}

		public bool Any(Expression<Func<DurusTip, bool>> filter)
		{
			return _durusTipRepository.Any(filter);
		}

		public async Task<bool> AnyAsync(Expression<Func<DurusTip, bool>> filter)
		{
			return await _durusTipRepository.AnyAsync(filter);
		}

		public int Count(Expression<Func<DurusTip, bool>> filter)
		{
			return _durusTipRepository.Count(filter);
		}

		public async Task<int> CountAsync(Expression<Func<DurusTip, bool>> filter)
		{
			return await _durusTipRepository.CountAsync(filter);
		}

		public void Delete(DurusTip item)
		{
			_durusTipRepository.Delete(item);
		}

		public DurusTip Get(Expression<Func<DurusTip, bool>> filter, string includeProperties = "")
		{
			return _durusTipRepository.Get(filter, includeProperties);
		}

		public async Task<DurusTip> GetAsync(Expression<Func<DurusTip, bool>> filter, string includeProperties = "")
		{
			return await _durusTipRepository.GetAsync(filter, includeProperties);
		}

		public DurusTip GetById(int id)
		{
			return _durusTipRepository.GetById(id);
		}

		public async Task<DurusTip> GetByIdAsync(int id)
		{
			return await _durusTipRepository.GetByIdAsync(id);
		}

		public IEnumerable<DurusTip> GetList(Expression<Func<DurusTip, bool>> filter = null, Func<IQueryable<DurusTip>, IOrderedQueryable<DurusTip>> orderBy = null, string includeProperties = "")
		{
			return _durusTipRepository.GetList(filter, orderBy, includeProperties);
		}

		public async Task<IEnumerable<DurusTip>> GetListAsync(Expression<Func<DurusTip, bool>> filter = null, Func<IQueryable<DurusTip>, IOrderedQueryable<DurusTip>> orderBy = null, string includeProperties = "")
		{
			return await _durusTipRepository.GetListAsync(filter, orderBy, includeProperties);
		}

		public int Save()
		{
			return _durusTipRepository.Save();
		}

		public async Task<int> SaveAsync()
		{
			return await _durusTipRepository.SaveAsync();
		}

		public void Update(DurusTip item)
		{
			_durusTipRepository.Update(item);
		}
	}
}
