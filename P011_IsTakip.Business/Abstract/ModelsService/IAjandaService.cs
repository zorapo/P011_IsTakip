using P011_IsTakip.Business.Abstract.GenericService;
using P011_IsTakip.Entities.Classes;

namespace P011_IsTakip.Business.Abstract.ModelsService
{
	public interface IAjandaService : IGenericService<Ajanda>
    {
		IEnumerable<Ajanda> GetSelectList();
	}
}
