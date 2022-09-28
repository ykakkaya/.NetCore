using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBlogDemo.Controllers
{
    public class RegisterController : Controller
    {

        WriterManager wm = new WriterManager(new EfWriterRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            WriterValidation writerValidation = new WriterValidation();
            ValidationResult result = writerValidation.Validate(writer);
            if (result.IsValid)
            {
                writer.WriterAbout = "test";
                writer.WriterStatus = true;
                wm.WriterAdd(writer);
                return RedirectToAction("index", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }

        }
    }
}
