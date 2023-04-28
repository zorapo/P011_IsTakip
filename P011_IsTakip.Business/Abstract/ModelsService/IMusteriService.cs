using P011_IsTakip.Business.Abstract.GenericService;
using P011_IsTakip.Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_IsTakip.Business.Abstract.ModelsService
{
    public interface IMusteriService : IGenericService<Musteri>
    {
		IEnumerable<Musteri> GetSelectList();
	}
}
