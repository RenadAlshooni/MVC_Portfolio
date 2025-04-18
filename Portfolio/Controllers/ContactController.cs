using Microsoft.AspNetCore.Mvc;
using Portfolio.ViewModels;

namespace Portfolio.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            ContactViewModel vm = new ContactViewModel();
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //Not completed yet
        public IActionResult Send()
        {
            if (ModelState.IsValid)
            {
                
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
