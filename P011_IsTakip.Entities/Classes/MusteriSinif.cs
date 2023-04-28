using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_IsTakip.Entities.Classes
{
	public class MusteriSinif:BaseObject
	{
        public string Tanim { get; set; }

		[DataType(DataType.MultilineText)]
		public string Aciklama { get; set; }

        public ICollection<Musteri> Musteriler { get; set; }
    }
}
