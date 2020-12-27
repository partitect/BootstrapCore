using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootstrapCore.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Index()
		{
			ViewBag.activePage = "contact";

			return View();
		}
	}
}
