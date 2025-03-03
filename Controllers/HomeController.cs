using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using YogaMasterskyaMVC.Models;

namespace YogaMasterskyaMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View(_configuration);
        }
    }
}
