namespace SOO_CLIENT
{
    partial class OrderForm
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
            this.AllOrders = new System.Windows.Forms.GroupBox();
            this.ordersGridView = new System.Windows.Forms.DataGridView();
            this.CustomerOperations = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ProductId = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.feedback = new System.Windows.Forms.TextBox();
            this.feedbackOrderId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.RemoveFromCart = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.GiveFeedbackButton = new System.Windows.Forms.Button();
            this.getOrderByIdButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.OrderId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderDateTime = new System.Windows.Forms.TextBox();
            this.CustomerId = new System.Windows.Forms.TextBox();
            this.CartId = new System.Windows.Forms.TextBox();
            this.ProcessOrderButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.feedbacksGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cartGridView = new System.Windows.Forms.DataGridView();
            this.AllOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).BeginInit();
            this.CustomerOperations.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feedbacksGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AllOrders
            // 
            this.AllOrders.Controls.Add(this.ordersGridView);
            this.AllOrders.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllOrders.Location = new System.Drawing.Point(13, 413);
            this.AllOrders.Name = "AllOrders";
            this.AllOrders.Size = new System.Drawing.Size(1556, 226);
            this.AllOrders.TabIndex = 10;
            this.AllOrders.TabStop = false;
            this.AllOrders.Text = "GET ALL ORDERS";
            // 
            // ordersGridView
            // 
            this.ordersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGridView.Location = new System.Drawing.Point(6, 37);
            this.ordersGridView.Name = "ordersGridView";
            this.ordersGridView.ReadOnly = true;
            this.ordersGridView.RowHeadersWidth = 35;
            this.ordersGridView.RowTemplate.Height = 28;
            this.ordersGridView.Size = new System.Drawing.Size(1542, 179);
            this.ordersGridView.TabIndex = 2;
            // 
            // CustomerOperations
            // 
            this.CustomerOperations.Controls.Add(this.cartGridView);
            this.CustomerOperations.Controls.Add(this.label4);
            this.CustomerOperations.Controls.Add(this.button1);
            this.CustomerOperations.Controls.Add(this.label17);
            this.CustomerOperations.Controls.Add(this.Quantity);
            this.CustomerOperations.Controls.Add(this.label15);
            this.CustomerOperations.Controls.Add(this.ProductId);
            this.CustomerOperations.Controls.Add(this.label14);
            this.CustomerOperations.Controls.Add(this.label13);
            this.CustomerOperations.Controls.Add(this.label12);
            this.CustomerOperations.Controls.Add(this.feedback);
            this.CustomerOperations.Controls.Add(this.feedbackOrderId);
            this.CustomerOperations.Controls.Add(this.label11);
            this.CustomerOperations.Controls.Add(this.label5);
            this.CustomerOperations.Controls.Add(this.label10);
            this.CustomerOperations.Controls.Add(this.RemoveFromCart);
            this.CustomerOperations.Controls.Add(this.label9);
            this.CustomerOperations.Controls.Add(this.label8);
            this.CustomerOperations.Controls.Add(this.label7);
            this.CustomerOperations.Controls.Add(this.label6);
            this.CustomerOperations.Controls.Add(this.addToCartButton);
            this.CustomerOperations.Controls.Add(this.GiveFeedbackButton);
            this.CustomerOperations.Controls.Add(this.getOrderByIdButton);
            this.CustomerOperations.Controls.Add(this.label16);
            this.CustomerOperations.Controls.Add(this.OrderId);
            this.CustomerOperations.Controls.Add(this.label3);
            this.CustomerOperations.Controls.Add(this.label2);
            this.CustomerOperations.Controls.Add(this.label1);
            this.CustomerOperations.Controls.Add(this.OrderDateTime);
            this.CustomerOperations.Controls.Add(this.CustomerId);
            this.CustomerOperations.Controls.Add(this.CartId);
            this.CustomerOperations.Controls.Add(this.ProcessOrderButton);
            this.CustomerOperations.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerOperations.Location = new System.Drawing.Point(12, 12);
            this.CustomerOperations.Name = "CustomerOperations";
            this.CustomerOperations.Size = new System.Drawing.Size(1557, 395);
            this.CustomerOperations.TabIndex = 9;
            this.CustomerOperations.TabStop = false;
            this.CustomerOperations.Text = "ORDER OPERATIONS";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(517, 105);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 28);
            this.label17.TabIndex = 35;
            this.label17.Text = "Quantity";
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(635, 101);
            this.Quantity.Multiline = true;
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(168, 35);
            this.Quantity.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(517, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 28);
            this.label15.TabIndex = 33;
            this.label15.Text = "Product Id";
            // 
            // ProductId
            // 
            this.ProductId.Location = new System.Drawing.Point(635, 62);
            this.ProductId.Multiline = true;
            this.ProductId.Name = "ProductId";
            this.ProductId.Size = new System.Drawing.Size(168, 35);
            this.ProductId.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(583, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(166, 28);
            this.label14.TabIndex = 31;
            this.label14.Text = "CURRENT CART";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(234, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 28);
            this.label13.TabIndex = 30;
            this.label13.Text = "ORDER";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(196, 268);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 28);
            this.label12.TabIndex = 29;
            this.label12.Text = "GIVE FEEDBACK";
            // 
            // feedback
            // 
            this.feedback.Location = new System.Drawing.Point(147, 351);
            this.feedback.Multiline = true;
            this.feedback.Name = "feedback";
            this.feedback.Size = new System.Drawing.Size(271, 35);
            this.feedback.TabIndex = 28;
            // 
            // feedbackOrderId
            // 
            this.feedbackOrderId.Location = new System.Drawing.Point(147, 308);
            this.feedbackOrderId.Name = "feedbackOrderId";
            this.feedbackOrderId.Size = new System.Drawing.Size(271, 35);
            this.feedbackOrderId.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 354);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 28);
            this.label11.TabIndex = 25;
            this.label11.Text = "FeedBack";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 28);
            this.label5.TabIndex = 24;
            this.label5.Text = "Order Id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1186, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(294, 28);
            this.label10.TabIndex = 23;
            this.label10.Text = "Insert Product Id and quantity";
            // 
            // RemoveFromCart
            // 
            this.RemoveFromCart.Location = new System.Drawing.Point(921, 263);
            this.RemoveFromCart.Name = "RemoveFromCart";
            this.RemoveFromCart.Size = new System.Drawing.Size(259, 37);
            this.RemoveFromCart.TabIndex = 22;
            this.RemoveFromCart.Text = "Remove From Cart";
            this.RemoveFromCart.UseVisualStyleBackColor = true;
            this.RemoveFromCart.Click += new System.EventHandler(this.RemoveFromCart_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1186, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(294, 28);
            this.label9.TabIndex = 21;
            this.label9.Text = "Insert Product Id and quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1186, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(287, 28);
            this.label8.TabIndex = 20;
            this.label8.Text = "Insert order id and feedback";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1186, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 28);
            this.label7.TabIndex = 19;
            this.label7.Text = "Insert Id only";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(1186, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(360, 102);
            this.label6.TabIndex = 18;
            this.label6.Text = "Insert Customer Id only. Order Id and DateTime will be auto generated. Cart shoul" +
    "d not be empty.";
            // 
            // addToCartButton
            // 
            this.addToCartButton.Location = new System.Drawing.Point(921, 220);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(259, 37);
            this.addToCartButton.TabIndex = 17;
            this.addToCartButton.Text = "Add To Cart";
            this.addToCartButton.UseVisualStyleBackColor = true;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // GiveFeedbackButton
            // 
            this.GiveFeedbackButton.Location = new System.Drawing.Point(921, 177);
            this.GiveFeedbackButton.Name = "GiveFeedbackButton";
            this.GiveFeedbackButton.Size = new System.Drawing.Size(259, 37);
            this.GiveFeedbackButton.TabIndex = 16;
            this.GiveFeedbackButton.Text = "Give Feedback";
            this.GiveFeedbackButton.UseVisualStyleBackColor = true;
            this.GiveFeedbackButton.Click += new System.EventHandler(this.GiveFeedbackButton_Click);
            // 
            // getOrderByIdButton
            // 
            this.getOrderByIdButton.Location = new System.Drawing.Point(921, 136);
            this.getOrderByIdButton.Name = "getOrderByIdButton";
            this.getOrderByIdButton.Size = new System.Drawing.Size(259, 35);
            this.getOrderByIdButton.TabIndex = 15;
            this.getOrderByIdButton.Text = "Get Order By Id";
            this.getOrderByIdButton.UseVisualStyleBackColor = true;
            this.getOrderByIdButton.Click += new System.EventHandler(this.getOrderByIdButton_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 28);
            this.label16.TabIndex = 14;
            this.label16.Text = "Order Id";
            // 
            // OrderId
            // 
            this.OrderId.Location = new System.Drawing.Point(147, 71);
            this.OrderId.Name = "OrderId";
            this.OrderId.Size = new System.Drawing.Size(271, 35);
            this.OrderId.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "DateTime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "CustomerId";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cart Id";
            // 
            // OrderDateTime
            // 
            this.OrderDateTime.Location = new System.Drawing.Point(147, 192);
            this.OrderDateTime.Name = "OrderDateTime";
            this.OrderDateTime.Size = new System.Drawing.Size(271, 35);
            this.OrderDateTime.TabIndex = 3;
            // 
            // CustomerId
            // 
            this.CustomerId.Location = new System.Drawing.Point(147, 151);
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Size = new System.Drawing.Size(271, 35);
            this.CustomerId.TabIndex = 2;
            // 
            // CartId
            // 
            this.CartId.Location = new System.Drawing.Point(147, 110);
            this.CartId.Name = "CartId";
            this.CartId.Size = new System.Drawing.Size(271, 35);
            this.CartId.TabIndex = 1;
            // 
            // ProcessOrderButton
            // 
            this.ProcessOrderButton.Location = new System.Drawing.Point(921, 37);
            this.ProcessOrderButton.Name = "ProcessOrderButton";
            this.ProcessOrderButton.Size = new System.Drawing.Size(259, 35);
            this.ProcessOrderButton.TabIndex = 0;
            this.ProcessOrderButton.Text = "Process Order";
            this.ProcessOrderButton.UseVisualStyleBackColor = true;
            this.ProcessOrderButton.Click += new System.EventHandler(this.ProcessOrderButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.feedbacksGridView);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 645);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1557, 226);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GET ALL FEEDBACKS";
            // 
            // feedbacksGridView
            // 
            this.feedbacksGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.feedbacksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feedbacksGridView.Location = new System.Drawing.Point(12, 34);
            this.feedbacksGridView.Name = "feedbacksGridView";
            this.feedbacksGridView.ReadOnly = true;
            this.feedbacksGridView.RowHeadersWidth = 35;
            this.feedbacksGridView.RowTemplate.Height = 28;
            this.feedbacksGridView.Size = new System.Drawing.Size(1537, 179);
            this.feedbacksGridView.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(921, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 37);
            this.button1.TabIndex = 36;
            this.button1.Text = "Get Cart By Id";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1186, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 28);
            this.label4.TabIndex = 37;
            this.label4.Text = "Insert Cart Id only";
            // 
            // cartGridView
            // 
            this.cartGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartGridView.Location = new System.Drawing.Point(424, 157);
            this.cartGridView.Name = "cartGridView";
            this.cartGridView.RowTemplate.Height = 28;
            this.cartGridView.Size = new System.Drawing.Size(491, 229);
            this.cartGridView.TabIndex = 38;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 883);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AllOrders);
            this.Controls.Add(this.CustomerOperations);
            this.Name = "OrderForm";
            this.Text = "OrderService";
            this.AllOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).EndInit();
            this.CustomerOperations.ResumeLayout(false);
            this.CustomerOperations.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.feedbacksGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AllOrders;
        private System.Windows.Forms.DataGridView ordersGridView;
        private System.Windows.Forms.GroupBox CustomerOperations;
        private System.Windows.Forms.TextBox feedbackOrderId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button RemoveFromCart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Button GiveFeedbackButton;
        private System.Windows.Forms.Button getOrderByIdButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox OrderId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OrderDateTime;
        private System.Windows.Forms.TextBox CustomerId;
        private System.Windows.Forms.TextBox CartId;
        private System.Windows.Forms.Button ProcessOrderButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView feedbacksGridView;
        private System.Windows.Forms.TextBox feedback;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ProductId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView cartGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}