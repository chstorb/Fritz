using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fritz
{
    public sealed class FritzUtility
    {
        public static string Encode(string value)
        {
            value = value.Replace("&", "&amp;");
            return value;
        }

        public static List<Tuple<string, string, string, string, string>> ReadCsvFile(string fileName, char delimiter = ';', bool firstRowHasColumnNames = true)
        {
            var list = new List<Tuple<string, string, string, string, string>>();
            var rowId = 0;

            using (var reader = new StreamReader(fileName))
            {                
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    rowId++;

                    if (firstRowHasColumnNames && 1 == rowId) continue;

                    var values = line.Split(delimiter);

                    list.Add(new Tuple<string, string, string, string, string>(values[0], values[1], values[2], values[3], values[4]));
                }                
            }

            return list;
        }
    }
}
