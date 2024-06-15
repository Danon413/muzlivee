using ShopWebsite.Client.Shared;
using System.Net.Http;
using System.Net.Security;
using System.Reflection;

namespace ShopWebsite.Client.Services.EmailService
{
    public static class EmailService
    {
        public static string GetHtmlForPdfExport(OrderDetailsResponse orderDetails)
        {
            string textBody = "";
            string bodyemail = @"<!DOCTYPE html>
<html>
<head>
</head>
<body style=""font-family: Helvetica,sans-serif;padding: 0;margin: 0;-webkit-font-smoothing: antialiased;color: #616161;"">
    <table class=""wrapper"" style=""margin: 0;background: #fff;border: 0;width: 100%;text-align: center;"">
        <tbody>
            <tr>
                <td class=""content-wrap"" style=""border: 0;width: 600px;text-align: center;background: #f5f5f5;"">
                    <table class=""content"" style=""margin: 0 auto;border: 0;width: 600px;text-align: center;"">
                        <tbody>
                            <tr>
                                <td class=""em-spacer-1"" style=""height: 26px; background: #fff""></td>
                            </tr>
                            <tr>
                                <td class=""box"" style=""background: #fff;padding: 0 25px;"">
                                    <table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"" style=""margin: 0 auto;"">
                                        <tbody>
                                            <tr>
                                                <td align=""center"">
                                                    <table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"" style=""margin: 0 auto;"">
                                                        <tbody>
                                                            <tr>
                                                                <td align=""center"">
                                                                    <h1 class=""hero-primary"" style=""text-transform: uppercase;font-size: 28px;color: #283375;margin-top: 9px;"">
                                                                        RECEIPT OF YOUR ORDER
                                                                    </h1>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td class=""order-link-wrap"" style=""text-align: center;font-size: 14px;"">
                                                                    <strong>
                                                                        <span class=""pipe""></span>
                                                                        Date ordered: {orderDate}
                                                                    </strong>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td class=""em-spacer-1"" style=""height: 26px;""></td>
                                                            </tr>
                                                            <tr>
                                                                <td class=""em-spacer-2"" style=""height: 52px;""></td>
                                                            </tr>
                                                        </tbody>
                                                    </table>
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td class=""box box-ext order-summary-box"" style=""background: #fff;padding: 0 25px;text-align: center;"">
                                    <table class=""two-col ledger"" style=""margin: 0 auto;font-size: 14px;line-height: 22px;width: 546px;text-align: left;"">
                                        <tbody>
                                            <tr>
                                                <td>
                                                    <table align=""left"" class=""column column-1"" style=""margin: 0 auto;width: 270px;"">
                                                        <tbody>
                                                            <tr>
                                                                <td>
                                                                    <strong class=""title"" style=""text-transform: uppercase;display: block;margin-bottom: 5px;"">
                                                                        Billing Address
                                                                    </strong>
                                                                    {firstName lastName}<br>
                                                                    {country city street}
                                                                    <br>
                                                                </td>
                                                            </tr>
                                                        </tbody>
                                                    </table>
                                                    <table align=""left"" class=""column column-2"" style=""margin: 0 auto;width: 270px;"">
                                                        <tbody>
                                                            <tr>
                                                                <td>
                                                                    <strong class=""title"" style=""text-transform: uppercase;display: block;margin-bottom: 5px;"">
                                                                        Shipping Address
                                                                    </strong>
                                                                    {firstName lastName}<br>
                                                                    {country city street}
                                                                    <br>
                                                                </td>
                                                            </tr>
                                                        </tbody>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class=""em-spacer-1"" style=""height: 26px;""></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                    <table class=""order-summary"" style=""margin: 0 auto;text-align: left;width: 546px;border-top: 2px solid #eee;"">
                                        <tbody>
                                            <tr>
                                                <td class=""em-spacer-0"" style=""height: 20px;""></td>
                                            </tr>
                                            {products}
                                            <tr>
                                                <td class=""em-spacer-0"" style=""height: 20px;""></td>
                                            </tr>
                                            <tr>
                                                <td class=""divider"" colspan=""3"" style=""border-bottom: 2px solid #eee;""></td>
                                            </tr>
                                            <tr>
                                                <td class=""em-spacer-1"" style=""height: 26px;""></td>
                                            </tr>
                                            <tr class=""total-row total"" style=""font-size: 14px;"">
                                                <td class=""copy"" colspan=""2"" style=""text-align: right;padding-top: 10px;"">
                                                    <strong>
                                                        Total
                                                    </strong>
                                                </td>
                                                <td class=""value"" style=""text-align: right;padding-top: 10px;"">
                                                    <strong>
                                                        €{totalPrice}
                                                    </strong>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class=""em-spacer-0"" style=""height: 20px;""></td>
                                            </tr>
                                            <tr>
                                                <td class=""divider"" colspan=""3"" style=""border-bottom: 2px solid #eee;""></td>
                                            </tr>
                                            <tr>
                                                <td class=""em-spacer-2"" style=""height: 52px;""></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td class=""em-spacer-1"" style=""height: 26px;""></td>
                            </tr>
                            <tr>
                                <td class=""em-spacer-1"" style=""height: 26px;""></td>
                            </tr>
                            <tr>
                                <td class=""box box-ext referral-box"" style=""background: #00237d;padding: 0 25px;text-align: center;color: #fff;font-family: Helvetica"">
                                    <table class=""referral-info"" style=""margin: 0 auto;"">
                                        <tbody>
                                            <tr>
                                                <td class=""em-spacer-1"" style=""height: 26px;text-align: center;""></td>
                                            </tr>
                                            <tr>
                                                <td class=""title"" style=""text-align: center;padding-bottom: 10px;font-weight: 700;text-transform: uppercase;font-size: 19px;"">
                                                    THANK YOU FOR SUPPORTING US!
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class=""info"" style=""text-align: center;"">
                                                    THANK YOU!
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class=""em-spacer-1"" style=""height: 26px;text-align: center;""></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td class=""em-spacer-1"" style=""height: 26px;""></td>
                            </tr>
                            <tr>
                                <td class=""em-spacer-1"" style=""height: 26px;""></td>
                            </tr>
                            <tr>
                                <td class=""em-spacer-1"" style=""height: 10px;""></td>
                            </tr>
                            <tr>
                                <td>
                                    <table style=""margin-top: 10px; margin: 0 auto;"">
                                        <tbody>
                                            <tr>
                                                <td class=""footer footer-1"" style=""color: #999;font-size: 13px;"">
                                                    +37122190360 <span class=""pipe"">&nbsp;|&nbsp;</span> misjao2005@gmail.com
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </td>
            </tr>
        </tbody>
    </table>
</body>
</html>
";

            foreach (var item in orderDetails.Products)
            {
                var text = @$"<tr class=""line-item"">
                              <td class=""line-item product-thumb-column"" style=""width: 80px;"">
                                <img alt=""Image"" height=""80"" width=""80"" src=""{item.ImageUrl}"" style=""width: 80px;height: 80px;"">
                                <div class=""row-spacer"" style=""height: 8px;""></div>
                              </td>
                              <td class=""line-item product-info-column"" style=""width: 200px;"">
                                <div class=""title"" style=""margin-bottom: 5px;"">
                            {item.Title}    </div>
                                <div class=""sub"" style=""font-size: 13px;margin-bottom: 3px;"">
                            {item.ProductType}    </div>
                                  <div class=""sub"" style=""font-size: 13px;margin-bottom: 3px;"">
                                    Qty: {item.Quantity}
                                  </div>
                              </td>
                              <td class=""line-item product-price-column"" style=""width: 100px;text-align: right;vertical-align: top;"">
                                <div style=""font-size: 13px;margin-bottom: 3px;margin-top: 18px;"">
                            €{item.TotalPrice}    </div>
                              </td>
                            </tr>";

                textBody += text;
                textBody += "";
            }

            bodyemail = bodyemail.Replace("{firstName lastName}", orderDetails.FullName);
            bodyemail = bodyemail.Replace("{orderDate}", orderDetails.OrderDate.ToShortDateString());
            bodyemail = bodyemail.Replace("{totalPrice}", orderDetails.TotalPrice.ToString());
            bodyemail = bodyemail.Replace("{country city street}", orderDetails.Address);
            bodyemail = bodyemail.Replace("{products}", textBody);

            return bodyemail;
        }

    }
}
