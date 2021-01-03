using BootstrapCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace BootstrapCore.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			List <News> news = new List<News>();
			news.Add(new News { id = 1, title = "Edirnede, barajlarda doluluk oranı yüzde 46ya ulaştı", desc = "Curabitur suscipit suscipit tellus. Suspendisse faucibus, nunc et pellentesque egestas", imgPath = "./assets/img/1.jpg",date=DateTime.Now.AddDays(-10) });
			news.Add(new News { id = 2, title = "Bootstrap Card 1", desc = "Curabitur suscipit suscipit tellus. Suspendisse faucibus, nunc et pellentesque egestas", imgPath = "./assets/img/2.jpg", date = DateTime.Now.AddDays(-10) });
			news.Add(new News { id = 3, title = "Bootstrap Card 1", desc = "Curabitur suscipit suscipit tellus. Suspendisse faucibus, nunc et pellentesque egestas", imgPath = "./assets/img/3.jpg", date = DateTime.Now.AddDays(-10) });
			news.Add(new News { id = 4, title = "Bootstrap Card 1", desc = "Curabitur suscipit suscipit tellus. Suspendisse faucibus, nunc et pellentesque egestas", imgPath = "./assets/img/4.jpg", date = DateTime.Now.AddDays(-10) });
			news.Add(new News { id = 5, title = "Bootstrap Card 1", desc = "Curabitur suscipit suscipit tellus. Suspendisse faucibus, nunc et pellentesque egestas", imgPath = "./assets/img/5.jpg", date = DateTime.Now.AddDays(-10) });
			news.Add(new News { id = 6, title = "Bootstrap Card 1", desc = "Curabitur suscipit suscipit tellus. Suspendisse faucibus, nunc et pellentesque egestas", imgPath = "./assets/img/6.jpg", date = DateTime.Now.AddDays(-10) });
			ViewBag.activePage = "home";

			return View(news);
		}
	}
}
