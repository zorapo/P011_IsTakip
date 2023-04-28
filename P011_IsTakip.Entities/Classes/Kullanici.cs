using P011_IsTakip.Entities.Enums;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace P011_IsTakip.Entities.Classes
{
	public class Kullanici :BaseObject
	{
		[DisplayName("Kullanıcı Adı")]
		public string Ad { get; set; }

		[DisplayName("Kullanıcı Soyadı")]
		public string Soyad { get; set; }

        public int? MusteriId { get; set; }

		[DisplayName("Kullanıcı Kodu")]
		public string KullaniciKodu { get; set; }

		[DisplayName("Kullanıcı Şifre")]
		public string KullaniciSifre { get; set; }

        public bool MailBildirim { get; set; }

		[DisplayName("Rol Tanım")]
		public RoleTanim RolTanim { get; set; }

		[JsonIgnore]
        public Musteri? Musteri { get; set; }

    }
}
