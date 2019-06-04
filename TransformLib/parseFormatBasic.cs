using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace TransformLib
{
    public abstract class ParseFormatBasic
    {
        public  OutputEntities  Convert(InputEntities ie)
        {
            OutputEntities oes = new OutputEntities();
            Type type = Type.GetType("OutputEntity");

            foreach (List<string> row in ie.Data)
            {
                OutputEntity oe = new OutputEntity();
                int i = 0;
                foreach (string colName in ie.Colums)
                {
                    string val = row[i];
                    string destName;
                    int index;
                    bool isneedProcess;
                    TransformFactory.getFieldProcessInfo(ie.Format, colName, out destName, out index, out isneedProcess);
                    if (isneedProcess)
                        val = Handle(colName, row[i]);
                    type.GetField(destName).SetValue(oe, val);

                    index++;

                }
                oes.Add(oe);
            }

            return oes;
        }

        public abstract string Handle(string columName, string val);
        
    }

    
}
