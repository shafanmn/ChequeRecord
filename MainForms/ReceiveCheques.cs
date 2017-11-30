using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChequeRecord.MainForms
{
    public partial class frmReceiveCheque : Form
    {
        Classes.MyClasses my = new Classes.MyClasses();
        public frmReceiveCheque()
        {
            InitializeComponent();
        }

        public void clearReceiveCheques()
        {
            cmbCustomer.Text = "";
            valAmount.Value = Convert.ToDecimal(0.00);
            cmbType.Text = "";
            cmbBank.Text = "";
            txtChqNo.Text = "";
            txtBank.Text = "";
            txtBranch.Text = "";
            txtMemo.Text = "";

        }

        private void frmReceiveCheque_Load(object sender, EventArgs e)
        {
            my.fillCombo(cmbBank, "SELECT name FROM banks;","name");
        }

        private void btnRecvClear_Click(object sender, EventArgs e)
        {
            this.clearReceiveCheques();
        }

        private void btnRecvApp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to apply payment details?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

            }
        }
    }
}
