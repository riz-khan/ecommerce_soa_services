namespace SOO_CLIENT
{
    partial class CustomerForm
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
            this.CustomerOperations = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.GetCustomerByName = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GetCustomerByIdButton = new System.Windows.Forms.Button();
            this.DeleteCustomerButton = new System.Windows.Forms.Button();
            this.UpdateCustomerButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.CustomerId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CardNumber = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CardName = new System.Windows.Forms.TextBox();
            this.CardCvv = new System.Windows.Forms.TextBox();
            this.CardExpiry = new System.Windows.Forms.TextBox();
            this.AllCustomers = new System.Windows.Forms.GroupBox();
            this.customers = new System.Windows.Forms.DataGridView();
            this.CustomerOperations.SuspendLayout();
            this.AllCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customers)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerOperations
            // 
            this.CustomerOperations.Controls.Add(this.CardExpiry);
            this.CustomerOperations.Controls.Add(this.CardCvv);
            this.CustomerOperations.Controls.Add(this.CardName);
            this.CustomerOperations.Controls.Add(this.label12);
            this.CustomerOperations.Controls.Add(this.label11);
            this.CustomerOperations.Controls.Add(this.label5);
            this.CustomerOperations.Controls.Add(this.label10);
            this.CustomerOperations.Controls.Add(this.GetCustomerByName);
            this.CustomerOperations.Controls.Add(this.label9);
            this.CustomerOperations.Controls.Add(this.label8);
            this.CustomerOperations.Controls.Add(this.label7);
            this.CustomerOperations.Controls.Add(this.label6);
            this.CustomerOperations.Controls.Add(this.GetCustomerByIdButton);
            this.CustomerOperations.Controls.Add(this.DeleteCustomerButton);
            this.CustomerOperations.Controls.Add(this.UpdateCustomerButton);
            this.CustomerOperations.Controls.Add(this.label16);
            this.CustomerOperations.Controls.Add(this.CustomerId);
            this.CustomerOperations.Controls.Add(this.label4);
            this.CustomerOperations.Controls.Add(this.label3);
            this.CustomerOperations.Controls.Add(this.label2);
            this.CustomerOperations.Controls.Add(this.label1);
            this.CustomerOperations.Controls.Add(this.CardNumber);
            this.CustomerOperations.Controls.Add(this.Phone);
            this.CustomerOperations.Controls.Add(this.Email);
            this.CustomerOperations.Controls.Add(this.CustomerName);
            this.CustomerOperations.Controls.Add(this.AddCustomerButton);
            this.CustomerOperations.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerOperations.Location = new System.Drawing.Point(12, 12);
            this.CustomerOperations.Name = "CustomerOperations";
            this.CustomerOperations.Size = new System.Drawing.Size(1245, 375);
            this.CustomerOperations.TabIndex = 7;
            this.CustomerOperations.TabStop = false;
            this.CustomerOperations.Text = "CUSTOMER OPERATIONS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(716, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 28);
            this.label10.TabIndex = 23;
            this.label10.Text = "Insert Name only";
            // 
            // GetCustomerByName
            // 
            this.GetCustomerByName.Location = new System.Drawing.Point(451, 205);
            this.GetCustomerByName.Name = "GetCustomerByName";
            this.GetCustomerByName.Size = new System.Drawing.Size(259, 37);
            this.GetCustomerByName.TabIndex = 22;
            this.GetCustomerByName.Text = "Get Customer (by Name)";
            this.GetCustomerByName.UseVisualStyleBackColor = true;
            this.GetCustomerByName.Click += new System.EventHandler(this.GetCustomerByName_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(716, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 28);
            this.label9.TabIndex = 21;
            this.label9.Text = "Insert Id only";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(716, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 28);
            this.label8.TabIndex = 20;
            this.label8.Text = "Insert Id only";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(716, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(292, 28);
            this.label7.TabIndex = 19;
            this.label7.Text = "Insert everything including Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(716, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(525, 28);
            this.label6.TabIndex = 18;
            this.label6.Text = "Insert everything except for Id. Thats auto generated.";
            // 
            // GetCustomerByIdButton
            // 
            this.GetCustomerByIdButton.Location = new System.Drawing.Point(451, 162);
            this.GetCustomerByIdButton.Name = "GetCustomerByIdButton";
            this.GetCustomerByIdButton.Size = new System.Drawing.Size(259, 37);
            this.GetCustomerByIdButton.TabIndex = 17;
            this.GetCustomerByIdButton.Text = "Get Customer (by Id)";
            this.GetCustomerByIdButton.UseVisualStyleBackColor = true;
            this.GetCustomerByIdButton.Click += new System.EventHandler(this.GetCustomerByIdButton_Click);
            // 
            // DeleteCustomerButton
            // 
            this.DeleteCustomerButton.Location = new System.Drawing.Point(451, 119);
            this.DeleteCustomerButton.Name = "DeleteCustomerButton";
            this.DeleteCustomerButton.Size = new System.Drawing.Size(259, 37);
            this.DeleteCustomerButton.TabIndex = 16;
            this.DeleteCustomerButton.Text = "Delete Customer";
            this.DeleteCustomerButton.UseVisualStyleBackColor = true;
            this.DeleteCustomerButton.Click += new System.EventHandler(this.DeleteCustomerButton_Click);
            // 
            // UpdateCustomerButton
            // 
            this.UpdateCustomerButton.Location = new System.Drawing.Point(451, 78);
            this.UpdateCustomerButton.Name = "UpdateCustomerButton";
            this.UpdateCustomerButton.Size = new System.Drawing.Size(259, 35);
            this.UpdateCustomerButton.TabIndex = 15;
            this.UpdateCustomerButton.Text = "Update Customer";
            this.UpdateCustomerButton.UseVisualStyleBackColor = true;
            this.UpdateCustomerButton.Click += new System.EventHandler(this.UpdateCustomerButton_Click);
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
            // CustomerId
            // 
            this.CustomerId.Location = new System.Drawing.Point(147, 37);
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Size = new System.Drawing.Size(271, 35);
            this.CustomerId.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "CardNumber";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email";
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
            // CardNumber
            // 
            this.CardNumber.Location = new System.Drawing.Point(147, 199);
            this.CardNumber.Name = "CardNumber";
            this.CardNumber.Size = new System.Drawing.Size(271, 35);
            this.CardNumber.TabIndex = 4;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(147, 158);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(271, 35);
            this.Phone.TabIndex = 3;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(147, 117);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(271, 35);
            this.Email.TabIndex = 2;
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(147, 76);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(271, 35);
            this.CustomerName.TabIndex = 1;
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Location = new System.Drawing.Point(451, 37);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(259, 35);
            this.AddCustomerButton.TabIndex = 0;
            this.AddCustomerButton.Text = "Add Customer";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 28);
            this.label5.TabIndex = 24;
            this.label5.Text = "CardName";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 28);
            this.label11.TabIndex = 25;
            this.label11.Text = "CardCvv";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 328);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 28);
            this.label12.TabIndex = 26;
            this.label12.Text = "CardExpiry";
            // 
            // CardName
            // 
            this.CardName.Location = new System.Drawing.Point(147, 241);
            this.CardName.Name = "CardName";
            this.CardName.Size = new System.Drawing.Size(271, 35);
            this.CardName.TabIndex = 27;
            // 
            // CardCvv
            // 
            this.CardCvv.Location = new System.Drawing.Point(147, 284);
            this.CardCvv.Name = "CardCvv";
            this.CardCvv.Size = new System.Drawing.Size(271, 35);
            this.CardCvv.TabIndex = 28;
            // 
            // CardExpiry
            // 
            this.CardExpiry.Location = new System.Drawing.Point(147, 325);
            this.CardExpiry.Name = "CardExpiry";
            this.CardExpiry.Size = new System.Drawing.Size(271, 35);
            this.CardExpiry.TabIndex = 29;
            // 
            // AllCustomers
            // 
            this.AllCustomers.Controls.Add(this.customers);
            this.AllCustomers.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllCustomers.Location = new System.Drawing.Point(12, 393);
            this.AllCustomers.Name = "AllCustomers";
            this.AllCustomers.Size = new System.Drawing.Size(1245, 482);
            this.AllCustomers.TabIndex = 8;
            this.AllCustomers.TabStop = false;
            this.AllCustomers.Text = "GET ALL CUSTOMERS";
            // 
            // customers
            // 
            this.customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customers.Location = new System.Drawing.Point(6, 37);
            this.customers.Name = "customers";
            this.customers.ReadOnly = true;
            this.customers.RowHeadersWidth = 35;
            this.customers.RowTemplate.Height = 28;
            this.customers.Size = new System.Drawing.Size(1233, 434);
            this.customers.TabIndex = 2;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 883);
            this.Controls.Add(this.AllCustomers);
            this.Controls.Add(this.CustomerOperations);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.CustomerOperations.ResumeLayout(false);
            this.CustomerOperations.PerformLayout();
            this.AllCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CustomerOperations;
        private System.Windows.Forms.TextBox CardExpiry;
        private System.Windows.Forms.TextBox CardCvv;
        private System.Windows.Forms.TextBox CardName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button GetCustomerByName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button GetCustomerByIdButton;
        private System.Windows.Forms.Button DeleteCustomerButton;
        private System.Windows.Forms.Button UpdateCustomerButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox CustomerId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CardNumber;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.GroupBox AllCustomers;
        private System.Windows.Forms.DataGridView customers;

    }
}