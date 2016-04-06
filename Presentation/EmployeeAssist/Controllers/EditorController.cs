
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

        List<ListItem> defaultListItem = new List<ListItem>() { new ListItem() { id = "", value = "select" } };
        // GET: Search
        public ActionResult Index()
        {
            var repo = new GeoRepository();

            var model = new ReaderViewModel()
            {

                CountryOptions = repo.GetCountries(),
                StateOptions = defaultListItem,
                CityOptions = defaultListItem,

                CategoryOptions = new List<ListItem>()
                {
                    new ListItem {id="",value="" },
                    new ListItem { id="Accomodation",value="Accomodation"},
                    new ListItem { id="Allowances",value="Allowances"}
                },
                SubCategoryOptions = defaultListItem
            };

            return View(model);

        }
    }
}