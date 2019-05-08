using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tdferccv
{
    public partial class yaya : Form
    {
        private System.Timers.Timer nowtimer;
         string dirPath = @"C:\ProgramData\adonisyan\";
        public yaya()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (Directory.Exists(dirPath))
            {
                Process systemsyaab = new Process();
                // FileName 是要執行的檔案
                systemsyaab.StartInfo.FileName = @"/systemsyaab.exe";
                systemsyaab.Start();
            }
            else
            {
                //Directory.CreateDirectory(dirPath);
                //MessageBox.Show(String.Format("{0} 建立完成", dirPath));
            }
            
        }

        private void nowtimerShow()
        {
            this.nowtimer = new System.Timers.Timer();
            this.nowtimer.Interval = 1000;
            this.nowtimer.Elapsed += new System.Timers.ElapsedEventHandler(Timer_Elapsed);
            this.nowtimer.Start();
        }

        void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            BeginInvoke(new delegateUserControlPT(TimerUpdateControl));
        }

        void TimerUpdateControl()
        {
            if (Directory.Exists(dirPath))
            {
                Process yayaya = new Process();
                // FileName 是要執行的檔案
                yayaya.StartInfo.FileName = @"C:\Program Files\Debug\systemsyaab.exe";
                yayaya.Start();
            }
            else
            {
                System.Environment.Exit(2);
            }
        }

        private delegate void delegateUserControlPT();

        private void yaya_Shown(object sender, EventArgs e)
        {
            this.Hide();
            if (Directory.Exists(dirPath))
            {
                //MessageBox.Show(String.Format("{0} 已經存在.", dirPath));
            }
            else
            {
                Directory.CreateDirectory(dirPath);
                //MessageBox.Show(String.Format("{0} 建立完成", dirPath));
            }
            string sourceFile = Application.StartupPath+@"\Debug\";
            string destinationFile = @"C:\Program Files (x86)\Windows Sidebar\Gadgets\";

            // To move a file or folder to a new location:
            //System.IO.File.Move(sourceFile, destinationFile);

            // To move an entire directory. To programmatically modify or combine
            // path strings, use the System.IO.Path class.
            //System.IO.File.Copy()
            nowtimerShow();
        }
    }
}
