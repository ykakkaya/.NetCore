using FoodCore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FoodCore.ViewComponents
{
    public class FoodGetList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            FoodRepository foodRepository = new FoodRepository();
            var foodList = foodRepository.GetAllGeneric();
            return View(foodList);
        }
    }
}
