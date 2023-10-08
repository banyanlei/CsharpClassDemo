using System;

class Program
{
    static void Main()
    {
        string progID = "Excel.Application.16"; // ProgID for Microsoft Excel
        Type excelType = Type.GetTypeFromProgID(progID, throwOnError: false);

        if (excelType != null)
        {
            Console.WriteLine("Found the Excel type: " + excelType.FullName);
            // You can now work with the Excel type here
        }
        else
        {
            Console.WriteLine("Excel type not found or an error occurred.");
        }
    }
}
