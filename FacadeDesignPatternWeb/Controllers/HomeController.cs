using FacadeDesignPatternWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ProductDetails;
using PaymentService;
using SendInvoiceService;

namespace FacadeDesignPatternWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var getProductDetaisl = new GetProductDetails();
            var makePayment = new Payment();
            var sendInvoice = new SendInvoice();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}