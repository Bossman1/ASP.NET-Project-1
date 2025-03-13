using Microsoft.AspNetCore.Mvc;

namespace Lessons1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
