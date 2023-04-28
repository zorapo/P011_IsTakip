using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace P011_IsTakip.Entities.Classes
{
	public class Musteri: BaseObject
	{
        public string Tanim { get; set; }

        public int MusteriSinifId { get; set; }

        public string Adres { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Telefon { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

		public string VergiDairesi { get; set; }

		public string VergiNumarasi { get; set; }

		[DataType(DataType.MultilineText)]
		public string Aciklama { get; set; }

        public MusteriSinif MusteriSinif { get; set; }

        public MusteriKisitlama MusteriKisitlama { get; set; }

        [JsonIgnore]
        public Kullanici? Kullanici { get; set; }

        public ICollection<MusteriTemsilcisi> MusteriTemsilciler { get; set; }

		public ICollection<Ajanda> Ajandalar { get; set; }

        [JsonIgnore]
		public ICollection<DepoEnvanter>? DepoEnvanterler { get; set; }

		public ICollection<Is> Isler { get; set; }



    }
}
