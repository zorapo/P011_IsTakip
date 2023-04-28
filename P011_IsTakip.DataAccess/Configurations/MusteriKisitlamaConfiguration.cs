using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P011_IsTakip.Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_IsTakip.DataAccess.Configurations
{
    public class MusteriKisitlamaConfiguration : IEntityTypeConfiguration<MusteriKisitlama>
    {
        public void Configure(EntityTypeBuilder<MusteriKisitlama> builder)
        {
               builder.HasOne(m => m.Musteri)
                      .WithOne(mk => mk.MusteriKisitlama)
                      .HasForeignKey<MusteriKisitlama>(mk => mk.MusteriId);
        }
    }
}
