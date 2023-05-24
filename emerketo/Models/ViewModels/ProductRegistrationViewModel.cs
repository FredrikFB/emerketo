using emerketo.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace emerketo.Models.ViewModels;

public class ProductRegistrationViewModel
{
    [Required(ErrorMessage = "Måste ange ett namn på produkten")]
    [Display(Name = "Produktnamn")]
    public string Name { get; set; } = null!;

    [Display(Name = "Produktbeskrivning (valfritt)")]
    public string? Description { get; set; }

    [Required(ErrorMessage = "Du måste ange en kategori")]
    [Display(Name = "Kategori")]
    public List<int> Categories { get; set; } = new List<int>();

    [Required(ErrorMessage = "Du måste ange ett pris")]
    [Display(Name = "Productpris")]
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }

    [Display(Name = "Productpris")]
    [DataType(DataType.Currency)]
    public decimal? OldPrice { get; set; }

    public string ImgUrl { get; set; } = null!;

    public static implicit operator ProductEntity(ProductRegistrationViewModel viewModel)
    {
        return new ProductEntity
        {
            Name = viewModel.Name,
            Description = viewModel.Description,
            Price = viewModel.Price,
            OldPrice = viewModel.OldPrice,
            ImgUrl = viewModel.ImgUrl,

            Categories = viewModel.Categories.Select(categoryId => new ProductCategoryEntity
            {
                CategoryId = categoryId
            }).ToList()
        };
    }
}
