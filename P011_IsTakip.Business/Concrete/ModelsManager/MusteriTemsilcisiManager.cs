using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.DataAccess.Abstract.IModelsRepository;
using P011_IsTakip.Entities.Classes;
using System.Linq.Expressions;

namespace P011_IsTakip.Business.Concrete.ModelsManager
{
	public class MusteriTemsilcisiManager : IMusteriTemsilcisiService
	{
		private readonly IMusteriTemsilcisiRepository _musteriTemsilcisiRepository;

		public MusteriTemsilcisiManager(IMusteriTemsilcisiRepository musteriTemsilcisiRepository)
		{
			_musteriTemsilcisiRepository = musteriTemsilcisiRepository;
		}

		public void Add(MusteriTemsilcisi item)
		{
			_musteriTemsilcisiRepository.Add(item);
		}

		public async Task AddAsync(MusteriTemsilcisi item)
		{
			await _musteriTemsilcisiRepository.AddAsync(item);
		}

		public bool Any(Expression<Func<MusteriTemsilcisi, bool>> filter)
		{
			return _musteriTemsilcisiRepository.Any(filter);
		}

		public async Task<bool> AnyAsync(Expression<Func<MusteriTemsilcisi, bool>> filter)
		{
			return await _musteriTemsilcisiRepository.AnyAsync(filter);
		}

		public int Count(Expression<Func<MusteriTemsilcisi, bool>> filter)
		{
			return _musteriTemsilcisiRepository.Count(filter);
		}

		public async Task<int> CountAsync(Expression<Func<MusteriTemsilcisi, bool>> filter)
		{
			return await _musteriTemsilcisiRepository.CountAsync(filter);
		}

		public void Delete(MusteriTemsilcisi item)
		{
			_musteriTemsilcisiRepository.Delete(item);
		}

		public MusteriTemsilcisi Get(Expression<Func<MusteriTemsilcisi, bool>> filter, string includeProperties = "")
		{
			return _musteriTemsilcisiRepository.Get(filter, includeProperties);
		}

		public async Task<MusteriTemsilcisi> GetAsync(Expression<Func<MusteriTemsilcisi, bool>> filter, string includeProperties = "")
		{
			return await _musteriTemsilcisiRepository.GetAsync(filter, includeProperties);
		}

		public MusteriTemsilcisi GetById(int id)
		{
			return _musteriTemsilcisiRepository.GetById(id);
		}

		public async Task<MusteriTemsilcisi> GetByIdAsync(int id)
		{
			return await _musteriTemsilcisiRepository.GetByIdAsync(id);
		}

		public IEnumerable<MusteriTemsilcisi> GetList(Expression<Func<MusteriTemsilcisi, bool>> filter = null, Func<IQueryable<MusteriTemsilcisi>, IOrderedQueryable<MusteriTemsilcisi>> orderBy = null, string includeProperties = "")
		{
			return _musteriTemsilcisiRepository.GetList(filter, orderBy, includeProperties);
		}

		public async Task<IEnumerable<MusteriTemsilcisi>> GetListAsync(Expression<Func<MusteriTemsilcisi, bool>> filter = null, Func<IQueryable<MusteriTemsilcisi>, IOrderedQueryable<MusteriTemsilcisi>> orderBy = null, string includeProperties = "")
		{
			return await _musteriTemsilcisiRepository.GetListAsync(filter, orderBy, includeProperties);
		}

		public IEnumerable<MusteriTemsilcisi> GetSelectList()
		{
			return _musteriTemsilcisiRepository.GetList(t => t.Musteri.Id != 0, null, "");
		}

		public int Save()
		{
			return _musteriTemsilcisiRepository.Save();
		}

		public async Task<int> SaveAsync()
		{
			return await _musteriTemsilcisiRepository.SaveAsync();
		}

		public void Update(MusteriTemsilcisi item)
		{
			_musteriTemsilcisiRepository.Update(item);
		}
	}
}
