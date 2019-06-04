using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TransformLib
{
    public class InputEntities
    {
        public List<string> Colums = new List<string>();
        public List<List<string >> Data = new List<List<string>>();
        public string Format;

        public static InputEntities ReadCSV(string csvFilePath)
        {
            ///todo init the Colums list,if not exist the column ，read from transConfig.xml sourceName field ASC
            ///todo fill the data List,each row is one list<string>
            ///todo init the format type
            ///

            return new InputEntities();
        }
    }
}
