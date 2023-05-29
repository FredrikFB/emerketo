﻿namespace emerketo.Models.ViewModels
{
    public class ProductDetailViewModel
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; } 
        public decimal? Price { get; set; }
        public decimal? OldPrice { get; set; }
        public string? ImgUrl { get; set; }
    }
}
