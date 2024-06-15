using OfficeOpenXml;
using System.Reflection.Metadata;

namespace ShopWebsite.Client.Services.ExcelService
{
    public class ExportService
    {
        public ExportService()
        {
        }
        public static MemoryStream GeneratePdf(OrderDetailsResponse order)
        {
            if (order == null)
                throw new ArgumentNullException("Data can't be null.");

            var html = EmailService.EmailService.GetHtmlForPdfExport(order);

            //var pdf = htmlConverter.GeneratePdf(html);

            using (MemoryStream stream = new MemoryStream())
            {
                //pdf.Save($"Order_{order.OrderDate}");
                return stream;
            }
        }

        public static byte[] GenerateExcelWorkbook(List<OrderOverviewResponse> orders)
        {
            var stream = new MemoryStream();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage(stream))
            {
                var workSheet = package.Workbook.Worksheets.Add("Orders");

                // simple way
                workSheet.Cells.LoadFromCollection(orders, true);

                ////// mutual
                ////workSheet.Row(1).Height = 20;
                ////workSheet.Row(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                ////workSheet.Row(1).Style.Font.Bold = true;
                ////workSheet.Cells[1, 1].Value = "No";
                ////workSheet.Cells[1, 2].Value = "Name";
                ////workSheet.Cells[1, 3].Value = "Age";

                ////int recordIndex = 2;
                ////foreach (var item in list)
                ////{
                ////    workSheet.Cells[recordIndex, 1].Value = (recordIndex - 1).ToString();
                ////    workSheet.Cells[recordIndex, 2].Value = item.UserName;
                ////    workSheet.Cells[recordIndex, 3].Value = item.Age;
                ////    recordIndex++;
                ////}

                return package.GetAsByteArray();
            }
        }

        public static byte[] GenerateExcelWorkbook(OrderDetailsResponse order)
        {
            var stream = new MemoryStream();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage(stream))
            {
                var workSheet = package.Workbook.Worksheets.Add("Orders");

                List<OrderDetailsResponse> orders = new List<OrderDetailsResponse>();
                orders.Add(order);
                // simple way
                workSheet.Cells.LoadFromCollection(orders, true);

                ////// mutual
                ////workSheet.Row(1).Height = 20;
                ////workSheet.Row(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                ////workSheet.Row(1).Style.Font.Bold = true;
                ////workSheet.Cells[1, 1].Value = "No";
                ////workSheet.Cells[1, 2].Value = "Name";
                ////workSheet.Cells[1, 3].Value = "Age";

                ////int recordIndex = 2;
                ////foreach (var item in list)
                ////{
                ////    workSheet.Cells[recordIndex, 1].Value = (recordIndex - 1).ToString();
                ////    workSheet.Cells[recordIndex, 2].Value = item.UserName;
                ////    workSheet.Cells[recordIndex, 3].Value = item.Age;
                ////    recordIndex++;
                ////}

                return package.GetAsByteArray();
            }
        }
    }
}
