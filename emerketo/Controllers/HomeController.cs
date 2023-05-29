using emerketo.Helpers.Services;
using emerketo.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace emerketo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductService _productService;

        public HomeController(ProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var gridItem = await _productService.GetNumberOfProductsAsync(8);
            var viewModel = new HomeIndexViewModel
            {
                BestCollection = new GridCollectionVewModel
                {

                    Title = "Best Collection",
                    Categories = new List<string> { "All", "Bags", "Dress", "Decoration", "Essentials", "Interior", "Laptop", "Mobile", "Beauty" },
                    GridItems = await _productService.GetNumberOfProductsAsync(8)

                },

                TopSelling = new TopSellingViewModel
                {
                    Title = "Top Selling products in this week",
                    GridItems = await _productService.GetNumberOfProductsAsync(6)
                }

            };

            return View(viewModel);
        }
    }
}
