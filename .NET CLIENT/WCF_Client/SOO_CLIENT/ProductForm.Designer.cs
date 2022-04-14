namespace SOO_CLIENT
{
    partial class ProductForm
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
            this.AllProducts = new System.Windows.Forms.GroupBox();
            this.products = new System.Windows.Forms.DataGridView();
            this.ProductOperations = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.GetProductByName = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GetProductByIdButton = new System.Windows.Forms.Button();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.UpdateProductButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.ProductId = new System.Windows.Forms.TextBox();
            this.isActive = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Barcode = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.StockIn = new System.Windows.Forms.Button();
            this.StockOut = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CheckStockById = new System.Windows.Forms.Button();
            this.CheckStockByName = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.AllProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.products)).BeginInit();
            this.ProductOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllProducts
            // 
            this.AllProducts.Controls.Add(this.products);
            this.AllProducts.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllProducts.Location = new System.Drawing.Point(12, 470);
            this.AllProducts.Name = "AllProducts";
            this.AllProducts.Size = new System.Drawing.Size(1227, 384);
            this.AllProducts.TabIndex = 6;
            this.AllProducts.TabStop = false;
            this.AllProducts.Text = "GET ALL PRODUCTS";
            // 
            // products
            // 
            this.products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.products.Location = new System.Drawing.Point(9, 34);
            this.products.Name = "products";
            this.products.ReadOnly = true;
            this.products.RowHeadersWidth = 35;
            this.products.RowTemplate.Height = 28;
            this.products.Size = new System.Drawing.Size(1212, 344);
            this.products.TabIndex = 2;
            // 
            // ProductOperations
            // 
            this.ProductOperations.Controls.Add(this.label14);
            this.ProductOperations.Controls.Add(this.label13);
            this.ProductOperations.Controls.Add(this.CheckStockByName);
            this.ProductOperations.Controls.Add(this.CheckStockById);
            this.ProductOperations.Controls.Add(this.label12);
            this.ProductOperations.Controls.Add(this.label11);
            this.ProductOperations.Controls.Add(this.StockOut);
            this.ProductOperations.Controls.Add(this.StockIn);
            this.ProductOperations.Controls.Add(this.label10);
            this.ProductOperations.Controls.Add(this.GetProductByName);
            this.ProductOperations.Controls.Add(this.label9);
            this.ProductOperations.Controls.Add(this.label8);
            this.ProductOperations.Controls.Add(this.label7);
            this.ProductOperations.Controls.Add(this.label6);
            this.ProductOperations.Controls.Add(this.GetProductByIdButton);
            this.ProductOperations.Controls.Add(this.DeleteProductButton);
            this.ProductOperations.Controls.Add(this.UpdateProductButton);
            this.ProductOperations.Controls.Add(this.label16);
            this.ProductOperations.Controls.Add(this.ProductId);
            this.ProductOperations.Controls.Add(this.isActive);
            this.ProductOperations.Controls.Add(this.label5);
            this.ProductOperations.Controls.Add(this.label4);
            this.ProductOperations.Controls.Add(this.label3);
            this.ProductOperations.Controls.Add(this.label2);
            this.ProductOperations.Controls.Add(this.label1);
            this.ProductOperations.Controls.Add(this.Barcode);
            this.ProductOperations.Controls.Add(this.Quantity);
            this.ProductOperations.Controls.Add(this.Price);
            this.ProductOperations.Controls.Add(this.ProductName);
            this.ProductOperations.Controls.Add(this.AddProductButton);
            this.ProductOperations.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductOperations.Location = new System.Drawing.Point(15, 21);
            this.ProductOperations.Name = "ProductOperations";
            this.ProductOperations.Size = new System.Drawing.Size(1224, 443);
            this.ProductOperations.TabIndex = 5;
            this.ProductOperations.TabStop = false;
            this.ProductOperations.Text = "PRODUCT OPERATIONS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(693, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 28);
            this.label10.TabIndex = 23;
            this.label10.Text = "Insert Name only";
            // 
            // GetProductByName
            // 
            this.GetProductByName.Location = new System.Drawing.Point(451, 205);
            this.GetProductByName.Name = "GetProductByName";
            this.GetProductByName.Size = new System.Drawing.Size(236, 37);
            this.GetProductByName.TabIndex = 22;
            this.GetProductByName.Text = "Get Product (by Name)";
            this.GetProductByName.UseVisualStyleBackColor = true;
            this.GetProductByName.Click += new System.EventHandler(this.GetProductByName_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(693, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 28);
            this.label9.TabIndex = 21;
            this.label9.Text = "Insert Id only";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(693, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 28);
            this.label8.TabIndex = 20;
            this.label8.Text = "Insert Id only";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(693, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(292, 28);
            this.label7.TabIndex = 19;
            this.label7.Text = "Insert everything including Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(693, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(525, 28);
            this.label6.TabIndex = 18;
            this.label6.Text = "Insert everything except for Id. Thats auto generated.";
            // 
            // GetProductByIdButton
            // 
            this.GetProductByIdButton.Location = new System.Drawing.Point(451, 162);
            this.GetProductByIdButton.Name = "GetProductByIdButton";
            this.GetProductByIdButton.Size = new System.Drawing.Size(236, 37);
            this.GetProductByIdButton.TabIndex = 17;
            this.GetProductByIdButton.Text = "Get Product (by Id)";
            this.GetProductByIdButton.UseVisualStyleBackColor = true;
            this.GetProductByIdButton.Click += new System.EventHandler(this.GetProductByIdButton_Click);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Location = new System.Drawing.Point(451, 119);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(236, 37);
            this.DeleteProductButton.TabIndex = 16;
            this.DeleteProductButton.Text = "Delete Product";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // UpdateProductButton
            // 
            this.UpdateProductButton.Location = new System.Drawing.Point(451, 78);
            this.UpdateProductButton.Name = "UpdateProductButton";
            this.UpdateProductButton.Size = new System.Drawing.Size(236, 35);
            this.UpdateProductButton.TabIndex = 15;
            this.UpdateProductButton.Text = "Update Product";
            this.UpdateProductButton.UseVisualStyleBackColor = true;
            this.UpdateProductButton.Click += new System.EventHandler(this.UpdateProductButton_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 28);
            this.label16.TabIndex = 14;
            this.label16.Text = "Id";
            // 
            // ProductId
            // 
            this.ProductId.Location = new System.Drawing.Point(125, 37);
            this.ProductId.Name = "ProductId";
            this.ProductId.Size = new System.Drawing.Size(293, 35);
            this.ProductId.TabIndex = 13;
            // 
            // isActive
            // 
            this.isActive.AutoSize = true;
            this.isActive.Location = new System.Drawing.Point(125, 250);
            this.isActive.Name = "isActive";
            this.isActive.Size = new System.Drawing.Size(22, 21);
            this.isActive.TabIndex = 12;
            this.isActive.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "IsActive";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Barcode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // Barcode
            // 
            this.Barcode.Location = new System.Drawing.Point(125, 199);
            this.Barcode.Name = "Barcode";
            this.Barcode.Size = new System.Drawing.Size(293, 35);
            this.Barcode.TabIndex = 4;
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(125, 158);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(293, 35);
            this.Quantity.TabIndex = 3;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(125, 117);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(293, 35);
            this.Price.TabIndex = 2;
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(125, 76);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(293, 35);
            this.ProductName.TabIndex = 1;
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(451, 37);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(236, 35);
            this.AddProductButton.TabIndex = 0;
            this.AddProductButton.Text = "Add Product";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // StockIn
            // 
            this.StockIn.Location = new System.Drawing.Point(451, 250);
            this.StockIn.Name = "StockIn";
            this.StockIn.Size = new System.Drawing.Size(236, 37);
            this.StockIn.TabIndex = 24;
            this.StockIn.Text = "StockIn";
            this.StockIn.UseVisualStyleBackColor = true;
            this.StockIn.Click += new System.EventHandler(this.StockIn_Click);
            // 
            // StockOut
            // 
            this.StockOut.Location = new System.Drawing.Point(451, 295);
            this.StockOut.Name = "StockOut";
            this.StockOut.Size = new System.Drawing.Size(236, 37);
            this.StockOut.TabIndex = 25;
            this.StockOut.Text = "StockOut";
            this.StockOut.UseVisualStyleBackColor = true;
            this.StockOut.Click += new System.EventHandler(this.StockOut_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(693, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(225, 28);
            this.label11.TabIndex = 26;
            this.label11.Text = "Insert Id and Quantity";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(693, 299);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(225, 28);
            this.label12.TabIndex = 27;
            this.label12.Text = "Insert Id and Quantity";
            // 
            // CheckStockById
            // 
            this.CheckStockById.Location = new System.Drawing.Point(451, 338);
            this.CheckStockById.Name = "CheckStockById";
            this.CheckStockById.Size = new System.Drawing.Size(236, 37);
            this.CheckStockById.TabIndex = 28;
            this.CheckStockById.Text = "Check Stock(By id)";
            this.CheckStockById.UseVisualStyleBackColor = true;
            this.CheckStockById.Click += new System.EventHandler(this.CheckStockById_Click);
            // 
            // CheckStockByName
            // 
            this.CheckStockByName.Location = new System.Drawing.Point(451, 381);
            this.CheckStockByName.Name = "CheckStockByName";
            this.CheckStockByName.Size = new System.Drawing.Size(236, 37);
            this.CheckStockByName.TabIndex = 29;
            this.CheckStockByName.Text = "Check Stock(By Name)";
            this.CheckStockByName.UseVisualStyleBackColor = true;
            this.CheckStockByName.Click += new System.EventHandler(this.CheckStockByName_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(693, 342);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 28);
            this.label13.TabIndex = 30;
            this.label13.Text = "Insert Id only";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(693, 385);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 28);
            this.label14.TabIndex = 31;
            this.label14.Text = "Insert Id only";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 866);
            this.Controls.Add(this.AllProducts);
            this.Controls.Add(this.ProductOperations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.AllProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.products)).EndInit();
            this.ProductOperations.ResumeLayout(false);
            this.ProductOperations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AllProducts;
        private System.Windows.Forms.DataGridView products;
        private System.Windows.Forms.GroupBox ProductOperations;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button GetProductByName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button GetProductByIdButton;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.Button UpdateProductButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox ProductId;
        private System.Windows.Forms.CheckBox isActive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Barcode;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button StockOut;
        private System.Windows.Forms.Button StockIn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button CheckStockByName;
        private System.Windows.Forms.Button CheckStockById;

    }
}