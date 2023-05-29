using emerketo.Models.Entities;

namespace emerketo.Models.ViewModels;

public class GridCollectionItemViewModel
{
    public int Id { get; set; } 
    public string ImageUrl { get; set; } = null!;
    public string Title { get; set; } = null!;
    public decimal Price { get; set; }

    public static implicit operator GridCollectionItemViewModel(ProductEntity product)
    {
        return new GridCollectionItemViewModel
        {
            Id = product.Id,
            ImageUrl = product.ImgUrl,
            Title = product.Name,
            Price = product.Price,
        };
    }
}
