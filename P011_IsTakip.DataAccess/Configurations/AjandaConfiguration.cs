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
    public class AjandaConfiguration : IEntityTypeConfiguration<Ajanda>
    {
        public void Configure(EntityTypeBuilder<Ajanda> builder)
        {
                builder.HasOne(m => m.Musteri)
                       .WithMany(a => a.Ajandalar)
                       .HasForeignKey(m => m.MusteriId);
        }
    }
}
