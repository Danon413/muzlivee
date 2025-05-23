namespace ShopWebsite.Client.Services.OrderService
{
    public interface IOrderService
    {
        Task<string> PlaceOrder(); // старый вариант
        Task<string> PlaceOrder(DateTime? bookingDate); // ← добавь этот
        Task<List<OrderOverviewResponse>> GetOrders();
        Task<OrderDetailsResponse> GetOrderDetails(int orderId);
    }
}
