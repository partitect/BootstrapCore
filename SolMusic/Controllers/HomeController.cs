using Microsoft.AspNetCore.Mvc;
using SolMusic.Models;
using SolMusic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolMusic.Controllers
{
	public class HomeController : Controller
	{
		MyContext db;
		public HomeController(MyContext _db)
		{
			db = _db;
		}
		public IActionResult Index()
		{
			//HomeVM homeVM = new HomeVM
			//{
			//	Navbar = db.Pages,
			//	//Products = products,
			//	//News = news.OrderByDescending(o => o.RecDate).ToList()
			//};
			ViewBag.canonical = "/";
			return View();
		}
	}
}
