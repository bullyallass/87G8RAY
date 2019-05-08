using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemsyaab
{
    public partial class password : Form
    {
        public password()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void password_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (e.CloseReason == CloseReason.TaskManagerClosing)
                {
                    return;
                    //e.Cancel = true;
                    //base.OnFormClosing(e);
                }
            }
            catch
            {
                return;
            }

        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            //if ((e.KeyboardDevice.IsKeyDown(Key.LeftAlt)) && (e.KeyboardDevice.IsKeyDown(Key.F7)))
            if ((e.Alt) && (e.KeyCode == Keys.F7))
            {
                this.DialogResult = DialogResult.Yes;
                this.Close();
                Environment.Exit(Environment.ExitCode);
            }
        }
    }
}
