using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment2.Controllers
{
    public class ProjectsController : Controller
    {
        [HttpGet]
        public IActionResult InProgress()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CompletedProjects()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ProjectIdeas()
        {
            return View();
        }
    }
}
