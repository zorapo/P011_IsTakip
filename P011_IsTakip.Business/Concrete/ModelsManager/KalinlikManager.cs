using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.DataAccess.Abstract.IModelsRepository;
using P011_IsTakip.Entities.Classes;
using System.Linq.Expressions;

namespace P011_IsTakip.Business.Concrete.ModelsManager
{
	public class KalinlikManager :IKalinlikService
	{
		private readonly IKalinlikRepository _kalinlikRepository;

		public KalinlikManager(IKalinlikRepository kalinlikRepository)
		{
			_kalinlikRepository = kalinlikRepository;
		}

		public void Add(Kalinlik item)
		{
			_kalinlikRepository.Add(item);
		}

		public async Task AddAsync(Kalinlik item)
		{
			await _kalinlikRepository.AddAsync(item);
		}

		public bool Any(Expression<Func<Kalinlik, bool>> filter)
		{
			return _kalinlikRepository.Any(filter);
		}

		public async Task<bool> AnyAsync(Expression<Func<Kalinlik, bool>> filter)
		{
			return await _kalinlikRepository.AnyAsync(filter);
		}

		public int Count(Expression<Func<Kalinlik, bool>> filter)
		{
			return _kalinlikRepository.Count(filter);
		}

		public async Task<int> CountAsync(Expression<Func<Kalinlik, bool>> filter)
		{
			return await _kalinlikRepository.CountAsync(filter);
		}

		public void Delete(Kalinlik item)
		{
			_kalinlikRepository.Delete(item);
		}

		public Kalinlik Get(Expression<Func<Kalinlik, bool>> filter, string includeProperties = "")
		{
			return _kalinlikRepository.Get(filter, includeProperties);
		}

		public async Task<Kalinlik> GetAsync(Expression<Func<Kalinlik, bool>> filter, string includeProperties = "")
		{
			return await _kalinlikRepository.GetAsync(filter, includeProperties);
		}

		public Kalinlik GetById(int id)
		{
			return _kalinlikRepository.GetById(id);
		}

		public async Task<Kalinlik> GetByIdAsync(int id)
		{
			return await _kalinlikRepository.GetByIdAsync(id);
		}

		public IEnumerable<Kalinlik> GetList(Expression<Func<Kalinlik, bool>> filter = null, Func<IQueryable<Kalinlik>, IOrderedQueryable<Kalinlik>> orderBy = null, string includeProperties = "")
		{
			return _kalinlikRepository.GetList(filter, orderBy, includeProperties);
		}

		public async Task<IEnumerable<Kalinlik>> GetListAsync(Expression<Func<Kalinlik, bool>> filter = null, Func<IQueryable<Kalinlik>, IOrderedQueryable<Kalinlik>> orderBy = null, string includeProperties = "")
		{
			return await _kalinlikRepository.GetListAsync(filter, orderBy, includeProperties);
		}

		public int Save()
		{
			return _kalinlikRepository.Save();
		}

		public async Task<int> SaveAsync()
		{
			return await _kalinlikRepository.SaveAsync();
		}

		public void Update(Kalinlik item)
		{
			_kalinlikRepository.Update(item);
		}
	}
}
