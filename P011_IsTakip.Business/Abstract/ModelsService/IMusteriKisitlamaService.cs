using P011_IsTakip.Business.Abstract.GenericService;
using P011_IsTakip.Entities.Classes;

namespace P011_IsTakip.Business.Abstract.ModelsService
{
	public interface IMusteriKisitlamaService : IGenericService<MusteriKisitlama>
    {
		IEnumerable<MusteriKisitlama> GetSelectList();
	}
}
