using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeyahatBlogMVC.Models.Siniflar;

namespace SeyahatBlogMVC.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        // GET: Admin
       [Authorize]
        public ActionResult Index()
        {
            var deger = c.Blogs.OrderBy(x=>x.BlokTarih).ToList();
            return View(deger);
        }
        
        [HttpGet]
        public ActionResult YeniBlogEkle()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult YeniBlogEkle(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

       
        public ActionResult BlogSil(int id)
        {
            var deger = c.Blogs.Find(id);
            c.Blogs.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("index");

        }
        
        public ActionResult BlogGuncelle(int id)
        {
            var deger = c.Blogs.Find(id);
            return View("BlogGuncelle", deger);

        }
        
        public ActionResult Guncelle(Blog p)
        {
           var deger = c.Blogs.Find(p.BlogId);
            deger.BlokBaslik = p.BlokBaslik;
            deger.BlogResimUrl = p.BlogResimUrl;
            deger.BlokTarih = p.BlokTarih;
            deger.BlokAciklama = p.BlokAciklama;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public ActionResult YorumSayfasi()
        {
            var deger = c.Yorums.ToList();
            return View(deger);
        }
       
        public ActionResult YorumSil (int id)
        {
            var deger = c.Yorums.Find(id);
            c.Yorums.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("YorumSayfasi");
            
        }
        
        public ActionResult YorumGuncelle(int id)
        {
            var deger = c.Yorums.Find(id);

            return View ("YorumGuncelle",deger);
        }
        
        public ActionResult Yguncelle(Yorum p)
        {
            var deger = c.Yorums.Find(p.YorumId);
            deger.KullaniciAdi = p.KullaniciAdi;
            deger.Mail = p.Mail;
            deger.Acıklama = p.Acıklama;
            deger.Blog.BlokBaslik = p.Blog.BlokBaslik;
            c.SaveChanges();
            return RedirectToAction("YorumSayfasi");

        }
        
        

    
    }
}