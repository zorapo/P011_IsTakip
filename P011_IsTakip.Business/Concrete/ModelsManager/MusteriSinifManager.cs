using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.DataAccess.Abstract.IModelsRepository;
using P011_IsTakip.Entities.Classes;
using System.Linq.Expressions;

namespace P011_IsTakip.Business.Concrete.ModelsManager
{
	public class MusteriSinifManager : IMusteriSinifService
	{
		private readonly IMusteriSinifRepository _musteriSinifRepository;

		public MusteriSinifManager(IMusteriSinifRepository musteriSinifRepository)
		{
			_musteriSinifRepository = musteriSinifRepository;
		}

		public void Add(MusteriSinif item)
		{
			_musteriSinifRepository.Add(item);
		}

		public async Task AddAsync(MusteriSinif item)
		{
			await _musteriSinifRepository.AddAsync(item);
		}

		public bool Any(Expression<Func<MusteriSinif, bool>> filter)
		{
			return _musteriSinifRepository.Any(filter);
		}

		public async Task<bool> AnyAsync(Expression<Func<MusteriSinif, bool>> filter)
		{
			return await _musteriSinifRepository.AnyAsync(filter);
		}

		public int Count(Expression<Func<MusteriSinif, bool>> filter)
		{
			return _musteriSinifRepository.Count(filter);
		}

		public async Task<int> CountAsync(Expression<Func<MusteriSinif, bool>> filter)
		{
			return await _musteriSinifRepository.CountAsync(filter);
		}

		public void Delete(MusteriSinif item)
		{
			_musteriSinifRepository.Delete(item);
		}

		public MusteriSinif Get(Expression<Func<MusteriSinif, bool>> filter, string includeProperties = "")
		{
			return _musteriSinifRepository.Get(filter, includeProperties);
		}

		public async Task<MusteriSinif> GetAsync(Expression<Func<MusteriSinif, bool>> filter, string includeProperties = "")
		{
			return await _musteriSinifRepository.GetAsync(filter, includeProperties);
		}

		public MusteriSinif GetById(int id)
		{
			return _musteriSinifRepository.GetById(id);
		}

		public async Task<MusteriSinif> GetByIdAsync(int id)
		{
			return await _musteriSinifRepository.GetByIdAsync(id);
		}

		public IEnumerable<MusteriSinif> GetList(Expression<Func<MusteriSinif, bool>> filter = null, Func<IQueryable<MusteriSinif>, IOrderedQueryable<MusteriSinif>> orderBy = null, string includeProperties = "")
		{
			return _musteriSinifRepository.GetList(filter, orderBy, includeProperties);
		}

		public async Task<IEnumerable<MusteriSinif>> GetListAsync(Expression<Func<MusteriSinif, bool>> filter = null, Func<IQueryable<MusteriSinif>, IOrderedQueryable<MusteriSinif>> orderBy = null, string includeProperties = "")
		{
			return await _musteriSinifRepository.GetListAsync(filter, orderBy, includeProperties);
		}

		public int Save()
		{
			return _musteriSinifRepository.Save();
		}

		public async Task<int> SaveAsync()
		{
			return await _musteriSinifRepository.SaveAsync();
		}

		public void Update(MusteriSinif item)
		{
			_musteriSinifRepository.Update(item);
		}
	}
}
