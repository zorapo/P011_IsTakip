using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P011_IsTakip.Entities.Classes;

namespace P011_IsTakip.DataAccess.Seeds
{
    public class KullaniciDataSeed : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.HasData(new Kullanici { Id = 1, OlusturanKullanici="Ediz",OlusturanKullaniciId=1,Aktif=true,Silindi=false,Ad = "Ediz", Soyad = "Hun", KullaniciKodu = "Ediz", KullaniciSifre = "123" });
            builder.HasData(new Kullanici { Id = 2, OlusturanKullanici = "Kemal", OlusturanKullaniciId = 2, Aktif = true, Silindi = false, Ad = "Kemal", Soyad = "Sunal", KullaniciKodu = "Kemal", KullaniciSifre = "1234" });
            builder.HasData(new Kullanici { Id = 3, OlusturanKullanici = "Tarık", OlusturanKullaniciId = 3, Aktif = true, Silindi = false, Ad = "Tarık", Soyad = "Akan", KullaniciKodu = "Tarık", KullaniciSifre = "asd" });
            builder.HasData(new Kullanici { Id = 4, OlusturanKullanici = "Filiz", OlusturanKullaniciId = 4, Aktif = true, Silindi = false, Ad = "Filiz", Soyad = "Akın", KullaniciKodu = "Filiz", KullaniciSifre = "321" });
            builder.HasData(new Kullanici { Id = 5, OlusturanKullanici = "Türkan", OlusturanKullaniciId = 5, Aktif = true, Silindi = false, Ad = "Türkan", Soyad = "Şoray", KullaniciKodu = "Türkan", KullaniciSifre = "qwe" });

        }
    }
}
