using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class ResumeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
