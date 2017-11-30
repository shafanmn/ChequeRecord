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

namespace ChequeRecord.MainForms
{
    public partial class Customers : Form
    {
        Classes.MyClasses my = new Classes.MyClasses();
        MySqlConnection conn = new Classes.Connections().getConnection();
        public Customers()
        {
            InitializeComponent();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            my.LoadToDatagridview(dgvCustomers, "SELECT id 'ID', name 'NAME' FROM customers;");
            dgvCustomers.Columns[0].Width = 25;
            lblCusId.Text = my.getNextId("SELECT id FROM customers ORDER BY id DESC;");
        }

        private void btnAddBank_Click(object sender, EventArgs e)
        {
            string name = txtCustName.Text;
            if (name == "")
                MessageBox.Show("Please enter the name");
            else
            {
                my.runQuery("INSERT INTO customers(name) VALUES('" + name + "');", name);
            }
        }
    }
}
