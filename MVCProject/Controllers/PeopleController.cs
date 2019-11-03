using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCProject.Models;

namespace MVCProject.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignUp()
        {
            ViewBag.message = "People sign up";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(PersonModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult ListPeople()
        {
            /*List<PersonModel> people = new List<PersonModel>();
            
            people.Add(new PersonModel {FirstName = "Iago", LastName = "Cortes", Age = 25 });
            people.Add(new PersonModel { FirstName = "Ana", LastName = "Cortes", Age = 27 });*/

            return View();// return View(people);
        }
    }
}