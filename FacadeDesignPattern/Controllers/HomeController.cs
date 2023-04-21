using Microsoft.AspNetCore.Mvc;

namespace FacadeDesignPattern.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
