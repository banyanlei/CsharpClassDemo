using System;
using System.IO;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel; // 适用于 .xlsx
using QRCoder;
using System.Drawing;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string excelPath = @"C:\Temp\QR_codeTest\serials.xlsx"; // Excel 文件路径
        string outputDir = @"C:\Temp\QR_codeTest\OutputQRCodes";     // 二维码输出目录

        if (!Directory.Exists(outputDir))
            Directory.CreateDirectory(outputDir);

        using (FileStream fs = new FileStream(excelPath, FileMode.Open, FileAccess.Read))
        {
            IWorkbook workbook = new XSSFWorkbook(fs);
            ISheet sheet = workbook.GetSheetAt(0); // 读取第一个sheet

            for (int i = 0; i <= sheet.LastRowNum; i++)
            {
                IRow row = sheet.GetRow(i);
                if (row == null) continue;
                var cell = row.GetCell(0); // A列
                if (cell == null) continue;
                string serial = cell.ToString().Trim();
                if (string.IsNullOrEmpty(serial)) continue;

                // 生成二维码
                using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
                using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(serial, QRCodeGenerator.ECCLevel.Q))
                using (QRCode qrCode = new QRCode(qrCodeData))
                using (Bitmap qrCodeImage = qrCode.GetGraphic(20))
                {
                    string filePath = Path.Combine(outputDir, $"{serial}.png");
                    qrCodeImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
                    Console.WriteLine($"生成二维码: {filePath}");
                }
            }
        }
        Console.WriteLine("全部二维码已生成。");
    }
}
