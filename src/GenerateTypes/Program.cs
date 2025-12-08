// Program.cs
// Usage: dotnet run -- <path-to-schemaorg-jsonld> <output-folder>

using Deploy.GenerateSchemaOrgPocos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SchemaOrgPocoGen
{
    internal static class Program
    {
        
        public async static Task<int> Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Usage: SchemaOrgPocoGen <path-to-schemaorg-jsonld> <output-folder>");
                return 1;
            }

            var jsonLdPath = Path.GetFullPath(args[0]);
            var outputRoot = Path.GetFullPath(args[1]);

            if (!File.Exists(jsonLdPath))
            {
                Console.WriteLine($"Input file not found: {jsonLdPath}");
                return 1;
            }

            Directory.CreateDirectory(outputRoot);

            Console.WriteLine($"Loading JSON-LD from: {jsonLdPath}");

            SchemaOrgPocoGenerator generator = new SchemaOrgPocoGenerator(jsonLdPath, outputRoot);
            var result = await generator.GenerateTypesFromSchemaLdAsync();
            if(!result.Succeeded)
            {
                return 1;
            }
            Console.WriteLine("Done.");
            return 0;
        }

    }
}
