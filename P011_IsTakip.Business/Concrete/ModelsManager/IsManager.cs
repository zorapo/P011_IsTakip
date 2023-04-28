using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.DataAccess.Abstract.IModelsRepository;
using P011_IsTakip.Entities.Classes;
using System.Linq.Expressions;

namespace P011_IsTakip.Business.Concrete.ModelsManager
{
	public class IsManager : IIsService
	{
		private readonly IIsRepository _isRepository;

		public IsManager(IIsRepository isRepository)
		{
			_isRepository = isRepository;
		}

		public void Add(Is item)
		{
			_isRepository.Add(item);
		}

		public async Task AddAsync(Is item)
		{
			await _isRepository.AddAsync(item);
		}

		public bool Any(Expression<Func<Is, bool>> filter)
		{
			return _isRepository.Any(filter);
		}

		public async Task<bool> AnyAsync(Expression<Func<Is, bool>> filter)
		{
			return await _isRepository.AnyAsync(filter);
		}

		public int Count(Expression<Func<Is, bool>> filter)
		{
			return _isRepository.Count(filter);
		}

		public async Task<int> CountAsync(Expression<Func<Is, bool>> filter)
		{
			return await _isRepository.CountAsync(filter);
		}

		public void Delete(Is item)
		{
			_isRepository.Delete(item);
		}

		public Is Get(Expression<Func<Is, bool>> filter, string includeProperties = "")
		{
			return _isRepository.Get(filter, includeProperties);
		}

		public async Task<Is> GetAsync(Expression<Func<Is, bool>> filter, string includeProperties = "")
		{
			return await _isRepository.GetAsync(filter, includeProperties);
		}

		public Is GetById(int id)
		{
			return _isRepository.GetById(id);
		}

		public async Task<Is> GetByIdAsync(int id)
		{
			return await _isRepository.GetByIdAsync(id);
		}

		public IEnumerable<Is> GetList(Expression<Func<Is, bool>> filter = null, Func<IQueryable<Is>, IOrderedQueryable<Is>> orderBy = null, string includeProperties = "")
		{
			return _isRepository.GetList(filter, orderBy, includeProperties);
		}

		public async Task<IEnumerable<Is>> GetListAsync(Expression<Func<Is, bool>> filter = null, Func<IQueryable<Is>, IOrderedQueryable<Is>> orderBy = null, string includeProperties = "")
		{
			return await _isRepository.GetListAsync(filter, orderBy, includeProperties);
		}

		public IEnumerable<Is> GetSelectKalinlikId()
		{
			return _isRepository.GetList(t => t.Kalinlik.Id != 0, null, "");
		}

		public IEnumerable<Is> GetSelectMalzemeTipId()
		{
			return _isRepository.GetList(t => t.MalzemeTip.Id != 0, null, "");
		}

		public IEnumerable<Is> GetSelectMusteriId()
		{
			return _isRepository.GetList(t => t.Musteri.Id != 0, null, "");
		}

		public int Save()
		{
			return _isRepository.Save();
		}

		public async Task<int> SaveAsync()
		{
			return await _isRepository.SaveAsync();
		}

		public void Update(Is item)
		{
			_isRepository.Update(item);
		}	

	}
}
