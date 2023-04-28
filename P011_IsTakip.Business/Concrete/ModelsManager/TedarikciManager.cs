using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.DataAccess.Abstract.IModelsRepository;
using P011_IsTakip.Entities.Classes;
using System.Linq.Expressions;

namespace P011_IsTakip.Business.Concrete.ModelsManager
{
	public class TedarikciManager : ITedarikciService
	{
		private readonly ITedarikciRepository _tedarikciRepository;

		public TedarikciManager(ITedarikciRepository tedarikciRepository)
		{
			_tedarikciRepository = tedarikciRepository;
		}

		public void Add(Tedarikci item)
		{
			_tedarikciRepository.Add(item);
		}

		public async Task AddAsync(Tedarikci item)
		{
			await _tedarikciRepository.AddAsync(item);
		}

		public bool Any(Expression<Func<Tedarikci, bool>> filter)
		{
			return _tedarikciRepository.Any(filter);
		}

		public async Task<bool> AnyAsync(Expression<Func<Tedarikci, bool>> filter)
		{
			return await _tedarikciRepository.AnyAsync(filter);
		}

		public int Count(Expression<Func<Tedarikci, bool>> filter)
		{
			return _tedarikciRepository.Count(filter);
		}

		public async Task<int> CountAsync(Expression<Func<Tedarikci, bool>> filter)
		{
			return await _tedarikciRepository.CountAsync(filter);
		}

		public void Delete(Tedarikci item)
		{
			_tedarikciRepository.Delete(item);
		}

		public Tedarikci Get(Expression<Func<Tedarikci, bool>> filter, string includeProperties = "")
		{
			return _tedarikciRepository.Get(filter, includeProperties);
		}

		public async Task<Tedarikci> GetAsync(Expression<Func<Tedarikci, bool>> filter, string includeProperties = "")
		{
			return await _tedarikciRepository.GetAsync(filter, includeProperties);
		}

		public Tedarikci GetById(int id)
		{
			return _tedarikciRepository.GetById(id);
		}

		public async Task<Tedarikci> GetByIdAsync(int id)
		{
			return await _tedarikciRepository.GetByIdAsync(id);
		}

		public IEnumerable<Tedarikci> GetList(Expression<Func<Tedarikci, bool>> filter = null, Func<IQueryable<Tedarikci>, IOrderedQueryable<Tedarikci>> orderBy = null, string includeProperties = "")
		{
			return _tedarikciRepository.GetList(filter, orderBy, includeProperties);
		}

		public async Task<IEnumerable<Tedarikci>> GetListAsync(Expression<Func<Tedarikci, bool>> filter = null, Func<IQueryable<Tedarikci>, IOrderedQueryable<Tedarikci>> orderBy = null, string includeProperties = "")
		{
			return await _tedarikciRepository.GetListAsync(filter, orderBy, includeProperties);
		}

		public int Save()
		{
			return _tedarikciRepository.Save();
		}

		public async Task<int> SaveAsync()
		{
			return await _tedarikciRepository.SaveAsync();
		}

		public void Update(Tedarikci item)
		{
			_tedarikciRepository.Update(item);
		}
	}
}
