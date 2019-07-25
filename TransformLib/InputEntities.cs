using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace TransformLib
{
    public class InputEntities
    {
        public List<string> Colums = new List<string>();
        public List<List<string >> Data = new List<List<string>>();
        public string Format;

        public static IEnumerable<string[]> ReadCSV(string csvFilePath,bool isHaveHead)
        {
            var lines = File.ReadAllLines(csvFilePath).Select(x => x.Split(','));

             CSV = lines.Skip(1)
           .SelectMany(x => x)
           .Select((v, i) => new { Value = v, Index = i % lineLength })
           .Where(x => x.Index == 1)
           .Select(x => x.Value);

            foreach (var data in CSV)
            {
                Console.WriteLine(data);
            }


            return new InputEntities();
        }
    }
}
