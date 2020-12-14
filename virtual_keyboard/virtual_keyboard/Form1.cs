using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace virtual_keyboard
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// The window is initially visible. See http://msdn.microsoft.com/en-gb/library/windows/desktop/ms632600(v=vs.85).aspx.
        /// </summary>
        public const UInt32 WS_VISIBLE = 0X94000000;
        /// <summary>
        /// Specifies we wish to retrieve window styles.
        /// </summary>
        public const int GWL_STYLE = -16;

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(String sClassName, String sAppName);

        [DllImport("user32.dll", SetLastError = true)]
        static extern UInt32 GetWindowLong(IntPtr hWnd, int nIndex);


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Gets the window handler for the virtual keyboard.
        /// </summary>
        /// <returns>The handle.</returns>
        public static IntPtr GetKeyboardWindowHandle()
        {
            return FindWindow("IPTip_Main_Window", null);
        }

        /// <summary>
        /// Checks to see if the virtual keyboard is visible.
        /// </summary>
        /// <returns>True if visible.</returns>
        public static bool IsKeyboardVisible()
        {
            IntPtr keyboardHandle = GetKeyboardWindowHandle();

            bool visible = false;

            if (keyboardHandle != IntPtr.Zero)
            {
                UInt32 style = GetWindowLong(keyboardHandle, GWL_STYLE);
                visible = (style == WS_VISIBLE);
            }

            return visible;
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            string keyboardPath = Path.Combine(progFiles, "TabTip.exe");

            Process[] myProcess = Process.GetProcessesByName("TabTip");

            if (myProcess.Length > 0)
            {
                myProcess[0].Kill();
                Process.Start(keyboardPath);
            }
            

            if (IsKeyboardVisible())
            {
                textBox1.Text = "keyboard is visible";
            }
            else
            {
                textBox1.Text = "keyboard is NOT visible";
            }
        }
    }
}
