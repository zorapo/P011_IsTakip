using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.DataAccess.Abstract.IModelsRepository;
using P011_IsTakip.Entities.Classes;
using System.Linq.Expressions;

namespace P011_IsTakip.Business.Concrete.ModelsManager
{
	public class IsDosyaManager : IIsDosyaService
	{
		private readonly IIsDosyaRepository _isDosyaRepository;

		public IsDosyaManager(IIsDosyaRepository isDosyaRepository)
		{
			_isDosyaRepository = isDosyaRepository;
		}

		public void Add(IsDosya item)
		{
			_isDosyaRepository.Add(item);
		}

		public async Task AddAsync(IsDosya item)
		{
			await _isDosyaRepository.AddAsync(item);
		}

		public bool Any(Expression<Func<IsDosya, bool>> filter)
		{
			return _isDosyaRepository.Any(filter);
		}

		public async Task<bool> AnyAsync(Expression<Func<IsDosya, bool>> filter)
		{
			return await _isDosyaRepository.AnyAsync(filter);
		}

		public int Count(Expression<Func<IsDosya, bool>> filter)
		{
			return _isDosyaRepository.Count(filter);
		}

		public async Task<int> CountAsync(Expression<Func<IsDosya, bool>> filter)
		{
			return await _isDosyaRepository.CountAsync(filter);
		}

		public void Delete(IsDosya item)
		{
			_isDosyaRepository.Delete(item);
		}

		public IsDosya Get(Expression<Func<IsDosya, bool>> filter, string includeProperties = "")
		{
			return _isDosyaRepository.Get(filter, includeProperties);
		}

		public async Task<IsDosya> GetAsync(Expression<Func<IsDosya, bool>> filter, string includeProperties = "")
		{
			return await _isDosyaRepository.GetAsync(filter, includeProperties);
		}

		public IsDosya GetById(int id)
		{
			return _isDosyaRepository.GetById(id);
		}

		public async Task<IsDosya> GetByIdAsync(int id)
		{
			return await _isDosyaRepository.GetByIdAsync(id);
		}

		public IEnumerable<IsDosya> GetList(Expression<Func<IsDosya, bool>> filter = null, Func<IQueryable<IsDosya>, IOrderedQueryable<IsDosya>> orderBy = null, string includeProperties = "")
		{
			return _isDosyaRepository.GetList(filter, orderBy, includeProperties);
		}

		public async Task<IEnumerable<IsDosya>> GetListAsync(Expression<Func<IsDosya, bool>> filter = null, Func<IQueryable<IsDosya>, IOrderedQueryable<IsDosya>> orderBy = null, string includeProperties = "")
		{
			return await _isDosyaRepository.GetListAsync(filter, orderBy, includeProperties);
		}

		public IEnumerable<IsDosya> GetSelectList()
		{
			return _isDosyaRepository.GetList(t => t.Is.Id != 0, null, "");
		}

		public int Save()
		{
			return _isDosyaRepository.Save();
		}

		public async Task<int> SaveAsync()
		{
			return await _isDosyaRepository.SaveAsync();
		}

		public void Update(IsDosya item)
		{
			_isDosyaRepository.Update(item);
		}
	}
}
