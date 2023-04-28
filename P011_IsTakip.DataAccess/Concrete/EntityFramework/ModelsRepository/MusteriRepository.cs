using P011_IsTakip.DataAccess.Abstract.IModelsRepository;
using P011_IsTakip.DataAccess.Concrete.EntityFramework.GenericRepository;
using P011_IsTakip.DataAccess.Context;
using P011_IsTakip.Entities.Classes;

namespace P011_IsTakip.DataAccess.Concrete.EntityFramework.ModelsRepository
{
	public class MusteriRepository : GenericRepository<Musteri>, IMusteriRepository
    {
		private readonly DataContext _db;

		public MusteriRepository(DataContext context) : base(context)
		{
            _db = context;
		}

	
    }
}
