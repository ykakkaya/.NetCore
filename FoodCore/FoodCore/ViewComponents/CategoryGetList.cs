using FoodCore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FoodCore.ViewComponents
{
    public class CategoryGetList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            var categories = categoryRepository.GetAllGeneric();
            return View(categories);
        }
    }
}
