using Microsoft.AspNetCore.Mvc;
using Portfolio.ViewModels;

namespace Portfolio.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            AboutViewModel vm = new AboutViewModel();

            return View(vm);
        }
    }
}
