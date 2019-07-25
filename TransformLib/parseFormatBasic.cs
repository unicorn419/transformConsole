using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace TransformLib
{
    public abstract class ParseFormatBasic
    {
        public  List<OutputEntity>  Convert(string format, IEnumerable<string[]> ie)
        {
            List<OutputEntity> oes = new List<OutputEntity>() ;
          
            foreach (string[] row in ie)
            {
                OutputEntity oe = new OutputEntity();
                Type type = oe.GetType();
                for (int i=0; i < row.Length;i++)
                {
                    string val = row[i];
                    string destName;
                    bool isneedProcess;
                    TransformFactory.getFieldProcessInfo(format, i, out destName, out isneedProcess);
                    if (isneedProcess)
                        val = Handle(destName, row[i]);
                    
                    type.GetProperty(destName).SetValue(oe,val);

                }
                oes.Add(oe);
            }

            return oes;
        }

        public abstract string Handle(string columName, string val);
        
    }

    
}
