using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carousel.Models;
using Microsoft.AspNetCore.Mvc;

namespace Carousel.Controllers
{
    public class ProductController : Controller
    {
        List<Product> products = new List<Product> {
            new Product{ID=1,Name="Birinci Ürün Başlığı",Description="Birinci Ürün Açıklaması",Picture="/contents/slide/1.jpg",DisplayIndex=1,Detail="Birinci Ürün Detayı"},
            new Product{ID=2,Name="İkinci Ürün Başlığı",Description="İkinci Ürün Açıklaması",Picture="/contents/slide/2.jpg",DisplayIndex=2,Detail="Birinci Ürün Detayı"},
            new Product{ID=3,Name="Üçüncü Ürün Başlığı",Description="Üçüncü Ürün Açıklaması",Picture="/contents/slide/3.jpg",DisplayIndex=3,Detail="Birinci Ürün Detayı"},
            new Product{ID=4,Name="klavye",Description="Dördüncü Ürün Açıklaması",Picture="/contents/slide/4.jpg",DisplayIndex=4,Detail="Birinci Ürün Detayı"},
            new Product{ID=5,Name="Beşinci Ürün Başlığı",Description="Beşinci Ürün Açıklaması",Picture="/contents/slide/5.jpg",DisplayIndex=5,Detail="Birinci Ürün Detayı"},
        };

        [Route("/urunler/{name}")]
        //[Route("/kalite/urun/{name}")]
        [Route("/firma/[controller]/[action]/{name}")]
        public IActionResult Detail(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                Product p = products.FirstOrDefault(f => f.Name == name) ?? null;
                if (p != null)
                {
                    ViewBag.canonical = "/urunler/"+p.Name;
                    return View(p);
                }
                else return Redirect("/");
            }
            else return Redirect("/");
        }
    }
}
