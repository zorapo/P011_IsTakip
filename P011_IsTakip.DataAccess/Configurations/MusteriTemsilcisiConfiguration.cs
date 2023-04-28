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
    public class MusteriTemsilcisiConfiguration : IEntityTypeConfiguration<MusteriTemsilcisi>
    {
        public void Configure(EntityTypeBuilder<MusteriTemsilcisi> builder)
        {
            
                 builder.HasOne(m => m.Musteri)
                        .WithMany(mt => mt.MusteriTemsilciler)
                        .HasForeignKey(m => m.MusteriId);
        }
    }
}
