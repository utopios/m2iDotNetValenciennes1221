using Microsoft.AspNetCore.Mvc;

namespace correctionForum.Controllers
{
    public class ForumController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}