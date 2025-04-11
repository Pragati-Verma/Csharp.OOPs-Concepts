using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CheckingExecution
{
    public class Package
    {
        public string? ProductName { get; set; }
        public DateTime DateTime { get; set; }
        public decimal ProductPrice { get; set; }
    }
    public class SerializationDemo
    {
        public static void Main(string[] args)
        {
            /*
            Package package = new Package()
            {
                ProductName = "Apple juice",
                DateTime = DateTime.Now,
                ProductPrice = 45m
            };
            //var options = new JsonSerializerOptions();
            //options.WriteIndented = true;
            //string jsonSerializer = JsonSerializer.Serialize(package, options);
            string jsonSerializer = JsonSerializer.Serialize(package);
            //byte[] jsonSerializer = JsonSerializer.SerializeToUtf8Bytes(package);
            File.WriteAllText("package.json", jsonSerializer);
            Console.WriteLine(jsonSerializer);
            */

            // 'package.json' file is created in project folder’s bin > Debug > package.json
            var packageJson = File.ReadAllText("package.json");
            //no need of instance now but we need to have Package class
            // while Deserialization type specific <Package> is must
            // but it is optional during serialization
            Package package = JsonSerializer.Deserialize<Package>(packageJson);
            Console.WriteLine(package);
            //now our json file contains the object which is stored and can be reused
            //whenever it is required until we delete/remove it
        }
    }
}
