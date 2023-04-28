using P011_IsTakip.DataAccess.Abstract.IModelsRepository;
using P011_IsTakip.DataAccess.Concrete.EntityFramework.GenericRepository;
using P011_IsTakip.DataAccess.Context;
using P011_IsTakip.Entities.Classes;

namespace P011_IsTakip.DataAccess.Concrete.EntityFramework.ModelsRepository
{
	public class IsRepository : GenericRepository<Is>, IIsRepository
    {
		private readonly DataContext _db;
		public IsRepository(DataContext context) : base(context)
		{
            _db = context;
		}

    }
}
