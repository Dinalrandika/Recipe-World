using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Recipe_World
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        void refresh()
        {
            try
            {
                sql con7 = new sql();
                SqlConnection connectionobj = new SqlConnection(con7.connect);
                connectionobj.Open();
                string viewtable = "select * from details where Name='" + comboBox1.Text.ToString() + "'";
                SqlCommand command = new SqlCommand(viewtable, connectionobj);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                connectionobj.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

            
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            try
            {
                sql con6 = new sql();
                SqlConnection connectionobj = new SqlConnection(con6.connect);
                connectionobj.Open();
                string viewtable = "select No,Name from details";
                SqlCommand command = new SqlCommand(viewtable, connectionobj);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.SelectCommand = command;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "No";
                connectionobj.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
