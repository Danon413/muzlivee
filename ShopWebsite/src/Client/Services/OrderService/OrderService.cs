using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace ShopWebsite.Client.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly HttpClient _http;
        private readonly AuthenticationStateProvider _authStateProvider;
        private readonly NavigationManager _navigationManager;

        public OrderService(HttpClient http, AuthenticationStateProvider authStateProvider, NavigationManager navigationManager)
        {
            _http = http;
            _authStateProvider = authStateProvider;
            _navigationManager = navigationManager;
        }
        public async Task<OrderDetailsResponse> GetOrderDetails(int orderId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<OrderDetailsResponse>>($"api/order/{orderId}");
            return result.Data;
        }

        public async Task<List<OrderOverviewResponse>> GetOrders()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<OrderOverviewResponse>>>("api/order");
            return result.Data;
        }

        // Новый метод для передачи даты бронирования
        public async Task<string> PlaceOrder(DateTime? bookingDate)
        {
            if (await IsUserAuthenticated())
            {
                var request = new OrderBookingRequest
                {
                    BookingDate = bookingDate
                };
                var result = await _http.PostAsJsonAsync("api/payment/checkout", request);
                var url = await result.Content.ReadAsStringAsync();
                return url;
            }
            else
            {
                return "login";
            }
        }

        // Старый вариант для совместимости (можно удалить, если не нужен)
        public async Task<string> PlaceOrder()
        {
            if (await IsUserAuthenticated())
            {
                var result = await _http.PostAsync("api/payment/checkout", null);
                var url = await result.Content.ReadAsStringAsync();
                return url;
            }
            else
            {
                return "login";
            }
        }

        private async Task<bool> IsUserAuthenticated()
        {
            return (await _authStateProvider.GetAuthenticationStateAsync()).User.Identity.IsAuthenticated;
        }
    }

    // Класс для тела запроса с датой бронирования
    public class OrderBookingRequest
    {
        public DateTime? BookingDate { get; set; }
    }
}
