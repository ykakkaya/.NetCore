using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeyahatBlogMVC.Models.Siniflar;

namespace SeyahatBlogMVC.Controllers
{
    public class HomeController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }
        public PartialViewResult Partial1()
        {
            var deger = c.Blogs.OrderByDescending(x => x.BlogId).Take(2).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial2()
        {
            var deger = c.Blogs.Where(x => x.BlogId==3).ToList();
            return PartialView (deger);
        }
        public PartialViewResult Partial3()
        {
            var deger = c.Blogs.OrderByDescending(x => x.BlogId).Take(10).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial4()
        {
            var deger = c.Blogs.Take(3).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial5()
        {
            var deger = c.Blogs.OrderByDescending(x => x.BlogId).Take(3).ToList();
            return PartialView(deger);
        }
     

    }
}