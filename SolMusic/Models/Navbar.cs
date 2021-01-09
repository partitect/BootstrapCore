using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolMusic.Models
{
	public class Navbar
	{
		public int Id { get; set; }
		public int type { get; set; }
		public string menu { get; set; }
		public string link { get; set; }
		public int? parentId { get; set; }
		public int orderIndex { get; set; }

	}
}
