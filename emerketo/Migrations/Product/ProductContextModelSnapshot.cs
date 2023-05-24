﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using emerketo.Contexts;

#nullable disable

namespace emerketo.Migrations.Product
{
    [DbContext(typeof(ProductContext))]
    partial class ProductContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("emerketo.Models.Entities.CategoryEntity", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "new"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "featured"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "popular"
                        });
                });

            modelBuilder.Entity("emerketo.Models.Entities.ProductCategoryEntity", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 1
                        });
                });

            modelBuilder.Entity("emerketo.Models.Entities.ProductEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("OldPrice")
                        .HasColumnType("money");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                            ImgUrl = "https://www.databyran.nu/bigimages/products/dator/msi_katana_15_b12vek-020neu_001.jpg",
                            Name = "MSI Katana",
                            Price = 20m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                            ImgUrl = "https://www.databyran.nu/bigimages/products/dator/msi_katana_15_b12vek-020neu_001.jpg",
                            Name = "Acer Aspire",
                            Price = 20m
                        },
                        new
                        {
                            Id = 3,
                            Description = "Consequat nisl vel pretium lectus quam id. Donec pretium vulputate sapien nec. Felis eget velit aliquet sagittis id consectetur purus.",
                            ImgUrl = "https://www.databyran.nu/bigimages/products/dator/msi_katana_15_b12vek-020neu_001.jpg",
                            Name = "Lenovo IdeaPad",
                            Price = 20m
                        },
                        new
                        {
                            Id = 4,
                            Description = "Ut venenatis tellus in metus vulputate",
                            ImgUrl = "https://www.databyran.nu/bigimages/products/dator/msi_katana_15_b12vek-020neu_001.jpg",
                            Name = "Corsair Voyager ",
                            Price = 20m
                        },
                        new
                        {
                            Id = 5,
                            Description = "et sollicitudin ac orci phasellus",
                            ImgUrl = "https://www.databyran.nu/bigimages/products/dator/msi_katana_15_b12vek-020neu_001.jpg",
                            Name = "ASUS ROG Flow ",
                            Price = 20m
                        },
                        new
                        {
                            Id = 6,
                            Description = "sed vulputate mi sit amet",
                            ImgUrl = "https://www.databyran.nu/bigimages/products/dator/msi_katana_15_b12vek-020neu_001.jpg",
                            Name = "ASUS TUF A16 ",
                            Price = 20m
                        },
                        new
                        {
                            Id = 7,
                            Description = "quisque egestas diam in arcu",
                            ImgUrl = "https://www.databyran.nu/bigimages/products/dator/msi_katana_15_b12vek-020neu_001.jpg",
                            Name = "MSI Katana",
                            Price = 20m
                        },
                        new
                        {
                            Id = 8,
                            Description = "amet mattis vulputate enim nulla",
                            ImgUrl = "https://www.databyran.nu/bigimages/products/dator/msi_katana_15_b12vek-020neu_001.jpg",
                            Name = "MSI Katana",
                            Price = 20m
                        },
                        new
                        {
                            Id = 9,
                            Description = "orci phasellus egestas tellus rutrum",
                            ImgUrl = "https://www.databyran.nu/bigimages/products/dator/msi_katana_15_b12vek-020neu_001.jpg",
                            Name = "MSI Katana",
                            Price = 20m
                        });
                });

            modelBuilder.Entity("emerketo.Models.Entities.ProductImgEntity", b =>
                {
                    b.Property<int>("ImgId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImgId"));

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("ImgId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductsImg");
                });

            modelBuilder.Entity("emerketo.Models.Entities.ProductCategoryEntity", b =>
                {
                    b.HasOne("emerketo.Models.Entities.CategoryEntity", "Category")
                        .WithMany("Categories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("emerketo.Models.Entities.ProductEntity", "Product")
                        .WithMany("Categories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("emerketo.Models.Entities.ProductImgEntity", b =>
                {
                    b.HasOne("emerketo.Models.Entities.ProductEntity", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("emerketo.Models.Entities.CategoryEntity", b =>
                {
                    b.Navigation("Categories");
                });

            modelBuilder.Entity("emerketo.Models.Entities.ProductEntity", b =>
                {
                    b.Navigation("Categories");

                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
