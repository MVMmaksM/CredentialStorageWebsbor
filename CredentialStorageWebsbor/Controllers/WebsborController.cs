using CredentialStorageWebsbor.Models;
using CredentialStorageWebsbor.Models.Websbor;
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

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(new EditWebsborViewModel(id));
        }

        [HttpPost]
        public string Update(int id)
        {
            return $"Запись обновлена {id}!";
        }

        [HttpPost]
        public string Create(NewWebsborViewModel newWebsbor)
        {
            return $"Создана запись {newWebsbor.OKPO}";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
