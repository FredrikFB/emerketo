namespace emerketo.Models.ViewModels;

public class HomeIndexViewModel
{
    public string Title { get; set; } = "Home";
    public GridCollectionVewModel BestCollection { get; set; } = null!;
    public TopSellingViewModel TopSelling { get; set; } = null!;
}
