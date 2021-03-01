using OfficeOpenXml;
using OfficeOpenXml.Style;
using OfficeOpenXml.Table;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace TradingProjectWF
{
    public static class Excel
    {
        public static byte[] CreateExcelFile(List<Data> list, Stream stream = null)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            //using (var excelPackage = new ExcelPackage(stream ?? new MemoryStream()))
            //{
            //    // Tạo author cho file Excel
            //    excelPackage.Workbook.Properties.Author = "Hanker";
            //    // Tạo title cho file Excel
            //    excelPackage.Workbook.Properties.Title = "EPP test background";
            //    // thêm tí comments vào làm màu 
            //    excelPackage.Workbook.Properties.Comments = "This is my fucking generated Comments";
            //    // Add Sheet vào file Excel
            //    excelPackage.Workbook.Worksheets.Add("First Sheet");
            //    // Lấy Sheet bạn vừa mới tạo ra để thao tác 
            //    var workSheet = excelPackage.Workbook.Worksheets.Add("Sheet1");


            //    // Đổ data vào Excel file
            //    //workSheet.Cells[1, 1].LoadFromCollection(list, true, TableStyles.Dark9);
            //    // BindingFormatForExcel(workSheet, list);
            //    excelPackage.Save();
            //    return excelPackage.Stream;
            //}
            ExcelPackage excelPackage = new ExcelPackage();
            // Tạo author cho file Excel
            excelPackage.Workbook.Properties.Author = "Hanker";
            // Tạo title cho file Excel
            excelPackage.Workbook.Properties.Title = "EPP test background";
            // thêm tí comments vào làm màu 
            excelPackage.Workbook.Properties.Comments = "This is my fucking generated Comments";
            // Add Sheet vào file Excel
            //excelPackage.Workbook.Worksheets.Add("First Sheet");
            // Lấy Sheet bạn vừa mới tạo ra để thao tác 
            var workSheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

            workSheet.Cells[1, 1].Value = "Thời gian";
            workSheet.Cells[1, 2].Value = "Khối lượng";
            workSheet.Cells[1, 3].Value = "Giá";
            workSheet.Cells[1, 4].Value = "+/-";

            workSheet.Column(1).Width = 15;
            workSheet.Column(2).Width = 15;
            workSheet.Column(3).Width = 20;
            workSheet.Column(4).Width = 10;

            workSheet.Column(3).Style.Numberformat.Format = "0.0";
            workSheet.Column(4).Style.Numberformat.Format = "0.0";

            var index = 2;
            foreach (var item in list)
            {
                //item.timeDisplay = item.time.GetDateTimeFormats()[112].ToString();
                //item.timeDisplay = item.time.GetDateTimeFormats()[112].ToString();
                item.timeDisplay = item.time.ToString("HH:mm:ss");
                workSheet.Cells[index, 1].Value = item.timeDisplay;
                workSheet.Cells[index, 2].Value = item.lastVol;
                workSheet.Cells[index, 3].Value = item.lastPrice;
                workSheet.Cells[index, 4].Value = item.change;
                index++;
            }

            // Đổ data vào Excel file
            //workSheet.Cells[1, 1].LoadFromCollection(list, true, TableStyles.Dark9);
            // BindingFormatForExcel(workSheet, list);
            excelPackage.Save();

            return excelPackage.GetAsByteArray();
        }

    }
}
