using DBFirstSpp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBFirstSpp.Controllers
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
			
			return View(db.Urunler.Include(i=> i.Category));
		}
	}
}
