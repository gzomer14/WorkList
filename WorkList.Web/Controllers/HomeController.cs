using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WorkList.Application.Interfaces;

namespace WorkList.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IToDoAppService _service;

        public HomeController(ILogger<HomeController> logger, IToDoAppService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}