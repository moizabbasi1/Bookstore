using Npgsql;
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

namespace Book_Store
{
    public partial class Form1 : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=root;Database=bookstore");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String query = "insert into Users values('" + regUsername.Text + "','" +
                    regPass.Text + "','" + regAddress.Text + "','" + regGenderCombo.Text[0] + "');";
                NpgsqlCommand comm = new NpgsqlCommand(query, conn);
                int n = comm.ExecuteNonQuery();
                conn.Close();
                if (n > 0)
                {
                    Dashboard dash = new Dashboard(regUsername.Text);
                    dash.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Something went wrong!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login=new Login();
            this.Hide();
            login.Show();
        }
    }
}
