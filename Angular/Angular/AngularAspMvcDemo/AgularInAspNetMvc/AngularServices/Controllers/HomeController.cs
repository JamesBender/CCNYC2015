using System.Collections.Generic;
using System.Web.Mvc;
using AngularServices.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AngularServices.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        
        private string GetListOfPeopleAsString()
        {
            var listOfPersons = new List<Person>
            {
                new Person {Id = 1, FirstName = "Han", LastName = "Solo", UserName = "HSolo"},
                new Person {Id = 2, FirstName = "Luke", LastName = "Skywalker", UserName = "LSkywalker"}
            };
            
            //var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            return JsonConvert.SerializeObject(listOfPersons); //, Formatting.None, settings);

        }
        public ActionResult BootstrapAttribute()
        {
            return View("BootstrapAttribute", "", GetListOfPeopleAsString());
        }

        
        public ActionResult BootstrapService()
        {
            return View("BootstrapService", "", GetListOfPeopleAsString());
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}