namespace ShopWebsite.Server.Services.EmailService
{
    public interface IEmailService
    {
        string GetHtmlForEmailNotification(List<OrderItem> orderItems);

        Task SendEmailAsync(string emailTo, List<OrderItem> orderItems, Order order);
    }
}
