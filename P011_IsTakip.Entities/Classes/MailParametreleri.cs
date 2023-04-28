using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_IsTakip.Entities.Classes
{
	public class MailParametreleri:BaseObject
	{
        public string SenderName { get; set; }

		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[DataType(DataType.Password)]
		public string Password { get; set; }

		public string SmtpAdres { get; set; }

		public string Port { get; set; }

		public string SSLKullan { get; set; }

	}
}
