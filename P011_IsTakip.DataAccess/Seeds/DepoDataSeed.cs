using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using P011_IsTakip.Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_IsTakip.DataAccess.Seeds
{ 
        public class DepoDataSeed : IEntityTypeConfiguration<Depo>
        {
            public void Configure(EntityTypeBuilder<Depo> builder)
            {
                builder.HasData(new Depo { Id = 1, OlusturanKullanici = "Ediz", OlusturanKullaniciId = 1, Aktif = true, Silindi = false, Tanim = "Depo1", Yetkili = "Ahmet Taş" });
                builder.HasData(new Depo { Id = 2, OlusturanKullanici = "Kemal", OlusturanKullaniciId = 2, Aktif = true, Silindi = false, Tanim = "Depo2", Yetkili = "Murat Can" });
                builder.HasData(new Depo { Id = 3, OlusturanKullanici = "Tarık", OlusturanKullaniciId = 3, Aktif = true, Silindi = false, Tanim = "Depo3", Yetkili = "Mehmet Tok" });
                builder.HasData(new Depo { Id = 4, OlusturanKullanici = "Filiz", OlusturanKullaniciId = 4, Aktif = true, Silindi = false, Tanim = "Depo4", Yetkili = "Cem Dönmez" });


            }
        }
    
}
