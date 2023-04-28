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
    public class UretimEmriConfiguration : IEntityTypeConfiguration<UretimEmri>
    {
        public void Configure(EntityTypeBuilder<UretimEmri> builder)
        {
            builder.HasOne(ue => ue.Is)
                   .WithOne(i => i.UretimEmri)
                   .HasForeignKey<UretimEmri>(ue => ue.IsId);

        }
    }
}
