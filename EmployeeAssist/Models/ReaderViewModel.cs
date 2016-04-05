using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using EmployeeAssist.Models;

namespace EmployeeAssist.Models
{
    public class ReaderViewModel : CategoryModel
    {
        public IEnumerable<ListItem> CountryOptions { get; set; }

        public IEnumerable<ListItem> StateOptions { get; set; }

        public IEnumerable<ListItem> CityOptions {get; set; }

        public IEnumerable<ListItem> CategoryOptions { get; set; }

        public IEnumerable<ListItem> SubCategoryOptions { get; set; }
    }
}