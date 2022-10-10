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
    public class MusteriController : Controller
    {
        DBStokTakipEntities db = new DBStokTakipEntities();
        // GET: Musteri
        public ActionResult Index(int sayfa=1)
        {
            var degerler = db.TBLMusteri.ToList().ToPagedList(sayfa, 5);
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniMusteriEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniMusteriEkle(TBLMusteri p1)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniMusteriEkle");
            }
            db.TBLMusteri.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Sil(int id)
        {
            var deger = db.TBLMusteri.Find(id);
            db.TBLMusteri.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult MusteriGuncelle(int id)
        {
            var deger = db.TBLMusteri.Find(id);
            return View ("MusteriGuncelle", deger);
        }
        public ActionResult Guncelle(TBLMusteri p2)
        {
            var deger = db.TBLMusteri.Find(p2.MusteriId);
            deger.MusteriAd = p2.MusteriAd;
            deger.MusteriSoyad = p2.MusteriSoyad;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}