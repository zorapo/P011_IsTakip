using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P011_IsTakip.Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace P011_IsTakip.DataAccess.Configurations
{
    public class IsConfiguration : IEntityTypeConfiguration<Is>
    {
        public void Configure(EntityTypeBuilder<Is> builder)
        {
            builder.HasOne(i => i.Musteri)
                   .WithMany(m => m.Isler)
                   .HasForeignKey(i => i.MusteriId);

            builder.HasOne(i => i.MalzemeTip)
                   .WithMany(m => m.Isler)
                   .HasForeignKey(i => i.MalzemeTipId);

            builder.HasOne(i => i.Kalinlik)
                   .WithMany(m => m.Isler)
                   .HasForeignKey(i => i.KalinlikId);

            builder.Property(t => t.Fiyat)
                   .HasColumnType("decimal(18,2)");

        }
    }
}
