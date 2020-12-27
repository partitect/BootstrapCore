using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootstrapCore.Models
{
	public class News
	{
		public int id { get; set; }
		public string title { get; set; }
		public string desc { get; set; }
		public DateTime date { get; set; }
		public string imgPath { get; set; }

	}
}
