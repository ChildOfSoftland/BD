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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        private MySqlDataAdapter adap;
        public MySqlCommand com;

        private void button1_Click(object sender, EventArgs e)
        {
            DGV();
        }

        MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;user=root;database=workingsalary;password=root;");

        public void DGV()
        {
            con.Open();
            string s1 = "SELECT * FROM employees_has_departments;";
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
            textBoxAp.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxID_A.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxMainJob.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxID_D.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
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
            
            string s1 = "INSERT INTO employees_has_departments(Employees_ID_Associate, MainJob, Departments_ID_Department) VALUES('" +
                int.Parse(textBoxID_A.Text) + "','" + int.Parse(textBoxMainJob.Text) + "','" + int.Parse(textBoxID_D.Text) + "') ";
            MyQuery(s1);
            DGV();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s2 = "DELETE FROM employees_has_departments WHERE ID_Appointment = " + int.Parse(textBoxAp.Text) + " ";
            MyQuery(s2);
            DGV();
        }
    }
}
