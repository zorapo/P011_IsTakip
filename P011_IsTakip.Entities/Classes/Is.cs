using Microsoft.EntityFrameworkCore.Metadata;
using P011_IsTakip.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011_IsTakip.Entities.Classes
{
	public class Is:BaseObject
	{
        public int MusteriId { get; set; }

        public bool Teklifli { get; set; }

        public int TeklifNo { get; set; }
       
        public decimal Fiyat { get; set; }

        public bool IsBitimindeBildir { get; set; }

        public DateTime Termin { get; set; }

        public IsOnceligi IsOnceligi { get; set; }

        public int MusteriSiparisNo { get; set; }

        public string IsNotu { get; set; }

        public int MalzemeTipId { get; set; }

		public int KalinlikId { get; set; }

        public bool Iscilik { get; set; }

		[DataType(DataType.MultilineText)]
		public string MalzemeNotu { get; set; }

        public IsDosya IsDosya { get; set; }

        public Musteri Musteri { get; set; }

        public MalzemeTip MalzemeTip { get; set; }

        public Kalinlik Kalinlik { get; set; }

		public UretimEmri UretimEmri { get; set; }



	}
}
