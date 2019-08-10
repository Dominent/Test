using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace ConsoleApp1
{
    public class Tesseract
    {
        public string Path { get; set; }

        public string TesseractDll { get; set; }

        public string LiptonicaDll { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($"appsettings.json");

            var configuration = builder.Build();

            var tesseractConfig = configuration
                .GetSection(nameof(Tesseract))
                .Get<Tesseract>();


        }
    }
}
