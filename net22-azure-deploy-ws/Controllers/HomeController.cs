using Microsoft.AspNetCore.Mvc;
using net22_azure_deploy_ws.Models;
using System.Diagnostics;

namespace net22_azure_deploy_ws.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _config;
        public HomeController(IConfiguration configuration)
        {
            _config = configuration;
        }

        public IActionResult Index()
        {
            ViewBag.MyGreeting = _config["MyGreeting"];
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