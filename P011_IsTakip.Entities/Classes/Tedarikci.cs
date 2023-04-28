using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_IsTakip.Entities.Classes
{
	public class Tedarikci:BaseObject
	{
        public string Tanim { get; set; }

		[DataType(DataType.PhoneNumber)]
		public string Telefon { get; set; }

		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[DataType(DataType.MultilineText)]
		public string Aciklama { get; set; }
	}
}
