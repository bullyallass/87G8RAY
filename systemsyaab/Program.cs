using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemsyaab
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            String name = Process.GetCurrentProcess().ProcessName;
            //取得所有與目前process名稱相同的process
            Process[] ps = Process.GetProcessesByName(name);
            //ps.Length > 1 表示此proces以重複執行
            if (ps.Length > 1)
            {
                System.Environment.Exit(2);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
    }
}
