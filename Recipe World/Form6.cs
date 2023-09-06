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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Close2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Back2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                sql con3 = new sql();
                SqlConnection connectionobj = new SqlConnection(con3.connect);
                connectionobj.Open();
                string sql = "delete from details where No = '" + No.Text + "'";
                SqlCommand command = new SqlCommand(sql, connectionobj);
                command.ExecuteNonQuery();
                connectionobj.Close();
                MessageBox.Show("Recipe Deleted successfully!!!");
            }
            catch (Exception ex)
            { MessageBox.Show("Error !!!"); }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                sql con2 = new sql();
                SqlConnection connectionobj = new SqlConnection(con2.connect);
                connectionobj.Open();
                string sql = "update details set Name = '" + Name.Text + "',Ingredients = '" + ingredients.Text + "', Process = '" + Process.Text + "'where  No= '" + No.Text + "'";
                SqlCommand command = new SqlCommand(sql, connectionobj);
                command.ExecuteNonQuery();
                connectionobj.Close();
                MessageBox.Show("Recipe Edited successfully!!!");
            }
            catch (Exception ex)
            { MessageBox.Show("Error !!!"); }
        }

        private void Add1_Click(object sender, EventArgs e)
        {
            try
            {
                sql con1 = new sql();
                SqlConnection connectionobj = new SqlConnection(con1.connect);
                connectionobj.Open();
                string sql = "insert into details(No,Name,Ingredients,Process)values('"+ No.Text +"','"+Name.Text+"','"+ ingredients.Text+"','"+Process.Text+"')";
                SqlCommand command = new SqlCommand(sql, connectionobj);
                command.ExecuteNonQuery();
                connectionobj.Close();
                MessageBox.Show("Recipe added successfully!!!");
            }
            catch (Exception ex)
            { MessageBox.Show("Error !!!"); }
        }

        private void ingredients_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
