using System.ComponentModel.DataAnnotations;

namespace emerketo.Models.Entities
{
    public class ProductImgEntity
    {
        [Key]
        public int ImgId { get; set; }
        public int ProductId { get; set; }
        public string ImageUrl { get; set; } = null!;

        public virtual ProductEntity Product { get; set; } = null!;
    }
}
