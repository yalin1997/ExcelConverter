using System;
using System.Collections.Generic;

namespace ExcelConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string csvPath = @"trytry.csv";
            CsvReaderClass reader = new CsvReaderClass(csvPath);
            Dictionary<int, string[]> csvContent = reader.readCsv();
            
        }
    }
}
