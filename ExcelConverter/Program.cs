using System;
using System.Collections.Generic;
using System.Data;

namespace ExcelConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string csvPath = @"trytry.csv";
            CsvReaderClass reader = new CsvReaderClass(csvPath);
            Dictionary<int, string[]> csvContent = reader.readCsv();
            int featureNumber = UtilFunction.getFeaturesNumber(csvContent);
            //int featureNumber = 1;
            int row = 17;
            int featureCounter = 0;
            while (featureNumber > 0 && row <= csvContent.Count)
            {
                string[] temp = csvContent[row];
                if (temp[0].Equals("Grid profile:"))
                {
                    using DataTable dt = new DataTable("csvTable");
                    dt.Columns.Add("Longitudinal_position", typeof(String));
                    dt.Columns.Add("Circumferential_position", typeof(String));
                    dt.Columns.Add("Depth", typeof(Double));
                    dt.Columns["Longitudinal_position"].MaxLength = 10;//長度
                    dt.Columns["Longitudinal_position"].AllowDBNull = true;//不能空值
                    dt.Columns["Longitudinal_position"].Unique = false;//建立唯一性
                    dt.Columns["Circumferential_position"].MaxLength = 10;//長度
                    dt.Columns["Circumferential_position"].AllowDBNull = true;//不能空值
                    dt.Columns["Circumferential_position"].Unique = false;//建立唯一性
                    dt.Columns["Depth"].Unique = false;//建立唯一性
                    featureNumber--;
                    featureCounter++;
                    UtilFunction.getcsvData(csvContent, row, dt);
                    DataTable pivot = UtilFunction.ToPivot(dt,  dt.Columns["Circumferential_position"], dt.Columns["Depth"]);
                    UtilFunction.ToCSV(pivot, String.Format("output_{0}.csv", featureCounter));
                }
                row++;
            }
        }
    }
}
