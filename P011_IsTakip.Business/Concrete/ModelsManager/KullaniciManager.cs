using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.DataAccess.Abstract.IModelsRepository;
using P011_IsTakip.Entities.Classes;
using System.Linq.Expressions;

namespace P011_IsTakip.Business.Concrete.ModelsManager
{
    public class KullaniciManager : IKullaniciService
	{
		private readonly IKullaniciRepository _kullaniciRepository;

		public KullaniciManager(IKullaniciRepository kullaniciRepository)
		{
			_kullaniciRepository = kullaniciRepository;
		}

		public void Add(Kullanici item)
		{
			_kullaniciRepository.Add(item);
		}

		public async Task AddAsync(Kullanici item)
		{
			await _kullaniciRepository.AddAsync(item);
		}

		public bool Any(Expression<Func<Kullanici, bool>> filter)
		{
			return _kullaniciRepository.Any(filter);
		}

		public async Task<bool> AnyAsync(Expression<Func<Kullanici, bool>> filter)
		{
			return await _kullaniciRepository.AnyAsync(filter);
		}

		public int Count(Expression<Func<Kullanici, bool>> filter)
		{
			return _kullaniciRepository.Count(filter);
		}

		public async Task<int> CountAsync(Expression<Func<Kullanici, bool>> filter)
		{
			return await _kullaniciRepository.CountAsync(filter);
		}

		public void Delete(Kullanici item)
		{
			_kullaniciRepository.Delete(item);
		}

		public Kullanici Get(Expression<Func<Kullanici, bool>> filter, string includeProperties = "")
		{
			return _kullaniciRepository.Get(filter, includeProperties);
		}

		public async Task<Kullanici> GetAsync(Expression<Func<Kullanici, bool>> filter, string includeProperties = "")
		{
			return await _kullaniciRepository.GetAsync(filter, includeProperties);
		}

		public Kullanici GetById(int id)
		{
			return _kullaniciRepository.GetById(id);
		}

		public async Task<Kullanici> GetByIdAsync(int id)
		{
			return await _kullaniciRepository.GetByIdAsync(id);
		}
	
		public IEnumerable<Kullanici> GetList(Expression<Func<Kullanici, bool>> filter = null, Func<IQueryable<Kullanici>, IOrderedQueryable<Kullanici>> orderBy = null, string includeProperties = "")
		{
			return _kullaniciRepository.GetList(filter, orderBy, includeProperties);
		}

		public async Task<IEnumerable<Kullanici>> GetListAsync(Expression<Func<Kullanici, bool>> filter = null, Func<IQueryable<Kullanici>, IOrderedQueryable<Kullanici>> orderBy = null, string includeProperties = "")
		{
			return await _kullaniciRepository.GetListAsync(filter, orderBy, includeProperties);
		}

        public int Save()
		{
			return _kullaniciRepository.Save();
		}

		public async Task<int> SaveAsync()
		{
			return await _kullaniciRepository.SaveAsync();
		}

		public void Update(Kullanici item)
		{
			_kullaniciRepository.Update(item);
		}

		IEnumerable<Kullanici> IKullaniciService.GetSelectList()
		{
			return _kullaniciRepository.GetList(t => t.Musteri.Email != null,null,"");
		}
	}
}
