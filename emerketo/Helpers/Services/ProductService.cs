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

    public async Task<bool> CreateCategoriesAsync()
    {
        if (!_context.Categories.Any()) 
        {
            var newCategory = new CategoryEntity { CategoryName = "new" };
            _context.Categories.Add(newCategory);

            var popularCategory = new CategoryEntity { CategoryName = "popular" };
            _context.Categories.Add(popularCategory);

            var featuredCategory = new CategoryEntity { CategoryName = "featured" };
            _context.Categories.Add(featuredCategory);

            await _context.SaveChangesAsync();

            return true;
        }
        else { return false; }

    }

}
