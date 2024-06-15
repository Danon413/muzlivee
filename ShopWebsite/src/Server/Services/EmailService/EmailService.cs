using System.Net.Mail;
using System.Net;

namespace ShopWebsite.Server.Services.EmailService
{
    public class EmailService : IEmailService 
    {
        private readonly IConfiguration _configuration;
        private readonly IAuthService _authService;
        public EmailService(IConfiguration configuration, IAuthService authService)
        {
            _configuration = configuration;
            _authService = authService;
        }

        public string GetHtmlForEmailNotification(List<OrderItem> orderItems)
        {
            string textBody = string.Empty;

            foreach (var item in orderItems)
            {
                var text = @$"<tr class=""line-item"">
                              <td class=""line-item product-thumb-column"" style=""width: 80px;"">
                                <img alt=""Queen"" class=""product-thumb"" height=""80"" width=""80"" src=""{item.Product.ImageUrl}"" style=""width: 80px;height: 80px;"">
                                <div class=""row-spacer"" style=""height: 8px;""></div>
                              </td>
                              <td class=""line-item product-info-column"" style=""width: 200px;"">
                                <div class=""title"" style=""margin-bottom: 5px;"">
                            {item.Product.Title}    </div>
                                <div class=""sub"" style=""font-size: 13px;margin-bottom: 3px;"">
                            {item.ProductType.Name}    </div>
                                  <div class=""sub"" style=""font-size: 13px;margin-bottom: 3px;"">
                                    Qty: {item.Quantity}
                                  </div>
                              </td>
                              <td class=""line-item product-price-column"" style=""width: 100px;text-align: right;vertical-align: top;"">
                                <div style=""font-size: 13px;margin-bottom: 3px;margin-top: 18px;"">
                            €{item.TotalPrice}    </div>
                                  <div class=""ships-by-message"" style=""font-size: 13px;padding-top: 4px;"">
                                    <strong style=""font-weight: 400;"">
                            Ready to Ship        </strong>
                                  </div>
                              </td>
                            </tr>";

                textBody += text;
                textBody += "";
            }

            return textBody;
        }

        

        public async Task SendEmailAsync(string emailTo, List<OrderItem> orderItems, Order order)
        {
            var textBody = GetHtmlForEmailNotification(orderItems);

            var port = Convert.ToInt32(_configuration["EmailParameters:Port"]);
            var host = _configuration["EmailParameters:Host"];
            var emailFrom = _configuration["EmailParameters:Email"];
            var password = _configuration["EmailParameters:Password"];
            var enableSsl = Convert.ToBoolean(_configuration["EmailParameters:EnableSsl"]);
            var isBodyHtml = Convert.ToBoolean(_configuration["EmailParameters:IsBodyHtml"]);

            var bodyemail = File.ReadAllText("C:\\Musical_store\\ShopWebsite\\src\\Client\\Shared\\ReminderBody.razor");
            var fullName = await _authService.GetUserFullNameAsync(order.UserId);
            var orderDate = order.OrderDate.ToShortDateString();
            var totalPrice = order.TotalPrice.ToString();
            var userAddress = await _authService.GetUserAddress(order.UserId);

            bodyemail = bodyemail.Replace("{firstName lastName}", fullName);
            bodyemail = bodyemail.Replace("{orderDate}", orderDate);
            bodyemail = bodyemail.Replace("{totalPrice}", totalPrice);
            bodyemail = bodyemail.Replace("{country city street}", userAddress);
            bodyemail = bodyemail.Replace("{products}", textBody);

            var smtpClient = new SmtpClient(host)
            {
                Port = port,
                Credentials = new NetworkCredential(emailFrom, password),
                EnableSsl = enableSsl,
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress(emailFrom ?? ""),
                Subject = $"Thank you for your order!",
                Body = bodyemail,
                IsBodyHtml = isBodyHtml,
            };

            mailMessage.To.Add(emailTo);

            smtpClient.Send(mailMessage);
        }
    }
}
