using Microsoft.AspNetCore.Mvc;
using SolMusic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolMusic.ViewComponents
{
	public class HeaderViewComponent : ViewComponent
	{
		MyContext db;
		public HeaderViewComponent(MyContext _db)
		{
			db = _db;
		}
		public IViewComponentResult Invoke()
		{
			return View(db.Pages);
		}
	}
}
