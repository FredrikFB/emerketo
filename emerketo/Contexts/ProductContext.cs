using emerketo.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace emerketo.Contexts
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<ProductImgEntity> ProductsImg { get; set; }
        public DbSet<ProductCategoryEntity> ProductCategories { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        
    }
}
