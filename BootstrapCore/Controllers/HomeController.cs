using BootstrapCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootstrapCore.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			Albums albums = new Albums { id = 1, title = "Kolonya", desc= "",imgPath="" };
			return View(albums);
		}
	}
}
