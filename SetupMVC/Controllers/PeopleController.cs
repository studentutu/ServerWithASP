using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SetupMVC.Models;

namespace SetupMVC.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            var any = new PersonModel { Age = 0, UserName = "Studentutu", LastName = "Fedorov" };
            int i = 1 / any.Age;
            return View();
        }

        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();
            people.Add(new PersonModel { Age = 24, UserName = "Studentutu", LastName = "Fedorov"});
            people.Add(new PersonModel { Age = 38, UserName = "Joe", LastName = "Cow" });
            people.Add(new PersonModel { Age = 54, UserName = "Steve", LastName = "Split" });

            return View(people);
        }
    }
}