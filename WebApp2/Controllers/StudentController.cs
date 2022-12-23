using Microsoft.AspNetCore.Mvc;

namespace WebApp2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [NonAction] // method become non action. its no more public action method.
        public string ShowDetails()
        {
            return "This is ShowDetails action method.";
        }
    }
}
