using P011_IsTakip.Business.Abstract.GenericService;
using P011_IsTakip.Entities.Classes;

namespace P011_IsTakip.Business.Abstract.ModelsService
{
    public interface IKullaniciService : IGenericService<Kullanici>
    {
        IEnumerable<Kullanici> GetSelectList();


    }
}
