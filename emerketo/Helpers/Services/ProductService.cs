using emerketo.Contexts;
using emerketo.Models.Entities;
using emerketo.Models.Identity;
using emerketo.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace emerketo.Helpers.Services;

public class ProductService
{
    private readonly ProductContext _context;

    public ProductService(ProductContext context)
    {
        _context = context;
    }

    public async Task<bool> CreateAsync(ProductRegistrationViewModel viewModel)
    {
        try
        {
            ProductEntity productEntity = viewModel;
            
            _context.Products.Add(productEntity);
            await _context.SaveChangesAsync();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<IEnumerable<CategoryEntity>> GetCategoryAsync()
    {
        var categories = await _context.Categories.ToListAsync();
        return categories;
    }
    public async Task<IEnumerable<GridCollectionItemViewModel>> GetAllProductsAsync()
    {
        var products = await _context.Products.ToListAsync();

        return products.Select(product => (GridCollectionItemViewModel)product);
    }

    public async Task<ProductEntity?> GetProductAsync(int id)
    {
        return await _context.Products.FindAsync(id);
    }

    public async Task<IEnumerable<ProductEntity>> GetNumberOfProductAsync(int value)
    {
        return await _context.Products.Take(value).ToListAsync();
    }

    public async Task<IEnumerable<GridCollectionItemViewModel>> GetNumberOfProductsAsync(int value)
    {
        var products = await _context.Products
            .Take(value)
            .ToListAsync();

        return products.Select(product => (GridCollectionItemViewModel)product);
    }

}
