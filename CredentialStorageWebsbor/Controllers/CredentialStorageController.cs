using CredentialStorageWebsbor.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CredentialStorageWebsbor.Controllers
{
    public class CredentialStorageController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public CredentialStorageController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
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
