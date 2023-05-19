using System.ComponentModel.DataAnnotations;

namespace emerketo.Models.Entities
{
    public class CategoryEntity
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;

        public ICollection<ProductCategoryEntity> Categories { get; set; } = new HashSet<ProductCategoryEntity>();
    }
}
