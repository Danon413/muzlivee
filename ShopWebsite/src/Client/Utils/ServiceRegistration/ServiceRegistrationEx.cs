
namespace ShopWebsite.Client.Utils.ServiceRegistration
{
    public static class ServiceCollectionEx
    {
        public static IServiceCollection AddShopWebsiteServices(this IServiceCollection @this) =>
            @this
                .AddServices();

        private static IServiceCollection AddServices(this IServiceCollection @this) =>
            @this
                .AddScoped<IProductService, ProductService>()
                .AddScoped<ICategoryService, CategoryService>()
                .AddScoped<ICartService, CartService>()
                .AddScoped<IAuthService, AuthService>()
                .AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>()
                .AddScoped<IOrderService, OrderService>()
                .AddScoped<IAddressService, AddressService>()
                .AddScoped<IProductTypeService, ProductTypeService>();
    }
}
