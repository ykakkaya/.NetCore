using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeyahatBlogMVC.Models.Siniflar;



namespace SeyahatBlogMVC.Controllers
{
    public class BlogController : Controller
    {
        Context c = new Context();
        
        BlogYorum by = new BlogYorum();
       
        // GET: Blog
       
        public ActionResult Index()
        {
            by.Deger1 = c.Blogs.OrderByDescending(x=>x.BlogId).ToList();
            by.Deger2 = c.Yorums.OrderByDescending(x => x.YorumId).Take(3).ToList();
            by.Deger3 = c.Blogs.OrderByDescending(x => x.BlogId).Take(3).ToList();

            return View(by);
        } 
        
        public ActionResult BlogDetay(int id)
        {

            by.Deger1 = c.Blogs.Where(x => x.BlogId == id).ToList();
            //var blog = c.Blogs.Where(x => x.BlogId == id).ToList();
            by.Deger2 = c.Yorums.Where(x => x.BlogId == id).ToList();
            return View(by);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult YorumYap(Yorum p)
        {
            c.Yorums.Add(p);
            c.SaveChanges();
            return PartialView();
        }
    }
}