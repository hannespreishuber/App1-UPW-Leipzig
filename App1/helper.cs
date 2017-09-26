using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace App1
{
    class Helper
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);

        public static int MessageBox1(String text, String caption)
        {
            return MessageBox(new IntPtr(0), text, caption, 0);
             
        }
    }
}
