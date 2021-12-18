using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Npgsql;

namespace Book_Store__Admin_
{
    public partial class Form1 : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=root;Database=bookstore");
        DataTable booksTable, publisherTable, authorTable, orderTable;
        public Form1()
        {
            InitializeComponent();
            loadBooks();
            loadAuthors();
            loadOrders();
            loadPublishers();
        }
        private void loadBooks()
        {
            conn.Open();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM Book;", conn);
            booksTable = new DataTable();
            adapter.Fill(booksTable);
            booksGrid.DataSource = booksTable;
            conn.Close();
        }
        private void loadPublishers()
        {
            conn.Open();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM Publisher;", conn);
            publisherTable = new DataTable();
            adapter.Fill(publisherTable);
            comboPub.Items.Clear();
            foreach (DataRow row in publisherTable.Rows)
            {
                comboPub.Items.Add(row["name"].ToString());
            }
            gridPublisher.DataSource = publisherTable;
            conn.Close();
        }
        private void loadAuthors()
        {
            conn.Open();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM Author;", conn);
            authorTable = new DataTable();
            adapter.Fill(authorTable);
            comboAuth.Items.Clear();
            foreach(DataRow row in authorTable.Rows)
            {
                comboAuth.Items.Add(row["name"].ToString());
            }
            gridAuthor.DataSource = authorTable;
            conn.Close();
        }
        private void loadOrders()
        {
            conn.Open();
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM Basket;", conn);
            orderTable = new DataTable();
            adapter.Fill(orderTable);
            gridOrders.DataSource = orderTable;
            conn.Close();
        }
        BindingSource bs=new BindingSource();
        private void btnSearchBooks_Click(object sender, EventArgs e)
        {
            if (searchBoxBooks.Text.Trim().Length == 0)
            {
                booksGrid.DataSource = booksTable;
                return;
            }
            bs.DataSource = booksGrid.DataSource;
            bs.Filter = "title like '%"+searchBoxBooks.Text.Trim().ToLower()+"%'";
            booksGrid.DataSource = bs.DataSource;
        }


        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "insert into Book values('" + textISBN.Text + "','" + textTitle.Text +
                    "'," + double.Parse(textPrice.Text) + "," + int.Parse(textYear.Text) + "," +
                    int.Parse(textPages.Text) + ",'" + comboGenre.Text + "','" + comboPub.Text + "','" +
                    comboAuth.Text + "','" + 
                    authorTable.Rows[comboAuth.SelectedIndex]["address"] +"',"+
                    int.Parse(textQuantity.Text)+ ");";
                NpgsqlCommand comm = new NpgsqlCommand(query, conn);
                conn.Open();
                int n = comm.ExecuteNonQuery();
                conn.Close();
                if (n > 0)
                {
                    MessageBox.Show("Data Inserted..");
                    loadBooks();
                    textISBN.Clear();
                    textPages.Clear();
                    textPrice.Clear();
                    textTitle.Clear();
                    textYear.Clear();
                }
                else
                {
                    MessageBox.Show("Something went wrong!");
                }
            }
            catch(Exception ex)
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

        private void btnAddPub_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "insert into Publisher values('" + textNamePub.Text + "','" +
                    textAddressPub.Text + "','" + textPhonePub.Text + "');";
                NpgsqlCommand comm = new NpgsqlCommand(query, conn);
                conn.Open();
                int n = comm.ExecuteNonQuery();
                conn.Close();
                if (n > 0)
                {
                    MessageBox.Show("Data Inserted..");
                    loadPublishers();
                    textNamePub.Clear();
                    textAddressPub.Clear();
                    textPhonePub.Clear();
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

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "insert into Author values('" + textNameAuth.Text + "','" +
                    textAddressAuth.Text + "');";
                NpgsqlCommand comm = new NpgsqlCommand(query, conn);
                conn.Open();
                int n = comm.ExecuteNonQuery();
                conn.Close();
                if (n > 0)
                {
                    MessageBox.Show("Data Inserted..");
                    loadAuthors();
                    textNameAuth.Clear();
                    textAddressAuth.Clear();
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "delete from Book where isbn='" + 
                    booksTable.Rows[booksGrid.CurrentCell.RowIndex]["isbn"].ToString() + "';";
                NpgsqlCommand comm = new NpgsqlCommand(query, conn);
                conn.Open();
                int n = comm.ExecuteNonQuery();
                conn.Close();
                if (n > 0)
                {
                    MessageBox.Show("Data Deleted..");
                    loadBooks();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gridOrders.CurrentCell.RowIndex < 0 || orderTable.Rows.Count==0)
            {
                MessageBox.Show("Select an order to update!");
                return;
            }
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Select an status to update!");
                return;
            }
            try
            {
                String query = "update Basket set status='" +
                    comboBox1.Text + "' where id="+
                    orderTable.Rows[gridOrders.CurrentCell.RowIndex]["id"]+";";
                NpgsqlCommand comm = new NpgsqlCommand(query, conn);
                conn.Open();
                int n = comm.ExecuteNonQuery();
                conn.Close();
                if (n > 0)
                {
                    MessageBox.Show("Status updated..");
                    loadOrders();
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

        private void btnUpdateQty_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "update Book set count=count+" +
                    int.Parse(textUpdateQuantity.Text) + " where isbn=" +
                    booksTable.Rows[booksGrid.CurrentCell.RowIndex]["isbn"] + ";";
                NpgsqlCommand comm = new NpgsqlCommand(query, conn);
                conn.Open();
                int n = comm.ExecuteNonQuery();
                conn.Close();
                if (n > 0)
                {
                    MessageBox.Show("Quantity updated..");
                    loadBooks();
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

        private void btnSearchPublisher_Click(object sender, EventArgs e)
        {
            if (searchBoxPublisher.Text.Trim().Length == 0)
            {
                gridPublisher.DataSource = publisherTable;
                return;
            }
            bs.DataSource = gridPublisher.DataSource;
            bs.Filter = "name like '%" + searchBoxPublisher.Text.Trim().ToLower() + "%'";
            gridPublisher.DataSource = bs.DataSource;
        }

        private void btnSearchAuthor_Click(object sender, EventArgs e)
        {
            if (searchBoxAuthor.Text.Trim().Length == 0)
            {
                gridAuthor.DataSource = authorTable;
                return;
            }
            bs.DataSource = gridAuthor.DataSource;
            bs.Filter = "name like '%" + searchBoxAuthor.Text.Trim().ToLower() + "%'";
            gridAuthor.DataSource = bs.DataSource;
        }

        private void btnSearchOrdera_Click(object sender, EventArgs e)
        {
            if (searchBoxOrders.Text.Trim().Length == 0)
            {
                gridOrders.DataSource = orderTable;
                return;
            }
            bs.DataSource = gridOrders.DataSource;
            bs.Filter = "id=" + int.Parse(searchBoxOrders.Text.Trim());
            gridOrders.DataSource = bs.DataSource;
        }
    }
}
