using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinyuanDB
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1_Main());
            //Application.Run(new Form2_InsertOrder());
            //Application.Run(new Form3_SearchOrder());
            //Application.Run(new Form4_UpdateOrder());
            //Application.Run(new Form6_InsertClient());
            //Application.Run(new Form8_SelectUpdateClient());
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool SetProcessDPIAware();
    }
}
