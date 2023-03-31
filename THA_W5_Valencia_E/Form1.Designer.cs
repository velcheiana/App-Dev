namespace THA_W5_Valencia_E
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
            this.lbl_Product = new System.Windows.Forms.Label();
            this.btn_All = new System.Windows.Forms.Button();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.comboBox_Filter = new System.Windows.Forms.ComboBox();
            this.DGV_Product = new System.Windows.Forms.DataGridView();
            this.lbl_Category1 = new System.Windows.Forms.Label();
            this.DGV_Category = new System.Windows.Forms.DataGridView();
            this.lbl_Details = new System.Windows.Forms.Label();
            this.lbl_Nama = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.textBox_Nama = new System.Windows.Forms.TextBox();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.lbl_Harga = new System.Windows.Forms.Label();
            this.textBox_Harga = new System.Windows.Forms.TextBox();
            this.lbl_Stock = new System.Windows.Forms.Label();
            this.textBox_Stock = new System.Windows.Forms.TextBox();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.btn_editProduct = new System.Windows.Forms.Button();
            this.btn_removeProduct = new System.Windows.Forms.Button();
            this.lbl_Nama2 = new System.Windows.Forms.Label();
            this.textBox_Nama2 = new System.Windows.Forms.TextBox();
            this.btn_addCategory = new System.Windows.Forms.Button();
            this.btn_RemoveCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Category)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Product
            // 
            this.lbl_Product.AutoSize = true;
            this.lbl_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product.Location = new System.Drawing.Point(12, 40);
            this.lbl_Product.Name = "lbl_Product";
            this.lbl_Product.Size = new System.Drawing.Size(60, 16);
            this.lbl_Product.TabIndex = 0;
            this.lbl_Product.Text = "Product";
            // 
            // btn_All
            // 
            this.btn_All.Location = new System.Drawing.Point(130, 40);
            this.btn_All.Name = "btn_All";
            this.btn_All.Size = new System.Drawing.Size(45, 21);
            this.btn_All.TabIndex = 1;
            this.btn_All.Text = "All";
            this.btn_All.UseVisualStyleBackColor = true;
            this.btn_All.Click += new System.EventHandler(this.btn_All_Click);
            // 
            // btn_Filter
            // 
            this.btn_Filter.Location = new System.Drawing.Point(181, 40);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(45, 21);
            this.btn_Filter.TabIndex = 0;
            this.btn_Filter.Text = "Filter:";
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // comboBox_Filter
            // 
            this.comboBox_Filter.Enabled = false;
            this.comboBox_Filter.FormattingEnabled = true;
            this.comboBox_Filter.Location = new System.Drawing.Point(232, 40);
            this.comboBox_Filter.Name = "comboBox_Filter";
            this.comboBox_Filter.Size = new System.Drawing.Size(78, 21);
            this.comboBox_Filter.TabIndex = 2;
            // 
            // DGV_Product
            // 
            this.DGV_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Product.Location = new System.Drawing.Point(15, 67);
            this.DGV_Product.Name = "DGV_Product";
            this.DGV_Product.Size = new System.Drawing.Size(333, 187);
            this.DGV_Product.TabIndex = 3;
            // 
            // lbl_Category1
            // 
            this.lbl_Category1.AutoSize = true;
            this.lbl_Category1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category1.Location = new System.Drawing.Point(379, 42);
            this.lbl_Category1.Name = "lbl_Category1";
            this.lbl_Category1.Size = new System.Drawing.Size(70, 16);
            this.lbl_Category1.TabIndex = 4;
            this.lbl_Category1.Text = "Category";
            // 
            // DGV_Category
            // 
            this.DGV_Category.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Category.Location = new System.Drawing.Point(382, 67);
            this.DGV_Category.Name = "DGV_Category";
            this.DGV_Category.Size = new System.Drawing.Size(176, 158);
            this.DGV_Category.TabIndex = 5;
            // 
            // lbl_Details
            // 
            this.lbl_Details.AutoSize = true;
            this.lbl_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Details.Location = new System.Drawing.Point(15, 278);
            this.lbl_Details.Name = "lbl_Details";
            this.lbl_Details.Size = new System.Drawing.Size(56, 16);
            this.lbl_Details.TabIndex = 6;
            this.lbl_Details.Text = "Details";
            // 
            // lbl_Nama
            // 
            this.lbl_Nama.AutoSize = true;
            this.lbl_Nama.Location = new System.Drawing.Point(15, 306);
            this.lbl_Nama.Name = "lbl_Nama";
            this.lbl_Nama.Size = new System.Drawing.Size(41, 13);
            this.lbl_Nama.TabIndex = 7;
            this.lbl_Nama.Text = "Nama: ";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Location = new System.Drawing.Point(15, 332);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(52, 13);
            this.lbl_Category.TabIndex = 8;
            this.lbl_Category.Text = "Category:";
            // 
            // textBox_Nama
            // 
            this.textBox_Nama.Location = new System.Drawing.Point(73, 303);
            this.textBox_Nama.Name = "textBox_Nama";
            this.textBox_Nama.Size = new System.Drawing.Size(275, 20);
            this.textBox_Nama.TabIndex = 9;
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(73, 329);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(84, 21);
            this.comboBox_Category.TabIndex = 10;
            // 
            // lbl_Harga
            // 
            this.lbl_Harga.AutoSize = true;
            this.lbl_Harga.Location = new System.Drawing.Point(15, 358);
            this.lbl_Harga.Name = "lbl_Harga";
            this.lbl_Harga.Size = new System.Drawing.Size(42, 13);
            this.lbl_Harga.TabIndex = 11;
            this.lbl_Harga.Text = "Harga: ";
            // 
            // textBox_Harga
            // 
            this.textBox_Harga.Location = new System.Drawing.Point(73, 356);
            this.textBox_Harga.Name = "textBox_Harga";
            this.textBox_Harga.Size = new System.Drawing.Size(84, 20);
            this.textBox_Harga.TabIndex = 12;
            this.textBox_Harga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Harga_KeyPress);
            // 
            // lbl_Stock
            // 
            this.lbl_Stock.AutoSize = true;
            this.lbl_Stock.Location = new System.Drawing.Point(15, 385);
            this.lbl_Stock.Name = "lbl_Stock";
            this.lbl_Stock.Size = new System.Drawing.Size(38, 13);
            this.lbl_Stock.TabIndex = 13;
            this.lbl_Stock.Text = "Stock:";
            // 
            // textBox_Stock
            // 
            this.textBox_Stock.Location = new System.Drawing.Point(73, 382);
            this.textBox_Stock.Name = "textBox_Stock";
            this.textBox_Stock.Size = new System.Drawing.Size(84, 20);
            this.textBox_Stock.TabIndex = 14;
            this.textBox_Stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Stock_KeyPress);
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.BackColor = System.Drawing.Color.Lime;
            this.btn_addProduct.Location = new System.Drawing.Point(171, 356);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(55, 42);
            this.btn_addProduct.TabIndex = 15;
            this.btn_addProduct.Text = "Add Product";
            this.btn_addProduct.UseVisualStyleBackColor = false;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // btn_editProduct
            // 
            this.btn_editProduct.BackColor = System.Drawing.Color.Yellow;
            this.btn_editProduct.Location = new System.Drawing.Point(232, 356);
            this.btn_editProduct.Name = "btn_editProduct";
            this.btn_editProduct.Size = new System.Drawing.Size(55, 42);
            this.btn_editProduct.TabIndex = 16;
            this.btn_editProduct.Text = "Edit Product";
            this.btn_editProduct.UseVisualStyleBackColor = false;
            this.btn_editProduct.Click += new System.EventHandler(this.btn_editProduct_Click);
            // 
            // btn_removeProduct
            // 
            this.btn_removeProduct.BackColor = System.Drawing.Color.Red;
            this.btn_removeProduct.Location = new System.Drawing.Point(293, 356);
            this.btn_removeProduct.Name = "btn_removeProduct";
            this.btn_removeProduct.Size = new System.Drawing.Size(55, 42);
            this.btn_removeProduct.TabIndex = 17;
            this.btn_removeProduct.Text = "Remove Product";
            this.btn_removeProduct.UseVisualStyleBackColor = false;
            this.btn_removeProduct.Click += new System.EventHandler(this.btn_removeProduct_Click);
            // 
            // lbl_Nama2
            // 
            this.lbl_Nama2.AutoSize = true;
            this.lbl_Nama2.Location = new System.Drawing.Point(382, 240);
            this.lbl_Nama2.Name = "lbl_Nama2";
            this.lbl_Nama2.Size = new System.Drawing.Size(41, 13);
            this.lbl_Nama2.TabIndex = 18;
            this.lbl_Nama2.Text = "Nama: ";
            // 
            // textBox_Nama2
            // 
            this.textBox_Nama2.Location = new System.Drawing.Point(429, 237);
            this.textBox_Nama2.Name = "textBox_Nama2";
            this.textBox_Nama2.Size = new System.Drawing.Size(129, 20);
            this.textBox_Nama2.TabIndex = 19;
            // 
            // btn_addCategory
            // 
            this.btn_addCategory.BackColor = System.Drawing.Color.Lime;
            this.btn_addCategory.Location = new System.Drawing.Point(429, 265);
            this.btn_addCategory.Name = "btn_addCategory";
            this.btn_addCategory.Size = new System.Drawing.Size(58, 42);
            this.btn_addCategory.TabIndex = 20;
            this.btn_addCategory.Text = "Add Category";
            this.btn_addCategory.UseVisualStyleBackColor = false;
            this.btn_addCategory.Click += new System.EventHandler(this.btn_addCategory_Click);
            // 
            // btn_RemoveCategory
            // 
            this.btn_RemoveCategory.BackColor = System.Drawing.Color.Red;
            this.btn_RemoveCategory.Location = new System.Drawing.Point(500, 265);
            this.btn_RemoveCategory.Name = "btn_RemoveCategory";
            this.btn_RemoveCategory.Size = new System.Drawing.Size(58, 42);
            this.btn_RemoveCategory.TabIndex = 21;
            this.btn_RemoveCategory.Text = "Remove Category";
            this.btn_RemoveCategory.UseVisualStyleBackColor = false;
            this.btn_RemoveCategory.Click += new System.EventHandler(this.btn_RemoveCategory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_RemoveCategory);
            this.Controls.Add(this.btn_addCategory);
            this.Controls.Add(this.textBox_Nama2);
            this.Controls.Add(this.lbl_Nama2);
            this.Controls.Add(this.btn_removeProduct);
            this.Controls.Add(this.btn_editProduct);
            this.Controls.Add(this.btn_addProduct);
            this.Controls.Add(this.textBox_Stock);
            this.Controls.Add(this.lbl_Stock);
            this.Controls.Add(this.textBox_Harga);
            this.Controls.Add(this.lbl_Harga);
            this.Controls.Add(this.comboBox_Category);
            this.Controls.Add(this.textBox_Nama);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.lbl_Nama);
            this.Controls.Add(this.lbl_Details);
            this.Controls.Add(this.DGV_Category);
            this.Controls.Add(this.lbl_Category1);
            this.Controls.Add(this.DGV_Product);
            this.Controls.Add(this.comboBox_Filter);
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.btn_All);
            this.Controls.Add(this.lbl_Product);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Product;
        private System.Windows.Forms.Button btn_All;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.ComboBox comboBox_Filter;
        private System.Windows.Forms.DataGridView DGV_Product;
        private System.Windows.Forms.Label lbl_Category1;
        private System.Windows.Forms.DataGridView DGV_Category;
        private System.Windows.Forms.Label lbl_Details;
        private System.Windows.Forms.Label lbl_Nama;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.TextBox textBox_Nama;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.Label lbl_Harga;
        private System.Windows.Forms.TextBox textBox_Harga;
        private System.Windows.Forms.Label lbl_Stock;
        private System.Windows.Forms.TextBox textBox_Stock;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.Button btn_editProduct;
        private System.Windows.Forms.Button btn_removeProduct;
        private System.Windows.Forms.Label lbl_Nama2;
        private System.Windows.Forms.TextBox textBox_Nama2;
        private System.Windows.Forms.Button btn_addCategory;
        private System.Windows.Forms.Button btn_RemoveCategory;
    }
}

