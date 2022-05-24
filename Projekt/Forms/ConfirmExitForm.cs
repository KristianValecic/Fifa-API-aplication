using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt.Forms
{

    public partial class ConfirmExitForm : Form
    { 
        public ConfirmExitForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
            Focus();
        }

        private void No_Click(object sender, EventArgs e)
        {
            CancleExit();
        }

        private void CancleExit()
        {
            MainForm.closePending = false;
            Close();
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConfirmExitForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                CancleExit();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                Application.Exit();
            }
        }
    }
}
