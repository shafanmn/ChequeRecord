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
    public partial class Banks : Form
    {
        Classes.MyClasses my = new Classes.MyClasses();
        MySqlConnection conn = new Classes.Connections().getConnection();

        public Banks()
        {
            InitializeComponent();
        }

        public void clearMyBanks()
        {
            txtMybName.Text = "";
            txtMybNo.Text = "";
            txtMybBranch.Text = "";
            cmbBanks.Text = "";
            cmbType.Text = "";
        }

        private void Banks_Load(object sender, EventArgs e)
        {
            my.LoadToListBox(lstBankDB, "SELECT name 'BANK' FROM banks;");
            my.LoadToListBox(lsdMyBanks, "SELECT name 'BANK' FROM mybanks;");
            my.fillCombo(cmbBanks, "SELECT name FROM banks", "name");
        }

        private void btnAddBank_Click(object sender, EventArgs e)
        {
            string bank = txtBanks.Text;

            if (bank == "")
            {
                MessageBox.Show("Please enter valid name");
            }
            else
            {

                string q = "INSERT INTO banks(name) VALUES(@name);";

                MySqlCommand cmd = new MySqlCommand(q, conn);
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = bank;

                try
                {
                    conn.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show(bank + " bank added successfully!");
                        txtBanks.Text = "";
                        txtBanks.Focus();
                        my.LoadToListBox(lstBankDB, "SELECT name 'BANK' FROM banks;");
                        my.fillCombo(cmbBanks, "SELECT name FROM banks", "name");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void txtBanks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAddBank_Click(sender, e);
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            btnRemoveBank.Enabled = true;

        }

        private void btnRemoveBank_Click(object sender, EventArgs e)
        {
            string item = lstBankDB.SelectedItem.ToString();

            string q = "DELETE FROM banks WHERE name=@name;";
            MySqlCommand cmd = new MySqlCommand(q, this.conn);
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = item;

            try
            {
                conn.Open();
                if(cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show(item+" removed successfully!");
                    my.LoadToListBox(lstBankDB, "SELECT name 'BANK' FROM banks;");
                    btnRemoveBank.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void btnMyAdd_Click(object sender, EventArgs e)
        {
            string name = txtMybName.Text;
            string no = txtMybNo.Text;
            string bank = cmbBanks.SelectedItem.ToString();
            string branch = txtMybBranch.Text;
            string type = cmbType.SelectedItem.ToString();

            string q = "INSERT INTO mybanks(id,name,acno,branch,type) VALUES(@id,@name,@acno,@branch,@type);";

            MySqlCommand cmd = new MySqlCommand(q, this.conn);
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = bank;
            cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@acno", MySqlDbType.VarChar).Value = no;
            cmd.Parameters.Add("@branch", MySqlDbType.VarChar).Value = branch;
            cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = type;

            try
            {
                conn.Open();
                if(cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Bank details added successfully!");
                    this.clearMyBanks();
                    my.LoadToListBox(lsdMyBanks, "SELECT name 'BANK' FROM mybanks;");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
