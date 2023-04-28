using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_IsTakip.Entities.Classes
{
	public class UretimDurus:BaseObject
	{
        public int UretimEmriId { get; set; }

        public int DurusSuresi { get; set; }

        public int DurusTipId { get; set; }


        public UretimEmri UretimEmri { get; set; }

        public DurusTip DurusTip { get; set; }
    }
}
