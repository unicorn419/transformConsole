using System;
using System.Collections.Generic;
using System.Text;

namespace TransformLib
{

    
    public  class OutputEntity
    {
        public string AccountCode { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public string Open_Date { get; set; }

        public string Currency { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string format = "{0},{1},{2},{3},{4}";

            return string.Format(format, AccountCode, Name, Type, Open_Date, Currency);
        }

        public static string HeadLine
        {
            get
           {
                return "AccountCode,Name,Type,Open Date,Currency";
            }
        }

    }
}
