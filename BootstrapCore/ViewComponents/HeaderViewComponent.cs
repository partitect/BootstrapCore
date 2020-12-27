using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BootstrapCore.Models;
using Microsoft.AspNetCore.Mvc;



namespace BootstrapCore.ViewComponents
{
	public class HeaderViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			List<About> about = new List<About>();
			about.Add(new About { id = 1, title = "Vizyon", link = "test" });
			about.Add(new About { id = 2, title = "Misyon", link = "test" });


			return View(about);
		}
	}
}
