using System;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    public class TessBaseAPI : UnmanagedObject, IDisposable
    {
        public TessBaseAPI()
            : base(DLLImports.TessBaseAPI.TessBaseAPICreate())
        {
        }

        public bool Init(string datapath, string language)
        {
            return DLLImports.TessBaseAPI.Init((HandleRef)this, datapath, language) == 0;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
