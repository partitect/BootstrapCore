using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carousel.Models;
using Carousel.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Carousel.Controllers
{
    public class HomeController : Controller
    {
        List<Slide> slides = new List<Slide> {
            new Slide{ID=1,Title="Birinci Slayt Başlığı",Description="Birinci Slayt Açıklaması",Picture="/contents/slide/1.jpg",DisplayIndex=1,Link="/home"},
            new Slide{ID=2,Title="İkinci Slayt Başlığı",Description="İkinci Slayt Açıklaması",Picture="/contents/slide/2.jpg",DisplayIndex=2,Link="/home"},
            new Slide{ID=3,Title="Üçüncü Slayt Başlığı",Description="Üçüncü Slayt Açıklaması",Picture="/contents/slide/3.jpg",DisplayIndex=3,Link="/home"},
            new Slide{ID=4,Title="Dördüncü Slayt Başlığı",Description="Dördüncü Slayt Açıklaması",Picture="/contents/slide/4.jpg",DisplayIndex=4,Link="/home"},
            new Slide{ID=5,Title="Beşinci Slayt Başlığı",Description="Beşinci Slayt Açıklaması",Picture="/contents/slide/5.jpg",DisplayIndex=5,Link="/home"},
        };

        List<Product> products = new List<Product> {
            new Product{ID=1,Name="Birinci Ürün Başlığı",Description="Birinci Ürün Açıklaması",Picture="/contents/slide/1.jpg",DisplayIndex=1,Detail="Birinci Ürün Detayı"},
            new Product{ID=2,Name="İkinci Ürün Başlığı",Description="İkinci Ürün Açıklaması",Picture="/contents/slide/2.jpg",DisplayIndex=2,Detail="Birinci Ürün Detayı"},
            new Product{ID=3,Name="Üçüncü Ürün Başlığı",Description="Üçüncü Ürün Açıklaması",Picture="/contents/slide/3.jpg",DisplayIndex=3,Detail="Birinci Ürün Detayı"},
            new Product{ID=4,Name="Dördüncü Ürün Başlığı",Description="Dördüncü Ürün Açıklaması",Picture="/contents/slide/4.jpg",DisplayIndex=4,Detail="Birinci Ürün Detayı"},
            new Product{ID=5,Name="Beşinci Ürün Başlığı",Description="Beşinci Ürün Açıklaması",Picture="/contents/slide/5.jpg",DisplayIndex=5,Detail="Birinci Ürün Detayı"},
        };

        List<News> news = new List<News> {
            new News{ID=1,Title="Birinci Haber Başlığı",Description="Birinci Haber Açıklaması",Picture="/contents/slide/1.jpg",RecDate=DateTime.Now.AddDays(-1),Detail="Birinci Haber Başlığı"},
            new News{ID=2,Title="İkinci Haber Başlığı",Description="İkinci Haber Açıklaması",Picture="/contents/slide/2.jpg",RecDate=DateTime.Now.AddDays(-14),Detail="İkinci Haber Başlığı"},
            new News{ID=3,Title="Üçüncü Haber Başlığı",Description="Üçüncü Haber Açıklaması",Picture="/contents/slide/3.jpg",RecDate=DateTime.Now.AddDays(-21),Detail="Üçüncü Haber Başlığı"},
            new News{ID=4,Title="Dördüncü Haber Başlığı",Description="Dördüncü Haber Açıklaması",Picture="/contents/slide/4.jpg",RecDate=DateTime.Now.AddDays(-33),Detail="Dördüncü Haber Başlığı"},
            new News{ID=5,Title="Beşinci Haber Başlığı",Description="Beşinci Haber Açıklaması",Picture="/contents/slide/5.jpg",RecDate=DateTime.Now.AddDays(-1),Detail="Beşinci Haber Başlığı"},
        };

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Slides = slides,
                Products = products,
                News = news.OrderByDescending(o => o.RecDate).ToList()
            };
            ViewBag.canonical = "/";
            return View(homeVM);
        }

        public IActionResult TH_Test()
        {
            return View(products);
        }
    }
}
