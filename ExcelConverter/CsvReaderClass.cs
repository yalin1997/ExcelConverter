using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Text;
using CsvHelper;
using Microsoft.VisualBasic.FileIO;

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
            using (TextFieldParser parser = new TextFieldParser(csvPath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    //Processing row
                    string fields = parser.ReadLine();
                        //TODO: Process field
                    Console.WriteLine(fields);

                }
            }
        }
    }
}
