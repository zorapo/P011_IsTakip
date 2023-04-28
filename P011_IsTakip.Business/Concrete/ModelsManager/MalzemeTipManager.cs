using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.DataAccess.Abstract.IModelsRepository;
using P011_IsTakip.Entities.Classes;
using System.Linq.Expressions;

namespace P011_IsTakip.Business.Concrete.ModelsManager
{
	public class MalzemeTipManager : IMalzemeTipService
	{
		private readonly IMalzemeTipRepository _malzemeTipRepository;

		public MalzemeTipManager(IMalzemeTipRepository malzemeTipRepository)
		{
			_malzemeTipRepository = malzemeTipRepository;
		}

		public void Add(MalzemeTip item)
		{
			_malzemeTipRepository.Add(item);
		}

		public async Task AddAsync(MalzemeTip item)
		{
			await _malzemeTipRepository.AddAsync(item);
		}

		public bool Any(Expression<Func<MalzemeTip, bool>> filter)
		{
			return _malzemeTipRepository.Any(filter);
		}

		public async Task<bool> AnyAsync(Expression<Func<MalzemeTip, bool>> filter)
		{
			return await _malzemeTipRepository.AnyAsync(filter);
		}

		public int Count(Expression<Func<MalzemeTip, bool>> filter)
		{
			return _malzemeTipRepository.Count(filter);
		}

		public async Task<int> CountAsync(Expression<Func<MalzemeTip, bool>> filter)
		{
			return await _malzemeTipRepository.CountAsync(filter);
		}

		public void Delete(MalzemeTip item)
		{
			_malzemeTipRepository.Delete(item);
		}

		public MalzemeTip Get(Expression<Func<MalzemeTip, bool>> filter, string includeProperties = "")
		{
			return _malzemeTipRepository.Get(filter, includeProperties);
		}

		public async Task<MalzemeTip> GetAsync(Expression<Func<MalzemeTip, bool>> filter, string includeProperties = "")
		{
			return await _malzemeTipRepository.GetAsync(filter, includeProperties);
		}

		public MalzemeTip GetById(int id)
		{
			return _malzemeTipRepository.GetById(id);
		}

		public async Task<MalzemeTip> GetByIdAsync(int id)
		{
			return await _malzemeTipRepository.GetByIdAsync(id);
		}

		public IEnumerable<MalzemeTip> GetList(Expression<Func<MalzemeTip, bool>> filter = null, Func<IQueryable<MalzemeTip>, IOrderedQueryable<MalzemeTip>> orderBy = null, string includeProperties = "")
		{
			return _malzemeTipRepository.GetList(filter, orderBy, includeProperties);
		}

		public async Task<IEnumerable<MalzemeTip>> GetListAsync(Expression<Func<MalzemeTip, bool>> filter = null, Func<IQueryable<MalzemeTip>, IOrderedQueryable<MalzemeTip>> orderBy = null, string includeProperties = "")
		{
			return await _malzemeTipRepository.GetListAsync(filter, orderBy, includeProperties);
		}

		public int Save()
		{
			return _malzemeTipRepository.Save();
		}

		public async Task<int> SaveAsync()
		{
			return await _malzemeTipRepository.SaveAsync();
		}

		public void Update(MalzemeTip item)
		{
			_malzemeTipRepository.Update(item);
		}
	}
}
