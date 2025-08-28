using Microsoft.AspNetCore.Mvc;

namespace Day02Lab.Controllers
{
    public class New1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Sample()
        {
            return View();
        }
        public IActionResult Error() {
            return View();
        }
    }
}
