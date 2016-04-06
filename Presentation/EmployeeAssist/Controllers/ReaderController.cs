
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeAssist.Models;

namespace EmployeeAssist.Controllers
{
    public class ReaderController : Controller
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

        [HttpPost]
        public ActionResult Index(ReaderViewModel model)
        {
            var repo = new GeoRepository();

            model.CountryOptions = repo.GetCountries();
            model.StateOptions = (!string.IsNullOrWhiteSpace(model.Country)) ? repo.GetStates(model.Country) : defaultListItem;
            model.CityOptions = (!string.IsNullOrWhiteSpace(model.State)) ? repo.GetCities(model.State) : defaultListItem;
            model.CategoryOptions = defaultListItem;
            model.SubCategoryOptions = defaultListItem;
            return View(model);
        }

        [HttpGet]
        public JsonResult GetStates(string country)
        {
            var result = new JsonResult();
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            //mock

            //result.Data = new List<ListItem>()
            //{
            //    new ListItem {id="",value="" },
            //   new ListItem { id="Florida",value="Florida"},
            //   new ListItem { id= "Georgia",value="Georgia" },
            //   new ListItem { id = "North Carolina", value= "North Carolina" },
            //};
            var repo = new GeoRepository();
            result.Data = repo.GetStates(country);
            return result;
        }

        [HttpGet]
        public JsonResult GetCities(string country, string state)
        {
            var result = new JsonResult();
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            ////mock
            //if (state.Equals("Florida", StringComparison.InvariantCultureIgnoreCase))
            //{
            //    result.Data = new List<ListItem>()
            //    {
            //        new ListItem {id="",value="" },
            //       new ListItem { id="St Pete",value="St Pete"},
            //       new ListItem { id= "JacksonVille",value="JacksonVille" },
            //    };
            //}
            //if (state.Equals("Georgia", StringComparison.InvariantCultureIgnoreCase))
            //{
            //    result.Data = new List<ListItem>()
            //    {
            //        new ListItem {id="",value="" },
            //       new ListItem { id="Atlanta",value="Atlanta"},
            //       new ListItem { id= "Alpharetta",value="Alpharetta" },
            //    };
            //}
            //if (state.Equals("North Carolina", StringComparison.InvariantCultureIgnoreCase))
            //{
            //    result.Data = new List<ListItem>()
            //    {
            //        new ListItem {id="",value="" },
            //       new ListItem { id="Charlotte",value="Charlotte"},
            //    };
            //}
            //return result;

            var repo = new GeoRepository();
            result.Data = repo.GetCities(state);
            return result;

        }

        [HttpGet]
        public JsonResult GetCategories(string country, string city, string state)
        {
            var result = new JsonResult();
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            //mock
            result.Data = new List<ListItem>()
                {
                new ListItem {id="",value="" },
                   new ListItem { id="Accomodation",value="Accomodation"},
                   new ListItem { id="Allowances",value="Allowances"},
                };
            return result;
        }


        [HttpGet]
        public JsonResult GetSubCategories(string country, string city, string state, string category)
        {
            var result = new JsonResult();
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            //mock
            if (category.Equals("Accomodation", StringComparison.InvariantCultureIgnoreCase))
            {
                result.Data = new List<ListItem>()
                {
                    new ListItem {id="",value="" },
                   new ListItem { id="Share",value="Share"},
                   new ListItem { id="New",value="New"},
                };
            }
            if (category.Equals("Allowances", StringComparison.InvariantCultureIgnoreCase))
            {
                result.Data = new List<ListItem>()
                {
                    new ListItem {id="",value="" },
                   new ListItem { id="ChildEducation",value="ChildEducation"},
                   new ListItem { id="Internet",value="Internet"},
                };
            }

            return result;
        }



    }
}