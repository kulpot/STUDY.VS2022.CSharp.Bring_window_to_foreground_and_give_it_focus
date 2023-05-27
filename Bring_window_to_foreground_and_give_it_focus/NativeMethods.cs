using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//Basically do it this way to actually give the window focus, even if another window in another app is in use.

namespace Bring_window_to_foreground_and_give_it_focus
{
    static class NativeMethods
    {
        [DllImport("user32.dll")]
        // Make sure the program knows exacly. how to interpret the return type
        [return: MarshalAs(UnmanagedType.Bool)]
        // Mark public static, no need to be object oriented or private
        // Mark extern to search outside the assembly, specifically in user32.dll
        public static extern bool SetForegroundWindow(IntPtr hWnd);
    }
}
