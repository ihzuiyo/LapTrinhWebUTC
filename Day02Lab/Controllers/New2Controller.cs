using Microsoft.AspNetCore.Mvc;

namespace Day02Lab.Controllers
{
    public class New2Controller : Controller
    {
        public IActionResult TrangChu()
        {
            return View();
        }
        public IActionResult GioiThieu()
        {
            return View();
        }
    }
}
