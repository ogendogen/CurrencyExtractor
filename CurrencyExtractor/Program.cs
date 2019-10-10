using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyExtractor.Models;

namespace CurrencyExtractor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start extracting process...");
            Console.ReadKey();

            try
            {
                Console.WriteLine("Starting integration");
                Console.WriteLine("Extraction started");
                Console.WriteLine("Establishing connection...");
                List<MediatedSchema> mediatedSchemas = Extractor.GetAllFromWeb().ToList();
                Console.WriteLine("Mediated schema objects deserialized");

                Console.WriteLine("Extraction successful");

                Console.WriteLine("Writing to files");
                JsonDumper.DumpJsonsToFiles("../output/", mediatedSchemas);

                Console.WriteLine("Extraction successful");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured. Logging details...");
                Logger.LogException("ErrorLogs.log", e);
                Console.WriteLine("Logging finished. Press any key to stop application");
                Console.ReadKey();
            }
        }
    }
}
