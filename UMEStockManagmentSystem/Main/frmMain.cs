using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMEStockManagmentSystem.Product;
using UMEStockManagmentSystem.Users;

namespace UMEStockManagmentSystem.Main
{
    public partial class frmMain : Form
    {
        #region Form Users
        frmEmployee objfrmEmployee = null;
        #endregion
        #region Form Product
        frmSupplyer objfrmSupplyer = null;
        #endregion

        public frmMain()
        {
            InitializeComponent();
        }

        private void tsmiEmployee_Click(object sender, EventArgs e)
        {
            if (objfrmEmployee != null)
            {
                objfrmEmployee.MdiParent = this;
                objfrmEmployee.Focus();
            }
            else
            {
                objfrmEmployee = new frmEmployee();
                objfrmEmployee.MdiParent = this;
                objfrmEmployee.Dock = DockStyle.Fill;
                objfrmEmployee.FormClosing += new FormClosingEventHandler(Obj_FormClosing);
                objfrmEmployee.Show();
            }
        }

        private void tsmiSupplyer_Click(object sender, EventArgs e)
        {
            if (objfrmSupplyer != null)
            {
                objfrmSupplyer.MdiParent = this;
                objfrmSupplyer.Focus();
            }
            else
            {
                objfrmSupplyer = new frmSupplyer();
                objfrmSupplyer.MdiParent = this;
                objfrmSupplyer.FormClosing += new FormClosingEventHandler(Obj_FormClosing);
                objfrmSupplyer.Dock = DockStyle.Fill;
                objfrmSupplyer.Show();
            }
        }

        private void Obj_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sender is Form objForm)
            {
                switch (objForm.Name)
                {
                    case "frmEmployee":
                        objfrmEmployee = null; //Clear block memory
                        break;
                    case "frmSupplyer":
                        objfrmSupplyer = null;
                        break;
                }
            }
        }

        private void tsmiCloseChild_Click(object sender, EventArgs e)
        {
            ActiveMdiChild?.Close();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
