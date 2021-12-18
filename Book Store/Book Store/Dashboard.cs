using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using Npgsql;

namespace Book_Store
{
    public partial class Dashboard : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=root;Database=bookstore");
        DataTable basketTable;
        string username;
        public Dashboard(string username)
        {
            InitializeComponent();
            loadBooks();
            this.username = username;
            basketTable=new DataTable();
            basketTable.Columns.Add("isbn", typeof(string));
            basketTable.Columns.Add("title", typeof(string));
            basketTable.Columns.Add("author", typeof(string));
            basketTable.Columns.Add("price", typeof(double));
            basketTable.Columns.Add("count", typeof(int));
        }

        private void loadBooks()
        {
            conn.Open();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM Book;", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);

            foreach(DataRow row in table.Rows)
            {
                comboBooks.Items.Add(row["title"].ToString());
            }
            booksGrid.DataSource = table;
            conn.Close();
        }
        private void btnAddToBasket_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in booksGrid.SelectedRows)
            {
                bool found = false;
                foreach(DataRow basketRow in basketTable.Rows)
                {
                    if (basketRow["isbn"].Equals(row.Cells["isbn"].Value))
                    {
                        found = true;
                        basketRow["count"] = (int)basketRow["count"] + 1;
                        //basketTable.Rows.Find(row.Cells["isbn"])["count"] = (int)basketTable.Rows.Find(row.Cells["isbn"])["count"] + 1;
                        break;
                    }
                }
                if(!found)
                {
                    DataRow newRow = basketTable.NewRow();
                    newRow["count"] = 1;
                    newRow["isbn"] = row.Cells["isbn"].Value;
                    newRow["title"] = row.Cells["title"].Value;
                    newRow["author"] = row.Cells["auth_name"].Value;
                    newRow["price"] = row.Cells["price"].Value;
                    basketTable.Rows.Add(newRow);
                }
            }
            basketGrid.DataSource = basketTable;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textShipAddress.Text.Trim()))
            {
                MessageBox.Show("Shipping address required!");
                return;
            }
            if (basketTable.Rows.Count==0)
            {
                MessageBox.Show("No Book selected to Checkout!");
                return;
            }
            int orderId=new Random().Next(1,10000);
            try
            {
                conn.Open();
                NpgsqlCommand comm;
                comm = new NpgsqlCommand("insert into Basket values(" +
                        orderId + ",'" + username + "','" + textShipAddress.Text + "','Pending');", conn);
                comm.ExecuteNonQuery();
                foreach (DataRow row in basketTable.Rows)
                {
                    comm = new NpgsqlCommand("insert into BasketBook values("+
                        orderId+",'"+row["isbn"]+"',"+row["count"]+");",conn);
                    comm.ExecuteNonQuery();
                }
                conn.Close();
                MessageBox.Show("Order created with ID: " + orderId+"\nKeep it safe for order tracking!");
            }catch(Exception ex)
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

        private void btnAllOrders_Click(object sender, EventArgs e)
        {
            MyOrders orders = new MyOrders();
            orders.Show();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            basketTable.Rows.Clear();
            basketGrid.DataSource = basketTable;
        }
    }
}
