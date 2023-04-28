using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.DataAccess.Abstract.IModelsRepository;
using P011_IsTakip.Entities.Classes;
using System.Linq.Expressions;

namespace P011_IsTakip.Business.Concrete.ModelsManager
{
	public class MusteriKisitlamaManager : IMusteriKisitlamaService
	{
		private readonly IMusteriKisitlamaRepository _musteriKisitlamaRepository;

		public MusteriKisitlamaManager(IMusteriKisitlamaRepository musteriKisitlamaRepository)
		{
			_musteriKisitlamaRepository = musteriKisitlamaRepository;
		}

		public void Add(MusteriKisitlama item)
		{
			_musteriKisitlamaRepository.Add(item);
		}

		public async Task AddAsync(MusteriKisitlama item)
		{
			await _musteriKisitlamaRepository.AddAsync(item);
		}

		public bool Any(Expression<Func<MusteriKisitlama, bool>> filter)
		{
			return _musteriKisitlamaRepository.Any(filter);
		}

		public async Task<bool> AnyAsync(Expression<Func<MusteriKisitlama, bool>> filter)
		{
			return await _musteriKisitlamaRepository.AnyAsync(filter);
		}

		public int Count(Expression<Func<MusteriKisitlama, bool>> filter)
		{
			return _musteriKisitlamaRepository.Count(filter);
		}

		public async Task<int> CountAsync(Expression<Func<MusteriKisitlama, bool>> filter)
		{
			return await _musteriKisitlamaRepository.CountAsync(filter);
		}

		public void Delete(MusteriKisitlama item)
		{
			_musteriKisitlamaRepository.Delete(item);
		}

		public MusteriKisitlama Get(Expression<Func<MusteriKisitlama, bool>> filter, string includeProperties = "")
		{
			return _musteriKisitlamaRepository.Get(filter, includeProperties);
		}

		public async Task<MusteriKisitlama> GetAsync(Expression<Func<MusteriKisitlama, bool>> filter, string includeProperties = "")
		{
			return await _musteriKisitlamaRepository.GetAsync(filter, includeProperties);
		}

		public MusteriKisitlama GetById(int id)
		{
			return _musteriKisitlamaRepository.GetById(id);
		}

		public async Task<MusteriKisitlama> GetByIdAsync(int id)
		{
			return await _musteriKisitlamaRepository.GetByIdAsync(id);
		}

		public IEnumerable<MusteriKisitlama> GetList(Expression<Func<MusteriKisitlama, bool>> filter = null, Func<IQueryable<MusteriKisitlama>, IOrderedQueryable<MusteriKisitlama>> orderBy = null, string includeProperties = "")
		{
			return _musteriKisitlamaRepository.GetList(filter, orderBy, includeProperties);
		}

		public async Task<IEnumerable<MusteriKisitlama>> GetListAsync(Expression<Func<MusteriKisitlama, bool>> filter = null, Func<IQueryable<MusteriKisitlama>, IOrderedQueryable<MusteriKisitlama>> orderBy = null, string includeProperties = "")
		{
			return await _musteriKisitlamaRepository.GetListAsync(filter, orderBy, includeProperties);
		}

		public IEnumerable<MusteriKisitlama> GetSelectList()
		{
			return _musteriKisitlamaRepository.GetList(t => t.Musteri.Id != 0,null,"");
		}

		public int Save()
		{
			return _musteriKisitlamaRepository.Save();
		}

		public async Task<int> SaveAsync()
		{
			return await _musteriKisitlamaRepository.SaveAsync();
		}

		public void Update(MusteriKisitlama item)
		{
			_musteriKisitlamaRepository.Update(item);
		}
	}
}
