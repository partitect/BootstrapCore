using BootstrapCore.Models;
using BootstrapCore.Tools;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootstrapCore.Controllers
{
	public class NewsDetailController : Controller
	{
		[Route("/news/{title}-{id}-karatekin")]
		public IActionResult Index(string title,int id)
		{
			List<News> news = new List<News> {
			new News{id = 1, title = "Edirnede, barajlarda doluluk oranı yüzde 46ya ulaştı", imgPath = "/assets/img/1.jpg", desc = "Birinci Haberin Başlığı", date = DateTime.Now.AddDays(-10) },
			new News{ id = 2, title = "Haber Başlığı 2", imgPath = "/assets/img/2.jpg", desc = "İkinci Haberin Başlığı", date = DateTime.Now.AddDays(-22) },
			new News{id = 3, title = "Haber Başlığı 3 ", imgPath = "/assets/img/3.jpg", desc = "Üçüncü Haberin Başlığı Something short and leading about the collection below—its contents, the creator, etc. Make it short and sweet, but not too short so folks don’t simply skip over it entirely.", date = DateTime.Now.AddDays(-14) },
			new News{ id = 4, title = "Haber Başlığı 4", imgPath = "/assets/img/4.jpg", desc = "Dördüncü Haberin Başlığı", date = DateTime.Now.AddDays(-10)},
			new News{ id = 5, title = "Haber Başlığı 5", imgPath = "/assets/img/5.jpg", desc = "Beşinci Haberin Başlığı", date = DateTime.Now.AddDays(-12)},
			new News{ id = 6, title = "Haber Başlığı 6", imgPath = "/assets/img/6.jpg", desc = "Altıncı Haberin Başlığı", date = DateTime.Now.AddDays(-4) }
		};
			if (!string.IsNullOrEmpty(title))
			{
				News selectedNews = news.FirstOrDefault(x => GeneralTools.KarakterDuzelt(x.title) == title && x.id == id) ?? null;
				if (selectedNews == null) return Redirect("/");
				else return View(selectedNews);
			}
			else return Redirect("/");

		}
	}
}
