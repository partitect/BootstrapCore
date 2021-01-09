using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DBFirstSpp.Models
{
	[Table("Uruns")]
	public class Urunler
	{
		public int ID { get; set; }

		[StringLength(100),Column(TypeName ="Varchar(100)"),Required(ErrorMessage ="Ürün Adı Boş Geçilemez"),Display(Name ="Ürün Adı")]
		public string Name { get; set; }

		[Column(TypeName = "decimal(18,3)"), Display(Name = "Ürün Fiyatı")]
		public decimal? Price { get; set; }

		public int DisplayIndex { get; set; }

		public int? CategoryID { get; set; }
		public Category Category { get; set; }
	}
}
