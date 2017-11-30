using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChequeRecord.Classes
{
    class MyClasses
    {
        MySqlConnection conn = new Classes.Connections().getConnection();
        public void toFront(Form loading, Form current)
        {
            loading.TopLevel = true;
            loading.Show();
            loading.Owner = current;
        }

        public void LoadToDatagridview(DataGridView dgv, string q)
        {
            DataTable dt = new DataTable();
            dgv.Rows.Clear();

            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            MySqlCommand cmd = new MySqlCommand(q, conn);

            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                dgv.DataSource = bs;
                da.Update(dt);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        public void LoadToListBox(ListBox lsb, string query)
        {
            lsb.Items.Clear();

            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            MySqlCommand cmd = new MySqlCommand(query, conn);

            try
            {
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    lsb.Items.Add(dr[0].ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void fillCombo(ComboBox c, string query, string field)
        {
            c.Items.Clear();

            MySqlCommand cmd = new MySqlCommand(query, this.conn);

            try
            {
                conn.Open();
                var read = cmd.ExecuteReader();
                while (read.Read())
                    c.Items.Add(read.GetString(field));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        public string getNextId(string query)
        {
            string q = query;
            string id = "0";

            try
            {
                conn.Open();
                MySqlDataReader dr = new MySqlCommand(q, this.conn).ExecuteReader();
                if (dr.Read())
                    id = (Convert.ToInt32(dr[0].ToString()) + 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return id;
        }

        public void runQuery(string q,string name,string ADU)
        {
            MySqlCommand cmd = new MySqlCommand(q, this.conn);
            try
            {
                conn.Open();
                if(cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show(name + " "+ADU+ " successfully!");
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
