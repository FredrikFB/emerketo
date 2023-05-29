using emerketo.Helpers.Services;
using emerketo.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace emerketo.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductService _productService;

        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {

            var viewModel = new GridCollectionVewModel
            {
                GridItems = await _productService.GetAllProductsAsync()
            };
            return View(viewModel);
        }

        public async Task<IActionResult> Details(int id)
        {
            var product = await _productService.GetProductAsync(id);

            if (product == null)
            {
                return NotFound();
            }
            var viewModel = new ProductDetailViewModel
            {
                Id = product!.Id,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                ImgUrl = product.ImgUrl,

            };
            return View(viewModel);
        }
    }
}
