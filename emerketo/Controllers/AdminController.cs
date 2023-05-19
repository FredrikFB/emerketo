using emerketo.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace emerketo.Controllers
{
    public class AdminController : Controller
    {
         

        [Authorize(Roles = "admin")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllUsers()
        {
            return View();
        }
        public IActionResult RegisterProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterProduct(ProductRegistrationViewModel viewModel)
        {
            if(ModelState.IsValid)
            {

            }
            return View();
        }

        public IActionResult RoleChange()
        {
            return View();
        }
    }
}
