using MentorProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MentorProject.Controllers
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
            int studentCount = 10;
            ViewBag.Header = "Uniser Back-end";
            ViewBag.GroupMemberStatus = studentCount > 4 ? $"Good" : "Bad";
            ViewData["Content"] = "They are learn back-end with Gunel :)";
            TempData["CountOfStudents"] = studentCount;

            TempData["class-name"] = studentCount > 5 ? "text-success" : "text-danger";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
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
