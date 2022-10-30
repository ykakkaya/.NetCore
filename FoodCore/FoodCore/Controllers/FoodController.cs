using FoodCore.Models;
using FoodCore.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.Operations;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;

namespace FoodCore.Controllers
{
    public class FoodController : Controller
    {
        Context _context=new Context();
        FoodRepository foodRepository = new FoodRepository();
        public IActionResult Index(int page=1)
        {
            
            return View(foodRepository.GetAllGeneric("Category").ToPagedList(page,5));
        }
        [HttpGet]
        public IActionResult AddFood()
        {
            List<SelectListItem> categoryList = (from x in _context.Categories.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.CategoryName,
                                                     Value = x.CategoryId.ToString()
                                                 }).ToList();

            ViewBag.v1 = categoryList;

            return View();

           
        }
        [HttpPost]
        public IActionResult AddFood(Food food)
        {
            if (!ModelState.IsValid)
            {
                return View("AddFood");
            }
            food.FoodStatus = true;
            foodRepository.CreateGeneric(food);
            return RedirectToAction("index");
        }
        public IActionResult GetFood(int id)
        {
            List<SelectListItem> categoryList = (from i in _context.Categories.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = i.CategoryName,
                                                     Value = i.CategoryId.ToString()
                                                 }).ToList();

            ViewBag.v1 = categoryList;
            var values = foodRepository.GetByIdGeneric(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateFood(Food food)
        {
            var updateFood = foodRepository.GetByIdGeneric(food.FoodId);
            updateFood.FoodName=food.FoodName;
            updateFood.FoodPrice=food.FoodPrice;
            updateFood.FoodStock=food.FoodStock;
            updateFood.FoodDesc=food.FoodDesc;
            updateFood.FoodStatus=food.FoodStatus;
            updateFood.CategoryId=food.CategoryId;
            updateFood.FoodImgUrl=food.FoodImgUrl;
            foodRepository.UpdateGeneric(updateFood);
            return RedirectToAction("index");
        }


        public IActionResult DeleteFood(int id)
        {
            var deletedFood=foodRepository.GetByIdGeneric(id);
            deletedFood.FoodStatus = false;
            foodRepository.UpdateGeneric(deletedFood);

            return RedirectToAction("index");
        }
    }
}
