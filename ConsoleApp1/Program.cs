using Microsoft.Extensions.Configuration;
using System.IO;

/*
    https://github.com/tvn-cosine/tesseract.net
    https://github.com/tvn-cosine/tesseract.net/wiki/How-to-use-tesseract.net
    https://github.com/tvn-cosine/tesseract.net/wiki/Compiling-the-Tesseract-lib-for-Windows

    https://github.com/tesseract-ocr/tesseract/wiki/APIExample
    https://github.com/tesseract-ocr/tesseract/blob/master/src/api/baseapi.h
    https://www.learnopencv.com/deep-learning-based-text-recognition-ocr-using-tesseract-and-opencv
    https://github.com/charlesw/tesseract
*/
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($"appsettings.json");

            var configuration = builder.Build();

            var tessBaseApi = new TessBaseAPI();

            tessBaseApi.Init(null, Constants.Language.ENGLISH);
        }
    }
}
