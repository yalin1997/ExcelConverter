using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Text;
using CsvHelper;

namespace ExcelConverter
{
    class CsvReaderClass
    {
        string csvPath { get; set; }

        public CsvReaderClass(string path)
        {
            this.csvPath = path;
        }
        public void readCsv()
        {
            using (var reader = new StreamReader(csvPath))
            {
                using (var csv = new CsvReader(reader , CultureInfo.InvariantCulture))
                {
                    for (int i = 0; i < 7; i++)
                    {
                        csv.Read();
                        Console.WriteLine(csv.Context);
                    }
                }
            }
        }
    }
}
