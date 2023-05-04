using CPProgressTracker.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CPProgressTracker.Controllers
{
    //[Route("api/home")]
    public class HomeController : BaseApiController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var response = new GenericResponseModel<string>()
            {
                Data = "This is for testing",
                Message = "The request is ok"
            };
            return Json(response);
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