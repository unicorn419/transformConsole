using System;
using System.Collections.Generic;
using System.Text;

namespace TransformLib
{
    public class OutputEntities
    {
        List<OutputEntity> _list = new List<OutputEntity>(); 
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
