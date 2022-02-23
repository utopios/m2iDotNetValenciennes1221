using Microsoft.AspNetCore.Mvc;

namespace correctionForum.Controllers
{
    public class NouvelleController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}