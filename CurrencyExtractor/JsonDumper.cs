using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CurrencyExtractor.Models;
using Newtonsoft.Json;

namespace CurrencyExtractor
{
    public static class JsonDumper
    {
        public static void DumpJsonToFile(string path, FinalOutput finalJson)
        {
            try
            {
                string serialized = JsonConvert.SerializeObject(finalJson, Formatting.Indented);
                File.WriteAllText(path, serialized);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error during serialization. Message: " + e.Message);
            }
        }

        public static void DumpJsonsToFiles(string path, IEnumerable<MediatedSchema> jsons)
        {
            try
            {
                int counter = 0;
                foreach (var json in jsons)
                {
                    counter++;
                    string serialized = JsonConvert.SerializeObject(json, Formatting.Indented);
                    File.WriteAllText(path + "curr" + counter.ToString() + ".json", serialized);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error during serialization. Message: " + e.Message);
            }
        }
    }
}
