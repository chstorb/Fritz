using System;
using System.Collections.Generic;
using System.IO;

namespace Fritz
{
    public static class Utility
    {
        /// <summary>
        /// Encode the given value.
        /// </summary>
        /// <param name="value">The value to encode.</param>
        /// <returns>Return an encoded string.</returns>
        public static string Encode(string value)
        {
            value = value.Replace("&", "&amp;");
            return value;
        }

        /// <summary>
        /// Get a timestamp.
        /// </summary>
        /// <returns>Returns a timestamp string.</returns>
        public static string GetTimestamp()
        {            
            return DateTime.Now.ToString("yyyyMMddHHmmssffff");
        }

        /// <summary>
        /// Read a csv file.
        /// </summary>
        /// <param name="fileName">The file name.</param>
        /// <param name="delimiter">The delimiter (default is ;).</param>
        /// <param name="firstRowHasColumnNames">Determines if the first in the csv file is a column header (default is true).</param>
        /// <returns>List of entries.</returns>
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
