using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransformLib;

namespace ParseFormat2
{
    public class Parse2 : ParseFormatBasic
    {
        public override string Handle(string columName, string val)
        {
            if (string.IsNullOrEmpty(val)) return "";

            switch (columName)
            {

                case "Currency":
                    if (val == "C")
                        return "CAD";
                    if (val == "U")
                        return "USD";
                    return val;

                default:
                    return val;

            }
        }
    }
}
