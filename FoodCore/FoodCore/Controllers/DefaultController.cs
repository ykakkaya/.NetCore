using FoodCore.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FoodCore.Controllers
{
    public class DefaultController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            FoodRepository foodRepository = new FoodRepository();
            var foods = foodRepository.GetAllGeneric();
            return View(foods);
        }
    }
}
