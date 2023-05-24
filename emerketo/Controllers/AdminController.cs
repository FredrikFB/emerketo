using emerketo.Helpers.Services;
using emerketo.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace emerketo.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private readonly ProductService _productService;

        public AdminController(ProductService productService)
        {
            _productService = productService;
        }

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
        public async Task<IActionResult> RegisterProduct(ProductRegistrationViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                if ( await _productService.CreateAsync(viewModel))
                    return RedirectToAction("Index", "Products");
            }
            return View();
        }

        public IActionResult RoleChange()
        {
            return View();
        }
    }
}
