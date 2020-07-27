using System;

namespace ExcelConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string csvPath = @"trytry.csv";
            CsvReaderClass reader = new CsvReaderClass(csvPath);
            reader.readCsv();
        }
    }
}
