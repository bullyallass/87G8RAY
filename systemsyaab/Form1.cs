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

namespace systemsyaab
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer nowtimer;
        string dirPath = @"C:\ProgramData\adonisyan\";
        bool startfuck = false;
        public static int a = 0;
        public static int L = 0;
        public static int T = 0;
        //g801 g8 = new g801();
        public static bool restart = false;
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            SetVisibleCore(false);
            #region 建資料夾
            
            if (Directory.Exists(dirPath))
            {
                //MessageBox.Show(String.Format("{0} 已經存在.", dirPath));
            }
            else
            {
                Directory.CreateDirectory(dirPath);
                //MessageBox.Show(String.Format("{0} 建立完成", dirPath));
            }
            
            #endregion
        }

        /*[DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr window, int index, int value);
        [DllImport("user32.dll")]
        public static extern int GetWindowLong(IntPtr window, int index);
        public static void setTaskmanager_Disable(IntPtr Handle)
        {
            const int GWL_EXSTYLE = -20;
            const int WS_EX_TOOLWINDOW = 0x00000080;
            const int WS_EX_APPWINDOW = 0x00040000;        
            
            int windowStyle = Win32APi.GetWindowLong(Handle, GWL_EXSTYLE);
            SetWindowLong(Handle, GWL_EXSTYLE, windowStyle | WS_EX_TOOLWINDOW);
        }*/

        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Enabled = false;
            restart = true;
            nowtimerShow();
            int a = Screen.PrimaryScreen.Bounds.Width;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = 0;
            startfuck = !startfuck;
            this.Enabled = false;
            

            nowtimerShow();

        }

        private void nowtimerShow()
        {
            this.nowtimer = new System.Timers.Timer();
            this.nowtimer.Interval = 50;
            this.nowtimer.Elapsed += new System.Timers.ElapsedEventHandler(Timer_Elapsed);
            this.nowtimer.Start();
        }

        void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            BeginInvoke(new delegateUserControlPT(TimerUpdateControl));
        }

        void TimerUpdateControl()
        {
            //if ((startfuck) && (a < 60))
            if ((a < 65))
            {

                a++;
                g801 g8 = new g801(L,T);
                //g8.WindowStartupLocation = WindowStartupLocation.Manual;
                g8.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
                g8.Left = L;
                g8.Top = T;
                //g8.ShowInTaskbar = false;

                //g8.Location=new Point(L, T);
                if (T < 1080)
                {
                    T = T + 200;
                }
                if ((T >= 1080) && (L < 3840))
                {
                    L = L + 400;
                    T = 0;
                }
                //g8.Owner = this;
                //g8.ShowDialog();
                g8.Show();
            }
            else
            {
                /*if ((g8 != null) && (g8.IsDisposed!=true))
                {
                    restart = false;
                }*/

                //nowtimer.Stop();
            }
        }

        private delegate void delegateUserControlPT();


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                password ps = new password();
                ps.Owner = this;

                if (e.CloseReason == CloseReason.TaskManagerClosing)
                {
                    return;
                    //Application.Restart();
                    //e.Cancel = true;
                    //base.OnFormClosing(e);
                }
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

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
