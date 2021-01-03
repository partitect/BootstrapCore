using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace DBApp.Controllers
{
    public class ProductController : Controller
    {
        IData db;
        public ProductController(IData _db)
        {
            db = _db;
        }
        [Route("/urunler")]
        public IActionResult Index()
        {
            return View(db.GetAllProduct());
        }

        [Route("/urunler/{name}/{id}")]
        public IActionResult Detail(string name,int id)
        {
            if (!string.IsNullOrEmpty(name))
            {
                var sonuc = db.GetProduct(id) ?? null;
                if (sonuc != null)
                {
                    ViewBag.canonical = "/urunler/" + sonuc.Name;
                    return View(sonuc);
                }
                else return Redirect("/");
            }
            else return Redirect("/");
        }
    }
}
