
namespace Book_Store
{
    partial class Dashboard
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
            this.booksGrid = new System.Windows.Forms.DataGridView();
            this.comboBooks = new System.Windows.Forms.ComboBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnAddToBasket = new System.Windows.Forms.Button();
            this.basketGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textShipAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAllOrders = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // booksGrid
            // 
            this.booksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksGrid.Location = new System.Drawing.Point(12, 114);
            this.booksGrid.Name = "booksGrid";
            this.booksGrid.Size = new System.Drawing.Size(397, 236);
            this.booksGrid.TabIndex = 0;
            // 
            // comboBooks
            // 
            this.comboBooks.FormattingEnabled = true;
            this.comboBooks.Location = new System.Drawing.Point(12, 63);
            this.comboBooks.Name = "comboBooks";
            this.comboBooks.Size = new System.Drawing.Size(397, 21);
            this.comboBooks.TabIndex = 1;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(718, 356);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(138, 46);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnAddToBasket
            // 
            this.btnAddToBasket.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToBasket.Location = new System.Drawing.Point(415, 189);
            this.btnAddToBasket.Name = "btnAddToBasket";
            this.btnAddToBasket.Size = new System.Drawing.Size(75, 42);
            this.btnAddToBasket.TabIndex = 3;
            this.btnAddToBasket.Text = "Add to Basket";
            this.btnAddToBasket.UseVisualStyleBackColor = true;
            this.btnAddToBasket.Click += new System.EventHandler(this.btnAddToBasket_Click);
            // 
            // basketGrid
            // 
            this.basketGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.basketGrid.Location = new System.Drawing.Point(496, 114);
            this.basketGrid.Name = "basketGrid";
            this.basketGrid.Size = new System.Drawing.Size(360, 236);
            this.basketGrid.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "All Books";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "My Basket";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dashboard";
            // 
            // textShipAddress
            // 
            this.textShipAddress.Location = new System.Drawing.Point(98, 356);
            this.textShipAddress.Multiline = true;
            this.textShipAddress.Name = "textShipAddress";
            this.textShipAddress.Size = new System.Drawing.Size(614, 46);
            this.textShipAddress.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Shipping";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Address";
            // 
            // btnAllOrders
            // 
            this.btnAllOrders.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllOrders.Location = new System.Drawing.Point(718, 54);
            this.btnAllOrders.Name = "btnAllOrders";
            this.btnAllOrders.Size = new System.Drawing.Size(138, 30);
            this.btnAllOrders.TabIndex = 11;
            this.btnAllOrders.Text = "My Orders";
            this.btnAllOrders.UseVisualStyleBackColor = true;
            this.btnAllOrders.Click += new System.EventHandler(this.btnAllOrders_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClear.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(415, 251);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 42);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear Basket";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 414);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAllOrders);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textShipAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.basketGrid);
            this.Controls.Add(this.btnAddToBasket);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.comboBooks);
            this.Controls.Add(this.booksGrid);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView booksGrid;
        private System.Windows.Forms.ComboBox comboBooks;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnAddToBasket;
        private System.Windows.Forms.DataGridView basketGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textShipAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAllOrders;
        private System.Windows.Forms.Button btnClear;
    }
}