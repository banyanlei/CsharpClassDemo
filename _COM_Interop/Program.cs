using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelGenerationExample
{
    class Program
    {
        static void Main()
        {
            // 创建一个新的 Excel 应用程序
            Excel.Application excelApp = new Excel.Application();

            // 添加一个工作簿
            Excel.Workbook workbook = excelApp.Workbooks.Add();

            // 添加一个工作表
            //Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.ActiveSheet;

            // 向单元格写入数据
            worksheet.Cells[1, 1] = "姓名";
            worksheet.Cells[1, 2] = "年龄";
            worksheet.Cells[2, 1] = "John Doe";
            worksheet.Cells[2, 2] = 30;

            // 保存工作簿
            workbook.SaveAs(@"C:\Path\To\Your\Excel\File.xlsx");

            // 关闭 Excel 应用程序
            excelApp.Quit();

            // 释放 COM 对象
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
        }
    }
}
