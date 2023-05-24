using emerketo.Helpers.Services;
using emerketo.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace emerketo.Controllers
{
    public class ContactsController : Controller
    {
        private readonly ContactService _contactServise;

        public ContactsController(ContactService contactServise)
        {
            _contactServise = contactServise;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(ContactFormViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                await _contactServise.CreateAsync(viewModel);
                return RedirectToAction("Index");
            }

            return View(viewModel);
        }
    }
}
