using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransformLib;

namespace transformConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            ///example format1
            InputEntities ie1 = InputEntities.ReadCSV("inputformat1.csv");
            ParseFormatBasic pfb1= TransformFactory.GetParse(ie1.Format);
            OutputEntities oe1 = pfb1.Convert(ie1);
            oe1.ToDB();
            oe1.ToCSV(@"outputFormat1.csv");


            //example format2
            InputEntities ie2 = InputEntities.ReadCSV("inputformat2.csv");
            ParseFormatBasic pfb2 = TransformFactory.GetParse(ie2.Format);
            OutputEntities oe2 = pfb2.Convert(ie2);
            oe2.ToDB();
            oe2.ToCSV(@"outputFormat2.csv");
            
            Console.WriteLine();
        }
    }
}
