using System;
using System.Collections.Generic;
using System.Text;

namespace ExcelConverter
{
    class UtilFunction
    {
        public static int getFeaturesNumber(Dictionary<int , string[] > csvCotent)
        {
            string[] eighthRow = csvCotent[8];
            return Int32.Parse(eighthRow[0]);
        }
    }
}
