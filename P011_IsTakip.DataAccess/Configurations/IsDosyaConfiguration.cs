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
    public class IsDosyaConfiguration : IEntityTypeConfiguration<IsDosya>
    {
        public void Configure(EntityTypeBuilder<IsDosya> builder)
        {
            builder.HasOne(isd => isd.Is)
                   .WithOne(i => i.IsDosya)
                   .HasForeignKey<IsDosya>(isd => isd.IsId);
        }
    }
    
}
