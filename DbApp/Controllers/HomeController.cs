using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbApp.Models;
using DBApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace DBApp.Controllers
{
    public class HomeController : Controller
    {
        IData db;
        public HomeController(IData _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            return View(db.GetAllCustomer());
        }

        [Route("/user/{id?}")]
        public IActionResult Detail(int id)
        {
            if (id!=null)
            {
                var sonuc = db.GetCustomer(id) ?? null;
                if (sonuc != null)
                {
                    ViewBag.canonical = "/user/" + sonuc.Name;
                    return View(sonuc);
                }
                else return Redirect("/");
            }
            else return Redirect("/");
        }
    }
}
