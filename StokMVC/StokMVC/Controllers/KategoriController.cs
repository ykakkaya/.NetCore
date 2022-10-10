using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StokMVC.Models.Entity;
using PagedList;
using PagedList.Mvc;

namespace StokMVC.Controllers
{
    public class KategoriController : Controller
    {
        DBStokTakipEntities db = new DBStokTakipEntities();
        
        // GET: Kategori
        public ActionResult Index(int sayfa=1)
        {
            var degerler = db.TBLKategori.ToList().ToPagedList(sayfa,5);
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniKategoriEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniKategoriEkle(TBLKategori p1)
        {
            if (!ModelState.IsValid) 
            {
                return View("YeniKategoriEkle");
            }
            db.TBLKategori.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Sil (int id)
        {
            var deger = db.TBLKategori.Find(id);
            db.TBLKategori.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KategoriGetir(int id)
        {
            var deger=db.TBLKategori.Find(id);
            return View("KategoriGetir",deger);
        }
        public ActionResult Guncelle(TBLKategori p2)
        {
            var deger = db.TBLKategori.Find(p2.KategoriId);
            deger.KategoriAd = p2.KategoriAd;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}