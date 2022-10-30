using FoodCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.Linq;

namespace FoodCore.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }

        public IActionResult VisualizeProductResult()
        {
            return Json(FoodList());
        }

        public List<FoodClass> FoodList()
        {
            List<FoodClass> foodClass = new List<FoodClass>();
            using(var _context=new Context())
            {
                foodClass = _context.Foods.Where(x=>x.FoodStatus==true).Select(x => new FoodClass
                {
                    foodname = x.FoodName,
                    foodstock = x.FoodStock,
                }).ToList();
            }
            return foodClass;
        }

        public IActionResult Statistcs()
        {
            using (var _context = new Context())
            {
                var deger = _context.Foods.Count();
                ViewBag.totalFood=deger;
                var deger2=_context.Categories.Where(x=>x.CategoryStatus==true).Count();
                ViewBag.totalCategory=deger2;

                var deger3 = _context.Foods.Where(x => x.CategoryId == 1).Count(y=>y.FoodStatus==true);
                ViewBag.totalMeyve=deger3;

                var deger4 = _context.Foods.Where(x => x.CategoryId == 2).Count(y => y.FoodStatus == true);
                ViewBag.totalSebze = deger4;
                var deger5 = _context.Foods.Where(x => x.CategoryId == 3).Count(y => y.FoodStatus == true);
                ViewBag.totalTahil = deger5;
                var deger6 = _context.Foods.Where(x => x.CategoryId == 4).Count(y => y.FoodStatus == true);
                ViewBag.totalYoresel = deger6;
                var deger7 = _context.Foods.Average(x => x.FoodPrice).ToString("0.00");
                ViewBag.avgFood = deger7;
                var deger8 = _context.Foods.OrderByDescending(x => x.FoodPrice).Select(x=>x.FoodName).FirstOrDefault();
                ViewBag.maxFoodPrice = deger8;
                var deger9 = _context.Foods.OrderBy(x => x.FoodPrice).Select(x => x.FoodName).FirstOrDefault();
                ViewBag.minFoodPrice = deger9;
            }
                return View();
        }

        
    }
}
