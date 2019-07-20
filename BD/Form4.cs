using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BD
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private MySqlDataAdapter adap;
        public MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;user=root;database=workingsalary;password=root;");
        public MySqlCommand com;

        private void button1_Click(object sender, EventArgs e)
        {
            DGV();
        }

        public void DGV()
        {
            con.Open();
            string s1 = "SELECT * FROM firms;";
            adap = new MySqlDataAdapter(s1, con);
            DataSet DS = new DataSet();
            adap.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataTable chang = ((DataTable)dataGridView1.DataSource).GetChanges();
                if (chang != null)
                {
                    MySqlCommandBuilder mcb = new MySqlCommandBuilder(adap);
                    adap.UpdateCommand = mcb.GetUpdateCommand();
                    adap.Update(chang);
                    ((DataTable)dataGridView1.DataSource).AcceptChanges();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxCLP.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        public void openCon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void closeCon()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public void MyQuery(string query)
        {
            try
            {
                openCon();
                com = new MySqlCommand(query, con);
                if (com.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                }
                else
                {
                    MessageBox.Show("Query Not Executed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeCon();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s1 = "INSERT INTO firms(Name, CLP) VALUES('" + textBoxName.Text + "','" + textBoxCLP.Text + "') ";
            MyQuery(s1);
            DGV();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s2 = "DELETE FROM firms WHERE ID_Firm = " + int.Parse(textBoxID.Text) + " ";
            MyQuery(s2);
            DGV();
        }
    }
}
