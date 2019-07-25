using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransformLib;
using System.IO;

namespace transformConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            ///example format1
            ///            
            IEnumerable<string[]> ie1 = File.ReadLines("File1.csv").Select(x => x.Split(',')).Skip(1);
            ParseFormatBasic pfb1= TransformFactory.GetParse("Format1");
            List<OutputEntity> oe1 = pfb1.Convert("Format1",ie1);

            Console.WriteLine("Process example 1");
            Console.WriteLine(OutputEntity.HeadLine);
            foreach (OutputEntity o in oe1)
            {
                Console.WriteLine(o.ToString());
            }


            Console.WriteLine();
            Console.WriteLine("Process example 2");

            IEnumerable<string[]> ie2 = File.ReadLines("File2.csv").Select(x => x.Split(','));
            ParseFormatBasic pfb2 = TransformFactory.GetParse("Format2");
            List<OutputEntity> oe2 = pfb2.Convert("Format2", ie2);

            Console.WriteLine(OutputEntity.HeadLine);
            foreach (OutputEntity o in oe2)
            {
                Console.WriteLine(o.ToString());
            }


            Console.ReadLine();
        }
    }
}
