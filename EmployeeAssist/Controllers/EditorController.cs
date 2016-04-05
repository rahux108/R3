
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeAssist.Models;

namespace EmployeeAssist.Controllers
{
    public class EditorController : Controller
    {
        // GET: Search
        public ActionResult Index()
        {
            return View(new ReaderViewModel()
            {

                CountryOptions = new List<ListItem>()
                {
                    new ListItem {id="",value="" },
                    new ListItem { id="UnitedStates", value="UnitedStates" },
                     new ListItem { id="NewZealand", value="NewZealand" }
                },
                StateOptions = new List<ListItem>(),
                CityOptions = new List<ListItem>(),
                CategoryOptions = new List<ListItem>()
                {
                    new ListItem {id="",value="" },
                    new ListItem { id="Accomodation",value="Accomodation"},
                    new ListItem { id="Allowances",value="Allowances"}
                },
                SubCategoryOptions = new List<ListItem>()
            });
        }

    }
}