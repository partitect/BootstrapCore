using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootstrapCore.Controllers
{
	public class AboutController : Controller
	{
		public IActionResult Index()
		{
			ViewBag.activePage = "about";
			return View();
		}
	}
}
