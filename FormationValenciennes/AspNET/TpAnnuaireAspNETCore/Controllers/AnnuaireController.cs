using TpAnnuaireAspNETCore.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TpAnnuaireAspNETCore.Controllers
{
    public class AnnuaireController : Controller
    {

        IWebHostEnvironment _env;

        public AnnuaireController(IWebHostEnvironment env)
        {
            _env = env;
        }
        public IActionResult Index(string search)
        {
            //ViewData["listeContacts"] = Contact.GetAll();
            //ViewBag.ListeContacts = Contact.GetAll();
            List<Contact> contacts = search == null ? Contact.GetAll() : Contact.SearchContact(search);
            return View(contacts);
        }

        public IActionResult Details(int id)
        {
            Contact contact = Contact.GetContactById(id);
            return View(contact);
        }

        public IActionResult ConfirmDelete(int id)
        {
            Contact contact = Contact.GetContactById(id);
            return View(contact);
        }

        public IActionResult Delete(int id)
        {
            Contact contact = Contact.GetContactById(id);
            return View(contact !=null ? contact.Delete() : false);
        }

        public IActionResult Form(int? id)
        {
            Contact contact = (id != null) ? Contact.GetContactById((int)id) : new();
            return View(contact);
        }

        //public IActionResult SubmitForm(string firstName, string lastName, string phone)
        public IActionResult SubmitForm(Contact contact, IFormFile avatar)
        {
            //Contact contact = new Contact { FirstName = firstName, LastName = lastName, Phone = phone };
            if(contact.Id > 0)
                contact.Update();            
            else
            {
                contact.Url = Upload(avatar);
                contact.Save();
            }
            //on peut faire une redirection vers l'action index
            return RedirectToAction("Index", "Annuaire");
        }

        private string Upload(IFormFile image)
        {
            string salt = Guid.NewGuid().ToString();
            string path = Path.Combine(_env.WebRootPath, "images", salt + "-" + image.FileName);
            //Création d'un flux vers le chemin cible
            Stream stream = System.IO.File.Create(path);
            image.CopyTo(stream);
            stream.Close();
            //stocker le chemin dans un viewBag, ou dans une base de données
            return "images/" + salt + "-" + image.FileName;
        }
    }
}
