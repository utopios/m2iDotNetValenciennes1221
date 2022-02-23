using Microsoft.AspNetCore.Mvc;

namespace correctionForum.Controllers
{
    public class AbonneController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}