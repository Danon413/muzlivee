using ShopWebsite.Shared.Models.DataTransferObjects;

namespace ShopWebsite.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action ProductsChanged;
        List<Product> Products { get; set; }
        List<Product> AdminProducts { get; set; }
        string Message { get; set; }
        int CurrentPage { get; set; }
        int PageCount { get; set; }
        string LastSearchText { get; set; }
        Task<ServiceResponse<Product>> GetProduct(int productId);
        Task GetProductsAsync(string? categoryUrl = null);
        Task SearchProducts(string searchString, int page);
        Task<List<string>> SearchSuggestions(string searchString);
        Task GetAdminProducts();
        Task<Product> CreateProduct(Product product);
        Task<Product> UpdateProduct(Product product);
        Task DeleteProduct(int productId);
    }
}
