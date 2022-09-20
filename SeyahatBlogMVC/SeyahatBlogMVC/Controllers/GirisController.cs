using SeyahatBlogMVC.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SeyahatBlogMVC.Controllers
{
    public class GirisController : Controller
    {
        Context c = new Context();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Index(Admin a)
        {
            var deger = c.Admins.FirstOrDefault(x => x.AdminUser == a.AdminUser && x.AdminPassword == a.AdminPassword);
            if (deger != null)
            {
                FormsAuthentication.SetAuthCookie(deger.AdminUser, false);
                Session["AdminUser"] = deger.AdminUser.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View("Index"); 
            }
           
            
        } 
        public ActionResult LogOut()
            {
                FormsAuthentication.SignOut();
                return RedirectToAction("Index", "Giris");
            }
    }
}