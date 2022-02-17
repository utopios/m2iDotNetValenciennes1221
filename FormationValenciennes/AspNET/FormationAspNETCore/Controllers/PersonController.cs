using FormationAspNETCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FormationAspNETCore.Controllers
{
    public class PersonController : Controller
    {
        // GET: PersonController
        public ActionResult Index()
        {            
            return View();
        }

        // GET: PersonController/Details/5
        public ActionResult Details(int id)
        {
            Person person = Person.GetPersonById(id);
            return View(person);
        }

        // GET: PersonController/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: PersonController/FormPerson
        public IActionResult FormPerson()
        {
            return View();
        }

        // GET: PersonController/FormPerson
        public IActionResult SubmitPerson(string FirstName, string LastName, string Phone)
        {
            Person p = new(FirstName, LastName, Phone);
            return View(p);
        }

        // GET: PersonController/DisplayPerson
        public IActionResult DisplayPerson()
        {
            // renvoie du HTMl généré par Razor
            List<Person> liste = Person.GetPersons();

            // Pour partager les données entre le controlleur et la vue
            // 1 => Par le model de vue

            // 2 => ViewData
            // ViewData["listePersonnes"] = liste;

            // 3 => ViewBag
            //ViewBag.ListePersonnes = liste;

            return View(liste);
        }

        // POST: PersonController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PersonController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PersonController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
