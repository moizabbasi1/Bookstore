
namespace Book_Store__Admin_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.comboGenre = new System.Windows.Forms.ComboBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboPub = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboAuth = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textISBN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPages = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.btnSearchBooks = new System.Windows.Forms.Button();
            this.searchBoxBooks = new System.Windows.Forms.TextBox();
            this.booksGrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddPub = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textNamePub = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textPhonePub = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textAddressPub = new System.Windows.Forms.TextBox();
            this.btnSearchPublisher = new System.Windows.Forms.Button();
            this.searchBoxPublisher = new System.Windows.Forms.TextBox();
            this.gridPublisher = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textNameAuth = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textAddressAuth = new System.Windows.Forms.TextBox();
            this.btnSearchAuthor = new System.Windows.Forms.Button();
            this.searchBoxAuthor = new System.Windows.Forms.TextBox();
            this.gridAuthor = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnSearchOrdera = new System.Windows.Forms.Button();
            this.searchBoxOrders = new System.Windows.Forms.TextBox();
            this.gridOrders = new System.Windows.Forms.DataGridView();
            this.bookstoreDataSet = new Book_Store__Admin_.bookstoreDataSet();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnUpdateQty = new System.Windows.Forms.Button();
            this.textUpdateQuantity = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPublisher)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthor)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnUpdateQty);
            this.tabPage1.Controls.Add(this.textUpdateQuantity);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.textQuantity);
            this.tabPage1.Controls.Add(this.btnDeleteBook);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.comboGenre);
            this.tabPage1.Controls.Add(this.btnAddBook);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.comboPub);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.comboAuth);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textPrice);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textISBN);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textPages);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textYear);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textTitle);
            this.tabPage1.Controls.Add(this.btnSearchBooks);
            this.tabPage1.Controls.Add(this.searchBoxBooks);
            this.tabPage1.Controls.Add(this.booksGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Books";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Genre";
            // 
            // comboGenre
            // 
            this.comboGenre.FormattingEnabled = true;
            this.comboGenre.Items.AddRange(new object[] {
            "Fiction",
            "Spy",
            "Adventure",
            "Romantic",
            "Sports",
            "Travel",
            "Drama"});
            this.comboGenre.Location = new System.Drawing.Point(52, 39);
            this.comboGenre.Name = "comboGenre";
            this.comboGenre.Size = new System.Drawing.Size(139, 21);
            this.comboGenre.TabIndex = 18;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(640, 39);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(141, 23);
            this.btnAddBook.TabIndex = 17;
            this.btnAddBook.Text = "Add New";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Publisher";
            // 
            // comboPub
            // 
            this.comboPub.FormattingEnabled = true;
            this.comboPub.Location = new System.Drawing.Point(471, 39);
            this.comboPub.Name = "comboPub";
            this.comboPub.Size = new System.Drawing.Size(139, 21);
            this.comboPub.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Author";
            // 
            // comboAuth
            // 
            this.comboAuth.FormattingEnabled = true;
            this.comboAuth.Location = new System.Drawing.Point(246, 39);
            this.comboAuth.Name = "comboAuth";
            this.comboAuth.Size = new System.Drawing.Size(139, 21);
            this.comboAuth.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(603, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Price";
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(640, 13);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(61, 20);
            this.textPrice.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ISBN";
            // 
            // textISBN
            // 
            this.textISBN.Location = new System.Drawing.Point(47, 13);
            this.textISBN.Name = "textISBN";
            this.textISBN.Size = new System.Drawing.Size(139, 20);
            this.textISBN.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pages";
            // 
            // textPages
            // 
            this.textPages.Location = new System.Drawing.Point(528, 13);
            this.textPages.Name = "textPages";
            this.textPages.Size = new System.Drawing.Size(61, 20);
            this.textPages.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Year";
            // 
            // textYear
            // 
            this.textYear.Location = new System.Drawing.Point(410, 13);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(61, 20);
            this.textYear.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title";
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(230, 13);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(139, 20);
            this.textTitle.TabIndex = 3;
            // 
            // btnSearchBooks
            // 
            this.btnSearchBooks.Location = new System.Drawing.Point(345, 97);
            this.btnSearchBooks.Name = "btnSearchBooks";
            this.btnSearchBooks.Size = new System.Drawing.Size(71, 23);
            this.btnSearchBooks.TabIndex = 2;
            this.btnSearchBooks.Text = "Search";
            this.btnSearchBooks.UseVisualStyleBackColor = true;
            this.btnSearchBooks.Click += new System.EventHandler(this.btnSearchBooks_Click);
            // 
            // searchBoxBooks
            // 
            this.searchBoxBooks.Location = new System.Drawing.Point(12, 99);
            this.searchBoxBooks.Name = "searchBoxBooks";
            this.searchBoxBooks.Size = new System.Drawing.Size(327, 20);
            this.searchBoxBooks.TabIndex = 1;
            // 
            // booksGrid
            // 
            this.booksGrid.AllowUserToAddRows = false;
            this.booksGrid.AllowUserToDeleteRows = false;
            this.booksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksGrid.Location = new System.Drawing.Point(7, 125);
            this.booksGrid.Name = "booksGrid";
            this.booksGrid.ReadOnly = true;
            this.booksGrid.Size = new System.Drawing.Size(778, 291);
            this.booksGrid.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAddPub);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.textNamePub);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.textPhonePub);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.textAddressPub);
            this.tabPage2.Controls.Add(this.btnSearchPublisher);
            this.tabPage2.Controls.Add(this.searchBoxPublisher);
            this.tabPage2.Controls.Add(this.gridPublisher);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Publishers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddPub
            // 
            this.btnAddPub.Location = new System.Drawing.Point(630, 22);
            this.btnAddPub.Name = "btnAddPub";
            this.btnAddPub.Size = new System.Drawing.Size(127, 23);
            this.btnAddPub.TabIndex = 17;
            this.btnAddPub.Text = "Add New";
            this.btnAddPub.UseVisualStyleBackColor = true;
            this.btnAddPub.Click += new System.EventHandler(this.btnAddPub_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Name";
            // 
            // textNamePub
            // 
            this.textNamePub.Location = new System.Drawing.Point(63, 25);
            this.textNamePub.Name = "textNamePub";
            this.textNamePub.Size = new System.Drawing.Size(139, 20);
            this.textNamePub.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(432, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Phone";
            // 
            // textPhonePub
            // 
            this.textPhonePub.Location = new System.Drawing.Point(476, 25);
            this.textPhonePub.Name = "textPhonePub";
            this.textPhonePub.Size = new System.Drawing.Size(129, 20);
            this.textPhonePub.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(224, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Address";
            // 
            // textAddressPub
            // 
            this.textAddressPub.Location = new System.Drawing.Point(275, 25);
            this.textAddressPub.Name = "textAddressPub";
            this.textAddressPub.Size = new System.Drawing.Size(139, 20);
            this.textAddressPub.TabIndex = 11;
            // 
            // btnSearchPublisher
            // 
            this.btnSearchPublisher.Location = new System.Drawing.Point(476, 94);
            this.btnSearchPublisher.Name = "btnSearchPublisher";
            this.btnSearchPublisher.Size = new System.Drawing.Size(71, 23);
            this.btnSearchPublisher.TabIndex = 5;
            this.btnSearchPublisher.Text = "Search";
            this.btnSearchPublisher.UseVisualStyleBackColor = true;
            this.btnSearchPublisher.Click += new System.EventHandler(this.btnSearchPublisher_Click);
            // 
            // searchBoxPublisher
            // 
            this.searchBoxPublisher.Location = new System.Drawing.Point(198, 95);
            this.searchBoxPublisher.Name = "searchBoxPublisher";
            this.searchBoxPublisher.Size = new System.Drawing.Size(249, 20);
            this.searchBoxPublisher.TabIndex = 4;
            // 
            // gridPublisher
            // 
            this.gridPublisher.AllowUserToAddRows = false;
            this.gridPublisher.AllowUserToDeleteRows = false;
            this.gridPublisher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPublisher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPublisher.Location = new System.Drawing.Point(7, 121);
            this.gridPublisher.Name = "gridPublisher";
            this.gridPublisher.ReadOnly = true;
            this.gridPublisher.Size = new System.Drawing.Size(778, 290);
            this.gridPublisher.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAddAuthor);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.textNameAuth);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.textAddressAuth);
            this.tabPage3.Controls.Add(this.btnSearchAuthor);
            this.tabPage3.Controls.Add(this.searchBoxAuthor);
            this.tabPage3.Controls.Add(this.gridAuthor);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Authors";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(525, 30);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(127, 23);
            this.btnAddAuthor.TabIndex = 24;
            this.btnAddAuthor.Text = "Add New";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(96, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Name";
            // 
            // textNameAuth
            // 
            this.textNameAuth.Location = new System.Drawing.Point(134, 30);
            this.textNameAuth.Name = "textNameAuth";
            this.textNameAuth.Size = new System.Drawing.Size(139, 20);
            this.textNameAuth.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(295, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Address";
            // 
            // textAddressAuth
            // 
            this.textAddressAuth.Location = new System.Drawing.Point(346, 30);
            this.textAddressAuth.Name = "textAddressAuth";
            this.textAddressAuth.Size = new System.Drawing.Size(139, 20);
            this.textAddressAuth.TabIndex = 18;
            // 
            // btnSearchAuthor
            // 
            this.btnSearchAuthor.Location = new System.Drawing.Point(477, 99);
            this.btnSearchAuthor.Name = "btnSearchAuthor";
            this.btnSearchAuthor.Size = new System.Drawing.Size(71, 23);
            this.btnSearchAuthor.TabIndex = 5;
            this.btnSearchAuthor.Text = "Search";
            this.btnSearchAuthor.UseVisualStyleBackColor = true;
            this.btnSearchAuthor.Click += new System.EventHandler(this.btnSearchAuthor_Click);
            // 
            // searchBoxAuthor
            // 
            this.searchBoxAuthor.Location = new System.Drawing.Point(199, 100);
            this.searchBoxAuthor.Name = "searchBoxAuthor";
            this.searchBoxAuthor.Size = new System.Drawing.Size(249, 20);
            this.searchBoxAuthor.TabIndex = 4;
            // 
            // gridAuthor
            // 
            this.gridAuthor.AllowUserToAddRows = false;
            this.gridAuthor.AllowUserToDeleteRows = false;
            this.gridAuthor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAuthor.Location = new System.Drawing.Point(7, 126);
            this.gridAuthor.Name = "gridAuthor";
            this.gridAuthor.ReadOnly = true;
            this.gridAuthor.Size = new System.Drawing.Size(778, 285);
            this.gridAuthor.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnUpdate);
            this.tabPage4.Controls.Add(this.comboBox1);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.btnSearchOrdera);
            this.tabPage4.Controls.Add(this.searchBoxOrders);
            this.tabPage4.Controls.Add(this.gridOrders);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Track Orders";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnSearchOrdera
            // 
            this.btnSearchOrdera.Location = new System.Drawing.Point(478, 22);
            this.btnSearchOrdera.Name = "btnSearchOrdera";
            this.btnSearchOrdera.Size = new System.Drawing.Size(71, 23);
            this.btnSearchOrdera.TabIndex = 5;
            this.btnSearchOrdera.Text = "Search";
            this.btnSearchOrdera.UseVisualStyleBackColor = true;
            this.btnSearchOrdera.Click += new System.EventHandler(this.btnSearchOrdera_Click);
            // 
            // searchBoxOrders
            // 
            this.searchBoxOrders.Location = new System.Drawing.Point(200, 23);
            this.searchBoxOrders.Name = "searchBoxOrders";
            this.searchBoxOrders.Size = new System.Drawing.Size(249, 20);
            this.searchBoxOrders.TabIndex = 4;
            // 
            // gridOrders
            // 
            this.gridOrders.AllowUserToAddRows = false;
            this.gridOrders.AllowUserToDeleteRows = false;
            this.gridOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrders.Location = new System.Drawing.Point(7, 65);
            this.gridOrders.Name = "gridOrders";
            this.gridOrders.ReadOnly = true;
            this.gridOrders.Size = new System.Drawing.Size(778, 302);
            this.gridOrders.TabIndex = 3;
            // 
            // bookstoreDataSet
            // 
            this.bookstoreDataSet.DataSetName = "bookstoreDataSet";
            this.bookstoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(710, 97);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(71, 23);
            this.btnDeleteBook.TabIndex = 20;
            this.btnDeleteBook.Text = "Delete";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(714, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Qty.";
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(746, 13);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(35, 20);
            this.textQuantity.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(184, 386);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Change Status";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pending",
            "Shipped",
            "Delivered"});
            this.comboBox1.Location = new System.Drawing.Point(280, 383);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(478, 382);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(71, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnUpdateQty
            // 
            this.btnUpdateQty.Location = new System.Drawing.Point(563, 97);
            this.btnUpdateQty.Name = "btnUpdateQty";
            this.btnUpdateQty.Size = new System.Drawing.Size(106, 23);
            this.btnUpdateQty.TabIndex = 24;
            this.btnUpdateQty.Text = "Update Quantity";
            this.btnUpdateQty.UseVisualStyleBackColor = true;
            this.btnUpdateQty.Click += new System.EventHandler(this.btnUpdateQty_Click);
            // 
            // textUpdateQuantity
            // 
            this.textUpdateQuantity.Location = new System.Drawing.Point(471, 99);
            this.textUpdateQuantity.Name = "textUpdateQuantity";
            this.textUpdateQuantity.Size = new System.Drawing.Size(86, 20);
            this.textUpdateQuantity.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "My Book Store";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPublisher)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthor)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookstoreDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSearchBooks;
        private System.Windows.Forms.TextBox searchBoxBooks;
        private System.Windows.Forms.DataGridView booksGrid;
        private System.Windows.Forms.Button btnSearchPublisher;
        private System.Windows.Forms.TextBox searchBoxPublisher;
        private System.Windows.Forms.DataGridView gridPublisher;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSearchAuthor;
        private System.Windows.Forms.TextBox searchBoxAuthor;
        private System.Windows.Forms.DataGridView gridAuthor;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnSearchOrdera;
        private System.Windows.Forms.TextBox searchBoxOrders;
        private System.Windows.Forms.DataGridView gridOrders;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textISBN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboPub;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboAuth;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboGenre;
        private System.Windows.Forms.Button btnAddPub;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textNamePub;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textPhonePub;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textAddressPub;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textNameAuth;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textAddressAuth;
        private bookstoreDataSet bookstoreDataSet;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnUpdateQty;
        private System.Windows.Forms.TextBox textUpdateQuantity;
    }
}

