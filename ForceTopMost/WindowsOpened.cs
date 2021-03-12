using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForceTopMost
{
    using HWND = IntPtr;
    class WindowsOpened
    {
        //you are beautiful
        public static IntPtr GetWindow(string programName)
        {

            IDictionary<IntPtr, string> values = new Dictionary<IntPtr, string>();
            values = GetOpenWindows();
            foreach (KeyValuePair<IntPtr, string> window in values)
            {
                if (window.Value.Contains(programName))
                {
                    return window.Key;
                }
            }
            return IntPtr.Zero;
        }
        public static IDictionary<HWND, string> GetOpenWindows()
        {
            HWND shellWindow = User32.GetShellWindow();

            Dictionary<HWND, string> windows = new Dictionary<HWND, string>();

            User32.EnumWindows(delegate (HWND hWnd, int lParam)
            {
                if (hWnd == shellWindow) return true;
                if (!User32.IsWindowVisible(hWnd)) return true;

                int length = User32.GetWindowTextLength(hWnd);
                if (length == 0) return true;

                StringBuilder builder = new StringBuilder(length);
                User32.GetWindowText(hWnd, builder, length + 1);

                windows[hWnd] = builder.ToString();
                return true;

            }, 0);

            return windows;
        }
    }
}
