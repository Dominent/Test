using System;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    public static class DLLImports
    {
        public static class TessBaseAPI
        {
            [DllImport(Constants.TESSERACT_DLL, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(TessBaseAPICreate))]
            internal static extern IntPtr TessBaseAPICreate();

            [DllImport(Constants.TESSERACT_DLL, CallingConvention = CallingConvention.Cdecl, EntryPoint = nameof(Init))]
            internal static extern int Init(
                HandleRef tessBasiApiHandle,
                [MarshalAs(UnmanagedType.LPStr)] string datapath,
                [MarshalAs(UnmanagedType.LPStr)] string language);
        }
    }
}
