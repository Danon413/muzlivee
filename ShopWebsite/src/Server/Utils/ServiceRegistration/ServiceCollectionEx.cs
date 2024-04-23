
namespace ShopWebsite.Server.Utils.ServiceRegistration
{
    public static class ServiceCollectionEx
    {
        public static IServiceCollection AddShopWebsiteServices(this IServiceCollection @this) =>
            @this
                .AddServices();

        private static IServiceCollection AddServices(this IServiceCollection @this) =>
            @this
                .AddScoped<IProductService, ProductService>()
                .AddScoped<IAuthService, AuthService>()
                .AddScoped<ICategoryService, CategoryService>()
                .AddScoped<ICartService, CartService>()
                .AddScoped<IOrderService, OrderService>()
                .AddScoped<IPaymentService, PaymentService>()
                .AddScoped<IAddressService, AddressService>()
                .AddScoped<IProductTypeService, ProductTypeService>();
    }
}
