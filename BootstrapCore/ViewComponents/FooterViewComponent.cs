using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BootstrapCore.Models;
using Microsoft.AspNetCore.Mvc;



namespace BootstrapCore.ViewComponents
{
	public class FooterViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			List<SocialMedia> smed = new List<SocialMedia>();
			smed.Add(new SocialMedia { id = 1, title = "Twitter", link = "test" });
			smed.Add(new SocialMedia { id = 2, title = "Facebook", link = "test" });
			smed.Add(new SocialMedia { id = 2, title = "Instagram", link = "test" });
			smed.Add(new SocialMedia { id = 2, title = "Youtube", link = "test" });



			return View(smed);
		}
	}
}
