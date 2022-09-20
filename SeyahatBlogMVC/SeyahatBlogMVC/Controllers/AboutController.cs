﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeyahatBlogMVC.Models.Siniflar;

namespace SeyahatBlogMVC.Controllers
{
    public class AboutController : Controller
    {
        Context c = new Context();
        // GET: About
        public ActionResult Index()
        {
            var deger=c.Hakkimizdas.ToList();
            return View(deger);
        }
    }
}