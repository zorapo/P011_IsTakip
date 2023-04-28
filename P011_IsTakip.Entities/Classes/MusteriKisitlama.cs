using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_IsTakip.Entities.Classes
{
	public class MusteriKisitlama: BaseObject
	{
		[DataType(DataType.MultilineText)]
		public string IslemAciklama { get; set; }

        public bool Kisitlama { get; set; }

        public int MusteriId { get; set; }

        public Musteri Musteri { get; set; }
    }
}
