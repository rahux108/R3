using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using EmployeeAssist.WebApi.Models;
using EmployeeAssist.WebApi.Providers;
using EmployeeAssist.WebApi.Results;
using System.Linq;

namespace EmployeeAssist.WebApi.Controllers
{
    
    public class CategoryController : ApiController
    {
        // GET api/Geolocation/Countries
        [Route("api/Categories")]
        [HttpGet]
        public Dictionary<string,string> GetCategories()
        {

            return null;
        }
        [Route("api/SubCategories")]
        [HttpGet]
        public Dictionary<string, string> GetSubCategories([FromUri]string  countryId="0")
        {
            return null;
        }

        [Route("api/Category")]
        [HttpPost]
        public string AddCategory([FromBody]AddCategoryModel model)
        {

            return null;
        }

        [Route("api/SubCategory")]
        [HttpPost]
        public string AddSubCategory([FromBody]AddCategoryModel model)
        {

            return null;
        }

    }
}
