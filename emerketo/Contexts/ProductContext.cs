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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId = 1, CategoryName = "new" },
                new CategoryEntity { CategoryId = 2, CategoryName = "featured" },
                new CategoryEntity { CategoryId = 3, CategoryName = "popular" }
                );

            modelBuilder.Entity<ProductEntity>().HasData(
                new ProductEntity { Id = 1, Name = "MSI Katana", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price = 20 , ImgUrl = "https://www.databyran.nu/bigimages/products/dator/msi_katana_15_b12vek-020neu_001.jpg" },
                new ProductEntity { Id = 2, Name = "Acer Aspire", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", Price = 20 , ImgUrl = "https://www.databyran.nu/bigimages/products/dator/msi_katana_15_b12vek-020neu_001.jpg" },
                new ProductEntity { Id = 3, Name = "Lenovo IdeaPad", Description = "Consequat nisl vel pretium lectus quam id. Donec pretium vulputate sapien nec. Felis eget velit aliquet sagittis id consectetur purus.", Price = 20 , ImgUrl = "https://www.databyran.nu/bigimages/products/dator/msi_katana_15_b12vek-020neu_001.jpg" },
                new ProductEntity { Id = 4, Name = "Corsair Voyager ", Description = "Ut venenatis tellus in metus vulputate", Price = 20 , ImgUrl = "https://www.databyran.nu/bigimages/products/dator/msi_katana_15_b12vek-020neu_001.jpg" },
                new ProductEntity { Id = 5, Name = "ASUS ROG Flow ", Description = "et sollicitudin ac orci phasellus", Price = 20 , ImgUrl = "https://www.databyran.nu/bigimages/products/dator/msi_katana_15_b12vek-020neu_001.jpg" },
                new ProductEntity { Id = 6, Name = "ASUS TUF A16 ", Description = "sed vulputate mi sit amet", Price = 20 , ImgUrl = "https://www.databyran.nu/bigimages/products/dator/msi_katana_15_b12vek-020neu_001.jpg" },
                new ProductEntity { Id = 7, Name = "MSI Katana", Description = "quisque egestas diam in arcu", Price = 20 , ImgUrl = "https://www.databyran.nu/bigimages/products/dator/msi_katana_15_b12vek-020neu_001.jpg" },
                new ProductEntity { Id = 8, Name = "MSI Katana", Description = "amet mattis vulputate enim nulla", Price = 20 , ImgUrl = "https://www.databyran.nu/bigimages/products/dator/msi_katana_15_b12vek-020neu_001.jpg" },
                new ProductEntity { Id = 9, Name = "MSI Katana", Description = "orci phasellus egestas tellus rutrum", Price = 20 , ImgUrl = "https://www.databyran.nu/bigimages/products/dator/msi_katana_15_b12vek-020neu_001.jpg" }
                );

            modelBuilder.Entity<ProductCategoryEntity>().HasData(
                new ProductCategoryEntity { ProductId = 1, CategoryId = 1 },
                new ProductCategoryEntity { ProductId = 2, CategoryId = 1 },
                new ProductCategoryEntity { ProductId = 3, CategoryId = 1 },
                new ProductCategoryEntity { ProductId = 4, CategoryId = 1 },
                new ProductCategoryEntity { ProductId = 5, CategoryId = 1 },
                new ProductCategoryEntity { ProductId = 6, CategoryId = 1 },
                new ProductCategoryEntity { ProductId = 7, CategoryId = 1 },
                new ProductCategoryEntity { ProductId = 7, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 8, CategoryId = 1 },
                new ProductCategoryEntity { ProductId = 9, CategoryId = 2 },
                new ProductCategoryEntity { ProductId = 9, CategoryId = 1 }
                );
        }
    }
}
