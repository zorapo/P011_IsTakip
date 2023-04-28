using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.DataAccess.Abstract.IModelsRepository;
using P011_IsTakip.Entities.Classes;
using System.Linq.Expressions;

namespace P011_IsTakip.Business.Concrete.ModelsManager
{
	public class AjandaManager : IAjandaService
	{

		private readonly IAjandaRepository _ajandaRepository;

		public AjandaManager(IAjandaRepository ajandaRepository)
		{
			_ajandaRepository = ajandaRepository;
		}

		public void Add(Ajanda item)
		{
			_ajandaRepository.Add(item);
		}

		public async Task AddAsync(Ajanda item)
		{
			await _ajandaRepository.AddAsync(item);
		}

		public bool Any(Expression<Func<Ajanda, bool>> filter)
		{
			return _ajandaRepository.Any(filter);
		}

		public async Task<bool> AnyAsync(Expression<Func<Ajanda, bool>> filter)
		{
			return await _ajandaRepository.AnyAsync(filter);
		}

		public int Count(Expression<Func<Ajanda, bool>> filter)
		{
			return _ajandaRepository.Count(filter);
		}

		public async Task<int> CountAsync(Expression<Func<Ajanda, bool>> filter)
		{
			return await _ajandaRepository.CountAsync(filter);
		}

		public void Delete(Ajanda item)
		{
			_ajandaRepository.Delete(item);
		}

		public Ajanda Get(Expression<Func<Ajanda, bool>> filter, string includeProperties = "")
		{
			return _ajandaRepository.Get(filter, includeProperties);
		}

		public async Task<Ajanda> GetAsync(Expression<Func<Ajanda, bool>> filter, string includeProperties = "")
		{
			return await _ajandaRepository.GetAsync(filter, includeProperties);
		}

		public Ajanda GetById(int id)
		{
			return _ajandaRepository.GetById(id);
		}

		public async Task<Ajanda> GetByIdAsync(int id)
		{
			return await _ajandaRepository.GetByIdAsync(id);
		}

		public IEnumerable<Ajanda> GetList(Expression<Func<Ajanda, bool>> filter = null, Func<IQueryable<Ajanda>, IOrderedQueryable<Ajanda>> orderBy = null, string includeProperties = "")
		{
			return _ajandaRepository.GetList(filter, orderBy, includeProperties);
		}

		public async Task<IEnumerable<Ajanda>> GetListAsync(Expression<Func<Ajanda, bool>> filter = null, Func<IQueryable<Ajanda>, IOrderedQueryable<Ajanda>> orderBy = null, string includeProperties = "")
		{
			return await _ajandaRepository.GetListAsync(filter, orderBy, includeProperties);
		}

		public IEnumerable<Ajanda> GetSelectList()
		{
			return _ajandaRepository.GetList(t => t.Musteri.Id != 0, null, "");	
		}

		public int Save()
		{
			return _ajandaRepository.Save();
		}

		public async Task<int> SaveAsync()
		{
			return await _ajandaRepository.SaveAsync();
		}

		public void Update(Ajanda item)
		{
			_ajandaRepository.Update(item);
		}

	
	}
}
