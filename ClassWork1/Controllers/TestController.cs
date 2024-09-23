using Microsoft.AspNetCore.Mvc;

namespace ClassWork1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
