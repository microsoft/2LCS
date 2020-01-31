using LCS.Forms;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace LCS
{
    class NativeMethods
    {
        [DllImport("user32.dll")]
        public static extern IntPtr GetWindow(IntPtr hWnd, int uCmd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hWnd, [Out] out MainForm.RECT lpRect);

        [DllImport("wininet.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool InternetGetCookieEx(string url, string cookieName, StringBuilder cookieData, ref int size, Int32 dwFlags, IntPtr lpReserved);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IntersectRect([Out] out MainForm.RECT lprcDst, [In] ref MainForm.RECT lprcSrc1, [In] ref MainForm.RECT lprcSrc2);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindowVisible(IntPtr hWnd);
    }
}
