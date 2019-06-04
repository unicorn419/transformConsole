using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformLib
{
    public class StandParse:ParseFormatBasic
    {
        public override string Handle(string columName, string val)
        {
            return val;
        }
    }
}
