using CredentialStorageWebsbor.Models;
using CredentialStorageWebsbor.Models.CredentialStorage;
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
        public IActionResult Edit(int id)
        {           
            return View(new EditCredentialStorageViewModel(id));
        }

        [HttpPost]
        public string Update(int id)
        {
            return $"Запись обновлена!";
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public string Create(NewCredentialStorageViewModel createdCredential)
        {
            return $"Создан объект: {createdCredential.Name}";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
