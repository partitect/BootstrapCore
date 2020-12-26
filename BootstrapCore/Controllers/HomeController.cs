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
			ViewData["products"] = new[]
	{
		new Albums { id = 1, title="Bootstrap Card 1", desc = "Curabitur suscipit suscipit tellus. Suspendisse faucibus, nunc et pellentesque egestas",imgPath="./assets/img/1.jpg" },
		new Albums { id = 2,  title="Bootstrap Card 2", desc = "Curabitur nisi. Donec mi odio, faucibus at, scelerisque quis, convallis in, nisi.",imgPath="./assets/img/2.jpg" },
		new Albums { id = 3,  title="Bootstrap Card 3", desc = "Curabitur turpis. Vestibulum eu odio.",imgPath="./assets/img/3.jpg"},
		new Albums { id = 4,  title="Bootstrap Card 4", desc = " lacus ante convallis tellus, vitae iaculis lacus elit id tortor. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo.",imgPath="./assets/img/4.jpg"},
		new Albums { id = 5,  title="Bootstrap Card 5", desc = "Donec vitae orci sed dolor rutrum auctor. Maecenas vestibulum mollis diam.",imgPath="./assets/img/5.jpg"},
		new Albums { id = 6,  title="Bootstrap Card 6", desc = "Pellentesque dapibus hendrerit tortor. Donec elit libero, sodales nec, volutpat a, suscipit non, turpis.",imgPath="./assets/img/6.jpg"},
		new Albums { id = 7,  title="Bootstrap Card 7", desc = "Praesent ac massa at ligula laoreet iaculis. Etiam ut purus mattis mauris sodales aliquam.",imgPath="./assets/img/7.jpg"},
		new Albums { id = 8,  title="Bootstrap Card 8", desc = "Pellentesque libero tortor, tincidunt et, tincidunt eget, semper nec, quam. Nullam cursus lacinia erat.",imgPath="./assets/img/8.jpg"},
		new Albums { id = 9,  title="Bootstrap Card 9", desc = "Donec vitae orci sed dolor rutrum auctor. Duis vel nibh at velit scelerisque suscipit.",imgPath="./assets/img/9.jpg"},
	};
			return View();
		}
	}
}
