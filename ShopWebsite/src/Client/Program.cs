global using ShopWebsite.Shared.Models.Data;
global using ShopWebsite.Shared.Models.DataTransferObjects;
global using System.Net.Http.Json;
global using ShopWebsite.Client.Services.ProductService;
global using ShopWebsite.Client.Services.CategoryService;
global using ShopWebsite.Client.Services.CartService;
global using ShopWebsite.Client.Services.AuthService;
global using ShopWebsite.Client.Services.OrderService;
global using ShopWebsite.Client.Services.AddressService;
global using ShopWebsite.Client.Services.ProductTypeService;
global using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ShopWebsite.Client;
using ShopWebsite.Client.Utils.ServiceRegistration;
using Blazored.LocalStorage;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddShopWebsiteServices();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();

await builder.Build().RunAsync();
