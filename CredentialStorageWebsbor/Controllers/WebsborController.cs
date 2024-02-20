using CredentialStorageWebsbor.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CredentialStorageWebsbor.Controllers
{
    public class WebsborController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public WebsborController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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
