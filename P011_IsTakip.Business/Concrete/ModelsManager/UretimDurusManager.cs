using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.DataAccess.Abstract.IModelsRepository;
using P011_IsTakip.Entities.Classes;
using System.Linq.Expressions;

namespace P011_IsTakip.Business.Concrete.ModelsManager
{
	public class UretimDurusManager : IUretimDurusService
	{
		private readonly IUretimDurusRepository _uretimDurusRepository;

		public UretimDurusManager(IUretimDurusRepository uretimDurusRepository)
		{
			_uretimDurusRepository = uretimDurusRepository;
		}

		public void Add(UretimDurus item)
		{
			_uretimDurusRepository.Add(item);
		}

		public async Task AddAsync(UretimDurus item)
		{
			await _uretimDurusRepository.AddAsync(item);
		}

		public bool Any(Expression<Func<UretimDurus, bool>> filter)
		{
			return _uretimDurusRepository.Any(filter);
		}

		public async Task<bool> AnyAsync(Expression<Func<UretimDurus, bool>> filter)
		{
			return await _uretimDurusRepository.AnyAsync(filter);
		}

		public int Count(Expression<Func<UretimDurus, bool>> filter)
		{
			return _uretimDurusRepository.Count(filter);
		}

		public async Task<int> CountAsync(Expression<Func<UretimDurus, bool>> filter)
		{
			return await _uretimDurusRepository.CountAsync(filter);
		}

		public void Delete(UretimDurus item)
		{
			_uretimDurusRepository.Delete(item);
		}

		public UretimDurus Get(Expression<Func<UretimDurus, bool>> filter, string includeProperties = "")
		{
			return _uretimDurusRepository.Get(filter, includeProperties);
		}

		public async Task<UretimDurus> GetAsync(Expression<Func<UretimDurus, bool>> filter, string includeProperties = "")
		{
			return await _uretimDurusRepository.GetAsync(filter, includeProperties);
		}

		public UretimDurus GetById(int id)
		{
			return _uretimDurusRepository.GetById(id);
		}

		public async Task<UretimDurus> GetByIdAsync(int id)
		{
			return await _uretimDurusRepository.GetByIdAsync(id);
		}

		public IEnumerable<UretimDurus> GetList(Expression<Func<UretimDurus, bool>> filter = null, Func<IQueryable<UretimDurus>, IOrderedQueryable<UretimDurus>> orderBy = null, string includeProperties = "")
		{
			return _uretimDurusRepository.GetList(filter, orderBy, includeProperties);
		}

		public async Task<IEnumerable<UretimDurus>> GetListAsync(Expression<Func<UretimDurus, bool>> filter = null, Func<IQueryable<UretimDurus>, IOrderedQueryable<UretimDurus>> orderBy = null, string includeProperties = "")
		{
			return await _uretimDurusRepository.GetListAsync(filter, orderBy, includeProperties);
		}

		public IEnumerable<UretimDurus> GetSelectDurusTip()
		{
			return _uretimDurusRepository.GetList(t => t.DurusTip.Id != 0,null,"");
		}

		public IEnumerable<UretimDurus> GetSelectUretimEmri()
		{
			return _uretimDurusRepository.GetList(t => t.UretimEmri.Id != 0, null, "");
		
		}

		public int Save()
		{
			return _uretimDurusRepository.Save();
		}

		public async Task<int> SaveAsync()
		{
			return await _uretimDurusRepository.SaveAsync();
		}

		public void Update(UretimDurus item)
		{
			_uretimDurusRepository.Update(item);
		}
	}
}
