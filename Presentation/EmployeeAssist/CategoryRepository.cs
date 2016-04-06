using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeAssist.Models;
using System.Net.Http;

namespace EmployeeAssist
{
    public class CategoryRepository
    {
        string BaseAddress = "http://localhost:50316";
        public void AddCategory(CategoryModel model)
        {
            HttpClient client = new HttpClient();
            Dictionary<string, string> output = null;
            client.BaseAddress = new Uri(BaseAddress + "/api/Category");
            using (client)
            {
                client.PostAsJsonAsync<CategoryModel>("",model);
                
            }
          
        }


        public void AddSubCategory(CategoryModel model)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseAddress + "/api/SubCategory");
            using (client)
            {
                client.PostAsJsonAsync<CategoryModel>("", model);

            }
        }

 
    }
}