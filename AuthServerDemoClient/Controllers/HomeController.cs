using AuthServerDemoClient.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AuthServerDemoClient.Controllers
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
            return View();
        }


        [HttpGet]
        public IActionResult Redirect(string returnUrl = "/")
        {

            return Challenge(
                new AuthenticationProperties
                { 
                    RedirectUri = returnUrl 
                },
                "custom" 
                );
        }

    }
}