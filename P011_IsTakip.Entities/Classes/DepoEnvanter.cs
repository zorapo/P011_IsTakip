using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace P011_IsTakip.Entities.Classes
{
	public class DepoEnvanter:BaseObject
	{
        public int DepoId { get; set; }

		public int DepoRafId { get; set; }

		public int MalzemeTipId { get; set; }

		public int KalinlikId { get; set; }

        public float En { get; set; }

		public float Boy { get; set; }

		public int Adet { get; set; }

        public float Agirlik { get; set; }

		[DataType(DataType.MultilineText)]
		public string Aciklama { get; set; }

        public int? MusteriId { get; set; }

        public Depo Depo { get; set; }

        public DepoRaf DepoRaf { get; set; }

        public MalzemeTip MalzemeTip { get; set; }

        public Kalinlik Kalinlik { get; set; }

        [JsonIgnore]
        public Musteri? Musteri { get; set; }


    }
}
