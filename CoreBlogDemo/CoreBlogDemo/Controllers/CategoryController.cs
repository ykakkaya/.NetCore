﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogDemo.Controllers
{
   
    public class CategoryController : Controller
    { 
        CategoryManager cm =new CategoryManager( new EfCategoryRepository());
        public IActionResult Index()
        {
            var values = cm.GetAllList();
            return View(values);
        }
    }
}
