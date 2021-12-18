Bookstore consists of two applications,
1. Customer
2. Admin
Both applications are developed using Visual Studio and PostgreSQL.
So, pgadmin 4 and atleast Visual Studio 2022 is required to run these applications.
ddl.sql contains all tables commands that should be run in pgadmin4.
may work wth 2019+

------------Steps to Run the Program------------------

1. Create database named "bookstore" in pgadmin4.
2. Import ddl.sql in the database or run all the commands in that database.
3. Open application code in visual studio.
4. make sure to change the username/password to your pgAdmin username/password
5. run the admin SLN file first to add books.
6. Just run it in debug mode.

The following are queries embedded into the project:

-------Database Quries Information---------------
Database insert, update, delete and select queries are in the admin application.
Insert and select queries are also part of customer application.

-----Admin Application---------------
----Select Queries----------------
NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM Book;", conn);
NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM Publisher;", conn);
NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM Author;", conn);
NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM Basket;", conn);

----- Insert Queries----
 query= "insert into Book values('" + textISBN.Text + "','" + textTitle.Text +
                    "'," + double.Parse(textPrice.Text) + "," + int.Parse(textYear.Text) + "," +
                    int.Parse(textPages.Text) + ",'" + comboGenre.Text + "','" + comboPub.Text + "','" +
                    comboAuth.Text + "','" + 
                    authorTable.Rows[comboAuth.SelectedIndex]["address"] +"',"+
                    int.Parse(textQuantity.Text)+ ");";
query = "insert into Publisher values('" + textNamePub.Text + "','" +
                    textAddressPub.Text + "','" + textPhonePub.Text + "');";



query = "insert into Author values('" + textNameAuth.Text + "','" +
            textAddressAuth.Text + "');";


----------Delete Queries---------

 query = "delete from Book where isbn='" + 
                    booksTable.Rows[booksGrid.CurrentCell.RowIndex]["isbn"].ToString() + "';";


----update Queries-----------
  String query = "update Basket set status='" +
                    comboBox1.Text + "' where id="+
                    orderTable.Rows[gridOrders.CurrentCell.RowIndex]["id"]+";";
String query = "update Book set count=count+" +
                    int.Parse(textUpdateQuantity.Text) + " where isbn=" +
                    booksTable.Rows[booksGrid.CurrentCell.RowIndex]["isbn"] + ";";



--------------Book store Application-----

----Insert Queries-------------
  String query = "insert into Users values('" + regUsername.Text + "','" +
                    regPass.Text + "','" + regAddress.Text + "','" + regGenderCombo.Text[0] + "');";
 comm = new NpgsqlCommand("insert into Basket values(" +
                        orderId + ",'" + username + "','" + textShipAddress.Text + "','Pending');", conn);
comm = new NpgsqlCommand("insert into BasketBook values("+
                        orderId+",'"+row["isbn"]+"',"+row["count"]+");",conn);
-=-----Select Quries-----------
 NpgsqlCommand comm = new NpgsqlCommand("select * from Users where username='"+
                    logUsername.Text+"' and password='"+logPass.Text+"';", conn);
NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM Book;", conn);            