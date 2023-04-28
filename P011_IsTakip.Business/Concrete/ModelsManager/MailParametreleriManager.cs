using P011_IsTakip.Business.Abstract.ModelsService;
using P011_IsTakip.DataAccess.Abstract.IModelsRepository;
using P011_IsTakip.Entities.Classes;
using System.Linq.Expressions;

namespace P011_IsTakip.Business.Concrete.ModelsManager
{
	public class MailParametreleriManager : IMailParametreleriService
	{
		private readonly IMailParametreleriRepository _mailParametreleriRepository;

		public MailParametreleriManager(IMailParametreleriRepository mailParametreleriRepository)
		{
			_mailParametreleriRepository = mailParametreleriRepository;
		}

		public void Add(MailParametreleri item)
		{
			_mailParametreleriRepository.Add(item);
		}

		public async Task AddAsync(MailParametreleri item)
		{
			await _mailParametreleriRepository.AddAsync(item);
		}

		public bool Any(Expression<Func<MailParametreleri, bool>> filter)
		{
			return _mailParametreleriRepository.Any(filter);
		}

		public async Task<bool> AnyAsync(Expression<Func<MailParametreleri, bool>> filter)
		{
			return await _mailParametreleriRepository.AnyAsync(filter);
		}

		public int Count(Expression<Func<MailParametreleri, bool>> filter)
		{
			return _mailParametreleriRepository.Count(filter);
		}

		public async Task<int> CountAsync(Expression<Func<MailParametreleri, bool>> filter)
		{
			return await _mailParametreleriRepository.CountAsync(filter);
		}

		public void Delete(MailParametreleri item)
		{
			_mailParametreleriRepository.Delete(item);
		}

		public MailParametreleri Get(Expression<Func<MailParametreleri, bool>> filter, string includeProperties = "")
		{
			return _mailParametreleriRepository.Get(filter, includeProperties);
		}

		public async Task<MailParametreleri> GetAsync(Expression<Func<MailParametreleri, bool>> filter, string includeProperties = "")
		{
			return await _mailParametreleriRepository.GetAsync(filter, includeProperties);
		}

		public MailParametreleri GetById(int id)
		{
			return _mailParametreleriRepository.GetById(id);
		}

		public async Task<MailParametreleri> GetByIdAsync(int id)
		{
			return await _mailParametreleriRepository.GetByIdAsync(id);
		}

		public IEnumerable<MailParametreleri> GetList(Expression<Func<MailParametreleri, bool>> filter = null, Func<IQueryable<MailParametreleri>, IOrderedQueryable<MailParametreleri>> orderBy = null, string includeProperties = "")
		{
			return _mailParametreleriRepository.GetList(filter, orderBy, includeProperties);
		}

		public async Task<IEnumerable<MailParametreleri>> GetListAsync(Expression<Func<MailParametreleri, bool>> filter = null, Func<IQueryable<MailParametreleri>, IOrderedQueryable<MailParametreleri>> orderBy = null, string includeProperties = "")
		{
			return await _mailParametreleriRepository.GetListAsync(filter, orderBy, includeProperties);
		}

		public int Save()
		{
			return _mailParametreleriRepository.Save();
		}

		public async Task<int> SaveAsync()
		{
			return await _mailParametreleriRepository.SaveAsync();
		}

		public void Update(MailParametreleri item)
		{
			_mailParametreleriRepository.Update(item);
		}
	}
}
