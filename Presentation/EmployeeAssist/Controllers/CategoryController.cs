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
            if (!string.IsNullOrEmpty(model.Category) && !string.IsNullOrEmpty(model.SubCategory))
                new CategoryRepository().AddCategory(model);
            return RedirectToAction("Index", "Editor");
        }

        [HttpPost]
        public ActionResult AddSubCategory(CategoryModel model)
        {
            if (!string.IsNullOrEmpty(model.Category) && !string.IsNullOrEmpty(model.SubCategory))
                new CategoryRepository().AddSubCategory(model);
            return RedirectToAction("Index", "Editor");
        }
    }
}