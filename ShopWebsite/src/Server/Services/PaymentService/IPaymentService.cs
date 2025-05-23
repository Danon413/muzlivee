using Stripe.Checkout;

namespace ShopWebsite.Server.Services.PaymentService
{
    public interface IPaymentService
    {
        // Новый вариант — принимает дату бронирования
        Task<Session> CreateCheckoutSession(DateTime? bookingDate);
        Task<ServiceResponse<bool>> FulfillOrder(HttpRequest request);
    }
}
