using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMEStockManagmentSystem.Main
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //This code for validation User Login
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin123")
            {
                //MessageBox.Show("ចូលប្រើប្រព័ន្ធជោគជ័យ");
                frmMain objfrmMain = new frmMain();
                objfrmMain.Show();

                Hide();
            }
            else
            {
                MessageBox.Show("ចូលប្រើប្រព័ន្ទបរាជ័យ");
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13) //13 = key Enter on Keyboard
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                btnLogin.PerformClick();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
