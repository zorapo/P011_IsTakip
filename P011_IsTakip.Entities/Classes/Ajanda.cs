using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_IsTakip.Entities.Classes
{
	public class Ajanda: BaseObject
	{
        public int MusteriId { get; set; }

		[DataType(DataType.MultilineText)]
		public string Aciklama { get; set; }

        public DateTime NotTarihi { get; set; }

		public Musteri Musteri { get; set; }

	}
}
