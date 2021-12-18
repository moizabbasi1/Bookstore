using Npgsql;
using System;
using System.Windows.Forms;

namespace Book_Store
{
    public partial class MyOrders : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=root;Database=bookstore");
        public MyOrders()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                NpgsqlCommand comm = new NpgsqlCommand("select status from Basket where id="
                    +int.Parse(textId.Text)+";", conn);
                var reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    labelStatus.Text = "Status: "+reader["status"];
                }
                conn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
