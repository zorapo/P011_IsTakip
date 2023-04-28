using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_IsTakip.Entities.Classes
{
	public class Depo:BaseObject
	{
        public string Tanim { get; set; }

		[DataType(DataType.MultilineText)]
		public string? Aciklama { get; set; }
		
		public string Yetkili { get; set; }

		[DataType(DataType.PhoneNumber)]
		[DisplayName("Yetkili Telefon Numarası")]
		public string? YetkiliTelefon { get; set; }

        public ICollection<DepoEnvanter>? DepoEnvanterler { get; set; }

    }
}
