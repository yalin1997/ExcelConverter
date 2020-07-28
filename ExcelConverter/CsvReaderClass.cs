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
        public Dictionary<int, string[]> readCsv()
        {
            Dictionary<int, string[]> rowDic = new Dictionary<int, string[]>();
            int rowCounter = 0;
            using (TextFieldParser parser = new TextFieldParser(csvPath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    //Processing row
                    string line = parser.ReadLine();
                    Console.WriteLine(line);
                    rowCounter++;
                    string[] lineArray = line.Split(',');
                    rowDic.Add(rowCounter, lineArray);
                }
            }
            return rowDic;
        }
    }
}
