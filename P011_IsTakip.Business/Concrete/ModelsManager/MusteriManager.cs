using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.DataAccess.Abstract.IModelsRepository;
using P011_IsTakip.Entities.Classes;
using System.Linq.Expressions;

namespace P011_IsTakip.Business.Concrete.ModelsManager
{
	public class MusteriManager : IMusteriService
	{
		private readonly IMusteriRepository _musteriRepository;

		public MusteriManager(IMusteriRepository musteriRepository)
		{
			_musteriRepository = musteriRepository;
		}

		public void Add(Musteri item)
		{
			_musteriRepository.Add(item);
		}

		public async Task AddAsync(Musteri item)
		{
			await _musteriRepository.AddAsync(item);
		}

		public bool Any(Expression<Func<Musteri, bool>> filter)
		{
			return _musteriRepository.Any(filter);
		}

		public async Task<bool> AnyAsync(Expression<Func<Musteri, bool>> filter)
		{
			return await _musteriRepository.AnyAsync(filter);
		}

		public int Count(Expression<Func<Musteri, bool>> filter)
		{
			return _musteriRepository.Count(filter);
		}

		public async Task<int> CountAsync(Expression<Func<Musteri, bool>> filter)
		{
			return await _musteriRepository.CountAsync(filter);
		}

		public void Delete(Musteri item)
		{
			_musteriRepository.Delete(item);
		}

		public Musteri Get(Expression<Func<Musteri, bool>> filter, string includeProperties = "")
		{
			return _musteriRepository.Get(filter, includeProperties);
		}

		public async Task<Musteri> GetAsync(Expression<Func<Musteri, bool>> filter, string includeProperties = "")
		{
			return await _musteriRepository.GetAsync(filter, includeProperties);
		}

		public Musteri GetById(int id)
		{
			return _musteriRepository.GetById(id);
		}

		public async Task<Musteri> GetByIdAsync(int id)
		{
			return await _musteriRepository.GetByIdAsync(id);
		}

		public IEnumerable<Musteri> GetList(Expression<Func<Musteri, bool>> filter = null, Func<IQueryable<Musteri>, IOrderedQueryable<Musteri>> orderBy = null, string includeProperties = "")
		{
			return _musteriRepository.GetList(filter, orderBy, includeProperties);
		}

		public async Task<IEnumerable<Musteri>> GetListAsync(Expression<Func<Musteri, bool>> filter = null, Func<IQueryable<Musteri>, IOrderedQueryable<Musteri>> orderBy = null, string includeProperties = "")
		{
			return await _musteriRepository.GetListAsync(filter, orderBy, includeProperties);
		}

		public IEnumerable<Musteri> GetSelectList()
		{
			return _musteriRepository.GetList(t => t.MusteriSinif.Id != 0,null,"");
		}

		public int Save()
		{
			return _musteriRepository.Save();
		}

		public async Task<int> SaveAsync()
		{
			return await _musteriRepository.SaveAsync();
		}

		public void Update(Musteri item)
		{
			_musteriRepository.Update(item);
		}
	}
}
