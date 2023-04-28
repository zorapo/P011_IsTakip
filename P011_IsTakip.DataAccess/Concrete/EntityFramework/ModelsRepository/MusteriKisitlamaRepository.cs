using P011_IsTakip.DataAccess.Abstract.IModelsRepository;
using P011_IsTakip.DataAccess.Concrete.EntityFramework.GenericRepository;
using P011_IsTakip.DataAccess.Context;
using P011_IsTakip.Entities.Classes;

namespace P011_IsTakip.DataAccess.Concrete.EntityFramework.ModelsRepository
{
	public class MusteriKisitlamaRepository : GenericRepository<MusteriKisitlama>, IMusteriKisitlamaRepository
    {
		private readonly DataContext _db;

		public MusteriKisitlamaRepository(DataContext context) : base(context)
		{
            _db = context;
		}
	
    }
}
