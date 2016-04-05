using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeAssist.Models;

namespace EmployeeAssist.Controllers
{
    public class CategoryController : Controller
    {
        [HttpPost]
        public ActionResult AddCategory(CategoryModel model)
        {
            return RedirectToAction("Index", "Editor");
        }

        [HttpPost]
        public ActionResult AddSubCategory(CategoryModel model)
        {
            return RedirectToAction("Index", "Editor");
        }
    }
}