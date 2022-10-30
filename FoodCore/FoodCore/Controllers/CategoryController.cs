using FoodCore.Models;
using FoodCore.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using X.PagedList;

namespace FoodCore.Controllers
{
   
    public class CategoryController : Controller
    {
        Context _context=new Context(); 
        CategoryRepository categoryRepository = new CategoryRepository();
        //[Authorize]
        public IActionResult Index(int page=1)
        {
            
            
            return View(categoryRepository.GetAllGeneric().ToPagedList(1,5));
        }

        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View("CategoryAdd");
            }
            category.CategoryStatus = true;
            categoryRepository.CreateGeneric(category);
            return RedirectToAction("index");   
        }

        public IActionResult GetCategory(int id)
        {
            var values=categoryRepository.GetByIdGeneric(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            var updatedCategory = categoryRepository.GetByIdGeneric(category.CategoryId);
            updatedCategory.CategoryName = category.CategoryName;
            updatedCategory.CategoryDesc=category.CategoryDesc;
            updatedCategory.CategoryStatus=category.CategoryStatus;
            categoryRepository.UpdateGeneric(updatedCategory);
            return RedirectToAction("index");
        }


        public IActionResult DeleteCategory(int id)
        {
            var deletedCategory = categoryRepository.GetByIdGeneric(id);
            deletedCategory.CategoryStatus = false;
            categoryRepository.UpdateGeneric(deletedCategory);
            return RedirectToAction("index");
        }
    }
}
