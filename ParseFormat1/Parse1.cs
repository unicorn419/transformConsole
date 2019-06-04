using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransformLib;

namespace ParseFormat1
{
    public class Parse1:ParseFormatBasic        

    {

        public override string Handle(string columName, string val)
        {
            if (string.IsNullOrEmpty(val)) return "";

            switch (columName)
            {
                case "Identifier":
                    string[] tmp = val.Split('|');
                    if (tmp.Length == 2)
                    {
                        return tmp[1];
                    }
                    else
                    {
                        return val;
                    }
                    
                case "Currency":
                    if (val == "CD")
                        return "CAD";
                    if (val == "US")
                        return "USD";
                    return val;
                case "Type":
                    if (val == "1")
                        return "Trading";
                    if (val == "2")
                        return "RRSP";
                    if (val == "3")
                        return "RESP";
                    if (val == "4")
                        return "Fund";
                    return val;
                case "Opened":
                    DateTime dt = DateTime.Parse(val);
                    return dt.ToString("yyyy-mm-dd");
                default:
                    return val;


            }
        }
    }
}
