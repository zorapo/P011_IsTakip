using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_IsTakip.Entities.Classes
{
	public class MusteriTemsilcisi: BaseObject
	{
        public int MusteriId { get; set; }

        public string Ad { get; set; }

		public string Soyad { get; set; }

		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[DataType(DataType.PhoneNumber)]
		public string TelefonNumarasi { get; set; }

		public Musteri Musteri { get; set; }

	}
}
