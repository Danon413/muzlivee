using ShopWebsite.Shared.Models.Data;

namespace ShopWebsite.Shared.Models.DataTransferObjects
{
    public class ProductSearchResult
    {
        public List<Product> Products { get; set; } = new();
        public int Pages { get; set; }
        public int CurrentPage { get; set; }
    }
}
