using Microsoft.AspNetCore.Mvc;

namespace DangHoangHuy_231230797_Day04Lab.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
