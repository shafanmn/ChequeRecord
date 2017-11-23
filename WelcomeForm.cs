using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ChequeRecord
{
    public partial class WelcomeForm : Form
    {
        MySqlConnection conn;
        Classes.MyClasses myclass;


        public void toFront(Form loading)
        {
            loading.TopLevel = true;
            loading.Show();
            loading.Owner = this;
        }

        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void banksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForms.Banks b = new MainForms.Banks();
            this.toFront(b);
            
        }

        private void givenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForms.frmReceiveCheque r = new MainForms.frmReceiveCheque();
            this.toFront(r);
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForms.Customers cu = new MainForms.Customers();
            this.toFront(cu);
        }
    }
}
