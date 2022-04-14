namespace SOO_CLIENT
{
    partial class InvoiceForm
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
            this.AllInvoices = new System.Windows.Forms.GroupBox();
            this.invoices = new System.Windows.Forms.DataGridView();
            this.InvoiceOperations = new System.Windows.Forms.GroupBox();
            this.InvoiceDateTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GetInvoiceByIdButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.InvoiceId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PaymentMethod = new System.Windows.Forms.TextBox();
            this.TotalAmount = new System.Windows.Forms.TextBox();
            this.PaymentId = new System.Windows.Forms.TextBox();
            this.OrderId = new System.Windows.Forms.TextBox();
            this.GenerateInvoiceButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.CustomerId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AllInvoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoices)).BeginInit();
            this.InvoiceOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllInvoices
            // 
            this.AllInvoices.Controls.Add(this.invoices);
            this.AllInvoices.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllInvoices.Location = new System.Drawing.Point(12, 393);
            this.AllInvoices.Name = "AllInvoices";
            this.AllInvoices.Size = new System.Drawing.Size(1245, 482);
            this.AllInvoices.TabIndex = 10;
            this.AllInvoices.TabStop = false;
            this.AllInvoices.Text = "GET ALL INVOICES";
            // 
            // invoices
            // 
            this.invoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.invoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoices.Location = new System.Drawing.Point(6, 37);
            this.invoices.Name = "invoices";
            this.invoices.ReadOnly = true;
            this.invoices.RowHeadersWidth = 35;
            this.invoices.RowTemplate.Height = 28;
            this.invoices.Size = new System.Drawing.Size(1233, 434);
            this.invoices.TabIndex = 2;
            // 
            // InvoiceOperations
            // 
            this.InvoiceOperations.Controls.Add(this.label8);
            this.InvoiceOperations.Controls.Add(this.CustomerId);
            this.InvoiceOperations.Controls.Add(this.InvoiceDateTime);
            this.InvoiceOperations.Controls.Add(this.label5);
            this.InvoiceOperations.Controls.Add(this.label7);
            this.InvoiceOperations.Controls.Add(this.label6);
            this.InvoiceOperations.Controls.Add(this.GetInvoiceByIdButton);
            this.InvoiceOperations.Controls.Add(this.label16);
            this.InvoiceOperations.Controls.Add(this.InvoiceId);
            this.InvoiceOperations.Controls.Add(this.label4);
            this.InvoiceOperations.Controls.Add(this.label3);
            this.InvoiceOperations.Controls.Add(this.label2);
            this.InvoiceOperations.Controls.Add(this.label1);
            this.InvoiceOperations.Controls.Add(this.PaymentMethod);
            this.InvoiceOperations.Controls.Add(this.TotalAmount);
            this.InvoiceOperations.Controls.Add(this.PaymentId);
            this.InvoiceOperations.Controls.Add(this.OrderId);
            this.InvoiceOperations.Controls.Add(this.GenerateInvoiceButton);
            this.InvoiceOperations.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceOperations.Location = new System.Drawing.Point(12, 12);
            this.InvoiceOperations.Name = "InvoiceOperations";
            this.InvoiceOperations.Size = new System.Drawing.Size(1245, 375);
            this.InvoiceOperations.TabIndex = 9;
            this.InvoiceOperations.TabStop = false;
            this.InvoiceOperations.Text = "INVOICE OPERATIONS";
            // 
            // InvoiceDateTime
            // 
            this.InvoiceDateTime.Location = new System.Drawing.Point(147, 284);
            this.InvoiceDateTime.Name = "InvoiceDateTime";
            this.InvoiceDateTime.Size = new System.Drawing.Size(271, 35);
            this.InvoiceDateTime.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 28);
            this.label5.TabIndex = 24;
            this.label5.Text = "DateTime";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(716, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(504, 93);
            this.label6.TabIndex = 18;
            this.label6.Text = "This operation will be called from with in payment service because it depends on " +
    "some values that it can only get from payment service";
            // 
            // GetInvoiceByIdButton
            // 
            this.GetInvoiceByIdButton.Location = new System.Drawing.Point(451, 136);
            this.GetInvoiceByIdButton.Name = "GetInvoiceByIdButton";
            this.GetInvoiceByIdButton.Size = new System.Drawing.Size(259, 35);
            this.GetInvoiceByIdButton.TabIndex = 15;
            this.GetInvoiceByIdButton.Text = "Get Invoice by Id ";
            this.GetInvoiceByIdButton.UseVisualStyleBackColor = true;
            this.GetInvoiceByIdButton.Click += new System.EventHandler(this.GetInvoiceByIdButton_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 28);
            this.label16.TabIndex = 14;
            this.label16.Text = "Invoice Id";
            // 
            // InvoiceId
            // 
            this.InvoiceId.Location = new System.Drawing.Point(147, 37);
            this.InvoiceId.Name = "InvoiceId";
            this.InvoiceId.Size = new System.Drawing.Size(271, 35);
            this.InvoiceId.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Method";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Payment Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Order Id";
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.Location = new System.Drawing.Point(147, 242);
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.Size = new System.Drawing.Size(271, 35);
            this.PaymentMethod.TabIndex = 4;
            // 
            // TotalAmount
            // 
            this.TotalAmount.Location = new System.Drawing.Point(147, 201);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(271, 35);
            this.TotalAmount.TabIndex = 3;
            // 
            // PaymentId
            // 
            this.PaymentId.Location = new System.Drawing.Point(147, 160);
            this.PaymentId.Name = "PaymentId";
            this.PaymentId.Size = new System.Drawing.Size(271, 35);
            this.PaymentId.TabIndex = 2;
            // 
            // OrderId
            // 
            this.OrderId.Location = new System.Drawing.Point(147, 76);
            this.OrderId.Name = "OrderId";
            this.OrderId.Size = new System.Drawing.Size(271, 35);
            this.OrderId.TabIndex = 1;
            // 
            // GenerateInvoiceButton
            // 
            this.GenerateInvoiceButton.Enabled = false;
            this.GenerateInvoiceButton.Location = new System.Drawing.Point(451, 37);
            this.GenerateInvoiceButton.Name = "GenerateInvoiceButton";
            this.GenerateInvoiceButton.Size = new System.Drawing.Size(259, 35);
            this.GenerateInvoiceButton.TabIndex = 0;
            this.GenerateInvoiceButton.Text = "Generate Invoice";
            this.GenerateInvoiceButton.UseVisualStyleBackColor = true;
            this.GenerateInvoiceButton.Click += new System.EventHandler(this.GenerateInvoiceButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(716, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 28);
            this.label7.TabIndex = 19;
            this.label7.Text = "Insert Id only";
            // 
            // CustomerId
            // 
            this.CustomerId.Location = new System.Drawing.Point(147, 117);
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Size = new System.Drawing.Size(271, 35);
            this.CustomerId.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 28);
            this.label8.TabIndex = 29;
            this.label8.Text = "Customer Id";
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 886);
            this.Controls.Add(this.AllInvoices);
            this.Controls.Add(this.InvoiceOperations);
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
            this.AllInvoices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invoices)).EndInit();
            this.InvoiceOperations.ResumeLayout(false);
            this.InvoiceOperations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AllInvoices;
        private System.Windows.Forms.DataGridView invoices;
        private System.Windows.Forms.GroupBox InvoiceOperations;
        private System.Windows.Forms.TextBox InvoiceDateTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button GetInvoiceByIdButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox InvoiceId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PaymentMethod;
        private System.Windows.Forms.TextBox TotalAmount;
        private System.Windows.Forms.TextBox PaymentId;
        private System.Windows.Forms.TextBox OrderId;
        private System.Windows.Forms.Button GenerateInvoiceButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CustomerId;
    }
}