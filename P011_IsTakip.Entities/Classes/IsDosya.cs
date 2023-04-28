using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_IsTakip.Entities.Classes
{
	public class IsDosya:BaseObject
	{
        public int IsId { get; set; }

        public string DosyaAdi { get; set; }

        public Is Is { get; set; }
    }
}
