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
    public partial class Login : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=root;Database=bookstore");
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                NpgsqlCommand comm = new NpgsqlCommand("select * from Users where username='"+
                    logUsername.Text+"' and password='"+logPass.Text+"';", conn);
                var reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    Dashboard dash=new Dashboard(reader["username"].ToString());
                    conn.Close();
                    dash.Show();
                    this.Hide();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
