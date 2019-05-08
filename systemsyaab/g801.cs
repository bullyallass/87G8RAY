using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemsyaab
{
    public partial class g801 : Form
    {
        private System.Timers.Timer nowtimer;
        int LL = 0;
        int TT = 0;
        string dirPath = @"C:\ProgramData\adonisyan\";
        public g801(int L,int T)
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
            LL = L;
            TT = T;
        }

        private void g801_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (e.CloseReason == CloseReason.TaskManagerClosing)
                {
                    Form1.a = 0;
                    Form1.L = 0;
                    Form1.T = 0;
                    return;
                    //e.Cancel = true;
                    //base.OnFormClosing(e);
                }
                password ps = new password();
                //ps.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                ps.Owner = this;
                if (ps.ShowDialog() == DialogResult.Yes)
                {

                }
                else
                {
                    e.Cancel = true;
                }
            }
            catch
            {
                return;
            }
        }

        private void g801_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
            nowtimerShow();
        }

        private void g801_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Alt) && (e.KeyCode == Keys.F7))
            {
                //this.DialogResult = DialogResult.Yes;
                //this.Close();
                if(Directory.Exists(dirPath))
                {
                    Directory.Delete(dirPath);
                }
                Environment.Exit(Environment.ExitCode);
            }
        }

        private void nowtimerShow()
        {
            this.nowtimer = new System.Timers.Timer();
            this.nowtimer.Interval = 250;
            this.nowtimer.Elapsed += new System.Timers.ElapsedEventHandler(Timer_Elapsed);
            this.nowtimer.Start();
        }

        void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            BeginInvoke(new delegateUserControlPT(TimerUpdateControl));
        }

        void TimerUpdateControl()
        {
            this.TopMost = true;
            this.Left = LL;
            this.Top = TT;
        }

        private delegate void delegateUserControlPT();
    }
}
