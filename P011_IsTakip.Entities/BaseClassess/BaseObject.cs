using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P011_IsTakip.Entities.Classes
{
	public class BaseObject
	{
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Key]
        public int Id { get; set; }

        public string? OlusturanKullanici { get; set; }

		public int OlusturanKullaniciId { get; set; }

		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public DateTime OlusturmaTarihi { get; set; }=DateTime.Now;
	
		public string? GuncelleyenKullanici { get; set; }
	
		public int? GuncelleyenKullaniciId { get; set; }

		[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
		public DateTime? GuncellemeTarihi { get; set; } = DateTime.Now;
		
		public bool Aktif { get; set; }
	
		public bool Silindi { get; set; }

		[DisplayName("Durum(Aktif/Pasif)")]
		public string AktifString => Aktif ? "Aktif" : "Pasif";

		[DisplayName("Durum(Silindi)")]
		public string SilindiString => Silindi ? "Silinmiş" : "";




	}
}
