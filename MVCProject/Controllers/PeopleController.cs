using System.Web.Mvc;
using MVCProject.Models;
using DataLibrary;
using static DataLibrary.BusinessLogic.PersonProcessor;
using System.Collections.Generic;

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

        public ActionResult ViewPeople()
        {
            ViewBag.message = "List of People";

            var data = LoadPeople();

            List<PersonModel> people = new List<PersonModel>();
            foreach (var row in data)
            {
                people.Add(new PersonModel { 
                    PersonId = row.PersonId,
                    FirstName = row.FirstName,
                    LastName = row.LastName,
                    Email = row.Email
                });
            }

            return View(people);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult edit(PersonModel model)
        {
            if (ModelState.IsValid)
            {
                int recordEdited = EditPerson(model.PersonId, model.FirstName, model.LastName, model.Email);
                return RedirectToAction("ViewPeople");
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(PersonModel model)
        {
            if (ModelState.IsValid)
            {
                int recordCreated = CreatePerson(model.PersonId, model.FirstName, model.LastName, model.Email);
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