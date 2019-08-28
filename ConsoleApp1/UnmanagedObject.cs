using System;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    public abstract class UnmanagedObject
    {
        private readonly HandleRef handleRef;

        public UnmanagedObject(IntPtr pointer)
        {
            if (pointer == IntPtr.Zero)
            {
                throw new ArgumentNullException();
            }

            handleRef = new HandleRef(this, pointer);
        }

        public static explicit operator IntPtr(UnmanagedObject obj)
        {
            if (null == obj)
            {
                return IntPtr.Zero;
            }
            else
            {
                return obj.handleRef.Handle;
            }
        }

        public static explicit operator HandleRef(UnmanagedObject obj)
        {
            if (null == obj)
            {
                return new HandleRef(null, IntPtr.Zero);
            }
            else
            {
                return obj.handleRef;
            }
        }
    }
}
