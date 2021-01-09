using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SolMusic.Models
{
	public class Slider
	{
		public int Id { get; set; }

		[Column(TypeName = "Varchar(100)")]
		public string title { get; set; }

		[Column(TypeName = "Varchar(500)")]
		public string desc { get; set; }

		[Column(TypeName = "Varchar(50)")]
		public string btnTitle1 { get; set; }

		[Column(TypeName = "Varchar(300)")]
		public string btnLink1 { get; set; }

		[Column(TypeName = "Varchar(50)")]
		public string btnTitle2 { get; set; }

		[Column(TypeName = "Varchar(300)")]
		public string btnLink2 { get; set; }

		[Column(TypeName = "Varchar(500)")]
		public string imagePath { get; set; }

		public int orderIndex { get; set; }
	}
}
