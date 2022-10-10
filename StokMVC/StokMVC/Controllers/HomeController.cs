using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StokMVC.Models.Entity;

namespace StokMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
DBStokTakipEntities db = new DBStokTakipEntities();
        public ActionResult About(TBLKategori p1)
        {
            ViewBag.Message = "Your application description page.";
            var kat = db.TBLKategori.ToList();
            return View(kat);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}