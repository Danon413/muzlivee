using OfficeOpenXml;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;

namespace ShopWebsite.Client.Services.ExcelService
{
    public class ExportService
    {
        public static MemoryStream GeneratePdf(List<OrderOverviewResponse> orderOverviews)
        {
            if (orderOverviews == null)
                throw new ArgumentNullException("Data can't be null.");

            using (PdfDocument pdfDocument = new PdfDocument())
            {
                int paragraphAfterSpacing = 8;
                int cellMargin = 8;

                PdfPage page = pdfDocument.Pages.Add();

                PdfStandardFont font = new PdfStandardFont(PdfFontFamily.TimesRoman, 16);

                PdfTextElement title = new PdfTextElement("Orders", font, PdfBrushes.Black);
                PdfLayoutResult result = title.Draw(page, new Syncfusion.Drawing.PointF(0, 0));

                PdfStandardFont contentFont = new PdfStandardFont(PdfFontFamily.TimesRoman, 12);
                PdfLayoutFormat format = new PdfLayoutFormat();
                format.Layout = PdfLayoutType.Paginate;

                PdfGrid pdfGrid = new PdfGrid();
                pdfGrid.Style.CellPadding.Left = cellMargin;
                pdfGrid.Style.CellPadding.Right = cellMargin;

                pdfGrid.ApplyBuiltinStyle(PdfGridBuiltinStyle.GridTable4Accent1);

                pdfGrid.DataSource = orderOverviews.ToList();

                pdfGrid.Style.Font = contentFont;

                pdfGrid.Draw(page, new Syncfusion.Drawing.PointF(0, result.Bounds.Bottom + paragraphAfterSpacing));

                using (MemoryStream stream = new MemoryStream())
                {
                    pdfDocument.Save(stream);
                    pdfDocument.Close(true);
                    return stream;
                }

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
