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
    public class UrunController : Controller
    {
        DBStokTakipEntities db = new DBStokTakipEntities();
        // GET: Urun
        public ActionResult Index(int sayfa=1)
        {
            var degerler = db.TBLUrun.ToList().ToPagedList(sayfa, 10);
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniUrunEkle()
        {
            List<SelectListItem> degerler = (from i in db.TBLKategori.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.KategoriAd,
                                                 Value = i.KategoriId.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }
        [HttpPost]
        public ActionResult YeniUrunEkle(TBLUrun p1)
        {
           
            var ktg = db.TBLKategori.Where(m => m.KategoriId == p1.TBLKategori.KategoriId).FirstOrDefault();
            p1.TBLKategori = ktg;
            db.TBLUrun.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Sil(int id)
        {
            var deger = db.TBLUrun.Find(id);
            db.TBLUrun.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UrunGuncelle(int id)
        {
            var deger = db.TBLUrun.Find(id);
            return View("UrunGuncelle", deger);
        }
        public ActionResult Guncelle(TBLUrun p2)
        {
            var deger = db.TBLUrun.Find(p2.UrunId);
            deger.UrunAd = p2.UrunAd;
            deger.UrunFiyat = p2.UrunFiyat;
            deger.UrunMarka = p2.UrunMarka;
            deger.UrunStok = p2.UrunStok;
            deger.UrunKategori = p2.UrunKategori;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}