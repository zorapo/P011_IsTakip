using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P011_IsTakip.Entities.Classes;

namespace P011_IsTakip.DataAccess.Configurations
{
	public class KullaniciConfiguration : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.HasOne(k => k.Musteri)
                   .WithOne(m => m.Kullanici)
                   .HasForeignKey<Kullanici>(k => k.MusteriId);

            builder.HasKey(k => k.Id );
            builder.Property(k => k.Id).ValueGeneratedOnAdd();
        }
    }
}
