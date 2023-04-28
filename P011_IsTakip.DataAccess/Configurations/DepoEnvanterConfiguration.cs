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
    public class DepoEnvanterConfiguration : IEntityTypeConfiguration<DepoEnvanter>
    {
        public void Configure(EntityTypeBuilder<DepoEnvanter> builder)
        {
            builder.HasOne(de => de.Depo)
                   .WithMany(d => d.DepoEnvanterler)
                   .HasForeignKey(de => de.DepoId);

            builder.HasOne(de => de.DepoRaf)
                   .WithMany(dr => dr.DepoEnvanterler)
                   .HasForeignKey(de => de.DepoRafId);

            builder.HasOne(de => de.Kalinlik)
                   .WithMany(k => k.DepoEnvanterler)
                   .HasForeignKey(de => de.KalinlikId);

            builder.HasOne(de => de.MalzemeTip)
                   .WithMany(mt => mt.DepoEnvanterler)
                   .HasForeignKey(de => de.MalzemeTipId);

            builder.HasOne(de => de.Musteri)
                   .WithMany(k => k.DepoEnvanterler)
                   .HasForeignKey(de => de.MusteriId);
        }
    }
}
