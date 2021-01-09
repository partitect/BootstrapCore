using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DBFirstSpp.Models
{
	public class Category
	{
		public int ID { get; set; }

		[StringLength(100), Column(TypeName = "Varchar(100)"), Required(ErrorMessage = "Kategori Adı Boş Geçilemez"), Display(Name = "Kategori Adı")]
		public string Name { get; set; }

		public ICollection<Urunler> Uruns { get; set; }
	}
}
