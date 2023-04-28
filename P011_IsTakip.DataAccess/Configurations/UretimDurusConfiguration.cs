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
    public class UretimDurusConfiguration : IEntityTypeConfiguration<UretimDurus>
    {
        public void Configure(EntityTypeBuilder<UretimDurus> builder)
        {
            builder.HasOne(ud => ud.UretimEmri)
                   .WithMany(ue => ue.UretimDuruslari)
                   .HasForeignKey(ud => ud.UretimEmriId);

            builder.HasOne(ud => ud.DurusTip)
                   .WithMany(dt => dt.UretimDuruslari)
                   .HasForeignKey(ud => ud.DurusTipId);

        }
    }
}
