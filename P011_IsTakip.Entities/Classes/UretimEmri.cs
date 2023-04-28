using P011_IsTakip.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_IsTakip.Entities.Classes
{
	public class UretimEmri :BaseObject
	{
        public int IsId { get; set; }

        public DateTime IsEmriTarihi { get; set; }

        public int ToplamDurusSuresi { get; set; }

		public DateTime? UretimBaslamaTarihi { get; set; }

		public DateTime? UretimTamamlanmaTarihi { get; set; }

        public UretimDurum UretimDurum { get; set; }

        public Is Is { get; set; }

        public ICollection<UretimDurus> UretimDuruslari { get; set; }

    }
}
