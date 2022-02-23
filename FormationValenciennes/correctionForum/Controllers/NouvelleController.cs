using correctionForum.DAO;
using correctionForum.Models;
using Microsoft.AspNetCore.Mvc;

namespace correctionForum.Controllers
{
    public class NouvelleController : Controller
    {
        private NouvelleDAO nouvelleDao;
        
        public IActionResult Form()
        {
            return View();
        }

        public IActionResult SubmitForm(Nouvelle nouvelle)
        {
            //On récupère la nouvelle à partir du formulaire,
            //On complète la nouvelle, avec l'id de l'abonne et l'id du forum à parir des sessions (pas encore vu en cours).
            //On crée l'objet dao
            nouvelleDao = new NouvelleDAO();
            nouvelleDao.Save(nouvelle);
            if (nouvelle.Id > 0)
            {
                return RedirectToAction("Index", "Forum");
            }
            else
            {
                ViewBag.Error = "Erreur lors de l'ajout de la nouvelle";
                return View("Form");
            }
        }
    }
}