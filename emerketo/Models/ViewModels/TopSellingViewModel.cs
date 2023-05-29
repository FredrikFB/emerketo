namespace emerketo.Models.ViewModels;

public class TopSellingViewModel
{
    public string Title { get; set; } = null!;
    public IEnumerable<GridCollectionItemViewModel> GridItems { get; set; } = null!;
}
