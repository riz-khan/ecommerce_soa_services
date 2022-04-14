namespace SOO_CLIENT
{
    partial class PaymentForm
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
            this.PaymentOperations = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Method = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ProcessPayment = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.PaymentId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateTime = new System.Windows.Forms.TextBox();
            this.TotalAmount = new System.Windows.Forms.TextBox();
            this.CustomerId = new System.Windows.Forms.TextBox();
            this.OrderId = new System.Windows.Forms.TextBox();
            this.GetPaymentById = new System.Windows.Forms.Button();
            this.AllPayments = new System.Windows.Forms.GroupBox();
            this.paymentsGridView = new System.Windows.Forms.DataGridView();
            this.PaymentOperations.SuspendLayout();
            this.AllPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PaymentOperations
            // 
            this.PaymentOperations.Controls.Add(this.label7);
            this.PaymentOperations.Controls.Add(this.Method);
            this.PaymentOperations.Controls.Add(this.label5);
            this.PaymentOperations.Controls.Add(this.label6);
            this.PaymentOperations.Controls.Add(this.ProcessPayment);
            this.PaymentOperations.Controls.Add(this.label16);
            this.PaymentOperations.Controls.Add(this.PaymentId);
            this.PaymentOperations.Controls.Add(this.label4);
            this.PaymentOperations.Controls.Add(this.label3);
            this.PaymentOperations.Controls.Add(this.label2);
            this.PaymentOperations.Controls.Add(this.label1);
            this.PaymentOperations.Controls.Add(this.DateTime);
            this.PaymentOperations.Controls.Add(this.TotalAmount);
            this.PaymentOperations.Controls.Add(this.CustomerId);
            this.PaymentOperations.Controls.Add(this.OrderId);
            this.PaymentOperations.Controls.Add(this.GetPaymentById);
            this.PaymentOperations.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentOperations.Location = new System.Drawing.Point(12, 12);
            this.PaymentOperations.Name = "PaymentOperations";
            this.PaymentOperations.Size = new System.Drawing.Size(1246, 294);
            this.PaymentOperations.TabIndex = 8;
            this.PaymentOperations.TabStop = false;
            this.PaymentOperations.Text = "PAYMENT OPERATIONS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(714, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 28);
            this.label7.TabIndex = 28;
            this.label7.Text = "Insert Id only";
            // 
            // Method
            // 
            this.Method.Location = new System.Drawing.Point(147, 241);
            this.Method.Name = "Method";
            this.Method.Size = new System.Drawing.Size(271, 35);
            this.Method.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 28);
            this.label5.TabIndex = 24;
            this.label5.Text = "Method";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(714, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(525, 112);
            this.label6.TabIndex = 18;
            this.label6.Text = "This Operation will be called from within order service because it needs values t" +
    "hat it can only get from order service";
            // 
            // ProcessPayment
            // 
            this.ProcessPayment.Enabled = false;
            this.ProcessPayment.Location = new System.Drawing.Point(451, 78);
            this.ProcessPayment.Name = "ProcessPayment";
            this.ProcessPayment.Size = new System.Drawing.Size(259, 35);
            this.ProcessPayment.TabIndex = 15;
            this.ProcessPayment.Text = "Process Payment";
            this.ProcessPayment.UseVisualStyleBackColor = true;
            this.ProcessPayment.Click += new System.EventHandler(this.ProcessPayment_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 28);
            this.label16.TabIndex = 14;
            this.label16.Text = "Payment Id";
            // 
            // PaymentId
            // 
            this.PaymentId.Location = new System.Drawing.Point(147, 37);
            this.PaymentId.Name = "PaymentId";
            this.PaymentId.Size = new System.Drawing.Size(271, 35);
            this.PaymentId.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "DateTime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Customer Id";
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
            // DateTime
            // 
            this.DateTime.Location = new System.Drawing.Point(147, 199);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(271, 35);
            this.DateTime.TabIndex = 4;
            // 
            // TotalAmount
            // 
            this.TotalAmount.Location = new System.Drawing.Point(147, 158);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(271, 35);
            this.TotalAmount.TabIndex = 3;
            // 
            // CustomerId
            // 
            this.CustomerId.Location = new System.Drawing.Point(147, 117);
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Size = new System.Drawing.Size(271, 35);
            this.CustomerId.TabIndex = 2;
            // 
            // OrderId
            // 
            this.OrderId.Location = new System.Drawing.Point(147, 76);
            this.OrderId.Name = "OrderId";
            this.OrderId.Size = new System.Drawing.Size(271, 35);
            this.OrderId.TabIndex = 1;
            // 
            // GetPaymentById
            // 
            this.GetPaymentById.Location = new System.Drawing.Point(451, 37);
            this.GetPaymentById.Name = "GetPaymentById";
            this.GetPaymentById.Size = new System.Drawing.Size(259, 35);
            this.GetPaymentById.TabIndex = 0;
            this.GetPaymentById.Text = "Get Payment (By Id)";
            this.GetPaymentById.UseVisualStyleBackColor = true;
            this.GetPaymentById.Click += new System.EventHandler(this.GetPaymentById_Click);
            // 
            // AllPayments
            // 
            this.AllPayments.Controls.Add(this.paymentsGridView);
            this.AllPayments.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllPayments.Location = new System.Drawing.Point(13, 312);
            this.AllPayments.Name = "AllPayments";
            this.AllPayments.Size = new System.Drawing.Size(1245, 482);
            this.AllPayments.TabIndex = 9;
            this.AllPayments.TabStop = false;
            this.AllPayments.Text = "GET ALL PAYMENTS";
            // 
            // paymentsGridView
            // 
            this.paymentsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.paymentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentsGridView.Location = new System.Drawing.Point(6, 37);
            this.paymentsGridView.Name = "paymentsGridView";
            this.paymentsGridView.ReadOnly = true;
            this.paymentsGridView.RowHeadersWidth = 35;
            this.paymentsGridView.RowTemplate.Height = 28;
            this.paymentsGridView.Size = new System.Drawing.Size(1233, 434);
            this.paymentsGridView.TabIndex = 2;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 801);
            this.Controls.Add(this.AllPayments);
            this.Controls.Add(this.PaymentOperations);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.PaymentOperations.ResumeLayout(false);
            this.PaymentOperations.PerformLayout();
            this.AllPayments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paymentsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PaymentOperations;
        private System.Windows.Forms.TextBox Method;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ProcessPayment;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox PaymentId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DateTime;
        private System.Windows.Forms.TextBox TotalAmount;
        private System.Windows.Forms.TextBox CustomerId;
        private System.Windows.Forms.TextBox OrderId;
        private System.Windows.Forms.Button GetPaymentById;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox AllPayments;
        private System.Windows.Forms.DataGridView paymentsGridView;
    }
}