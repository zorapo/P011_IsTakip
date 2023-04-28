using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.DataAccess.Abstract.IModelsRepository;
using P011_IsTakip.Entities.Classes;
using System.Linq.Expressions;

namespace P011_IsTakip.Business.Concrete.ModelsManager
{
	public class UretimEmriManager :IUretimEmriService
	{
		private readonly IUretimEmriRepository _uretimEmriRepository;

		public UretimEmriManager(IUretimEmriRepository uretimEmriRepository)
		{
			_uretimEmriRepository = uretimEmriRepository;
		}

		public void Add(UretimEmri item)
		{
			_uretimEmriRepository.Add(item);
		}

		public async Task AddAsync(UretimEmri item)
		{
			await _uretimEmriRepository.AddAsync(item);
		}

		public bool Any(Expression<Func<UretimEmri, bool>> filter)
		{
			return _uretimEmriRepository.Any(filter);
		}

		public async Task<bool> AnyAsync(Expression<Func<UretimEmri, bool>> filter)
		{
			return await _uretimEmriRepository.AnyAsync(filter);
		}

		public int Count(Expression<Func<UretimEmri, bool>> filter)
		{
			return _uretimEmriRepository.Count(filter);
		}

		public async Task<int> CountAsync(Expression<Func<UretimEmri, bool>> filter)
		{
			return await _uretimEmriRepository.CountAsync(filter);
		}

		public void Delete(UretimEmri item)
		{
			_uretimEmriRepository.Delete(item);
		}

		public UretimEmri Get(Expression<Func<UretimEmri, bool>> filter, string includeProperties = "")
		{
			return _uretimEmriRepository.Get(filter, includeProperties);
		}

		public async Task<UretimEmri> GetAsync(Expression<Func<UretimEmri, bool>> filter, string includeProperties = "")
		{
			return await _uretimEmriRepository.GetAsync(filter, includeProperties);
		}

		public UretimEmri GetById(int id)
		{
			return _uretimEmriRepository.GetById(id);
		}

		public async Task<UretimEmri> GetByIdAsync(int id)
		{
			return await _uretimEmriRepository.GetByIdAsync(id);
		}

		public IEnumerable<UretimEmri> GetList(Expression<Func<UretimEmri, bool>> filter = null, Func<IQueryable<UretimEmri>, IOrderedQueryable<UretimEmri>> orderBy = null, string includeProperties = "")
		{
			return _uretimEmriRepository.GetList(filter, orderBy, includeProperties);
		}

		public async Task<IEnumerable<UretimEmri>> GetListAsync(Expression<Func<UretimEmri, bool>> filter = null, Func<IQueryable<UretimEmri>, IOrderedQueryable<UretimEmri>> orderBy = null, string includeProperties = "")
		{
			return await _uretimEmriRepository.GetListAsync(filter, orderBy, includeProperties);
		}

		public IEnumerable<UretimEmri> GetSelectList()
		{
			return _uretimEmriRepository.GetList(t => t.Is.Id != 0,null,"");
		}

		public int Save()
		{
			return _uretimEmriRepository.Save();
		}

		public async Task<int> SaveAsync()
		{
			return await _uretimEmriRepository.SaveAsync();
		}

		public void Update(UretimEmri item)
		{
			_uretimEmriRepository.Update(item);
		}
	}
}
