using P011_IsTakip.DataAccess.Abstract.IModelsRepository;
using P011_IsTakip.DataAccess.Concrete.EntityFramework.GenericRepository;
using P011_IsTakip.DataAccess.Context;
using P011_IsTakip.Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_IsTakip.DataAccess.Concrete.EntityFramework.ModelsRepository
{
    public class UretimEmriRepository : GenericRepository<UretimEmri>, IUretimEmriRepository
    {
		private readonly DataContext _db;

		public UretimEmriRepository(DataContext context) : base(context)
		{
            _db = context;
		}

    }
}
