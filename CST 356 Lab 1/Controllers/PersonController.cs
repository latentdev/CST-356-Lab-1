using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CST_356_Lab_1.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            var person = new Models.Person { Name = "Nick Olson", Age = 30, BirthDate = new DateTime(1987, 9, 6) };

            return View(person);
        }
    }
}