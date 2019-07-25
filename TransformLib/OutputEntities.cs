using System;
using System.Collections.Generic;
using System.Text;

namespace TransformLib
{
    public class OutputEntities:IEnumerable<OutputEntity>
    {
        public void ToCSV(string filePath)
        {
        }

        public void ToDB()
        {
        }

        public void ToJson()
        {
        }

        public void Add(OutputEntity oe)
        {
            _list.Add(oe);
        }

    }


}
