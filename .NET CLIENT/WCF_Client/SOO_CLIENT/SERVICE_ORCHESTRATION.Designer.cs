namespace SOO_CLIENT
{
    partial class SERVICE_ORCHESTRATION
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pRODUCTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cUSTOMERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oRDERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pAYMENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNVOICEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pRODUCTToolStripMenuItem,
            this.cUSTOMERToolStripMenuItem,
            this.oRDERToolStripMenuItem,
            this.pAYMENTToolStripMenuItem,
            this.iNVOICEToolStripMenuItem,
            this.lOGOUTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1415, 41);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pRODUCTToolStripMenuItem
            // 
            this.pRODUCTToolStripMenuItem.Name = "pRODUCTToolStripMenuItem";
            this.pRODUCTToolStripMenuItem.Size = new System.Drawing.Size(139, 37);
            this.pRODUCTToolStripMenuItem.Text = "PRODUCT";
            this.pRODUCTToolStripMenuItem.Click += new System.EventHandler(this.pRODUCTToolStripMenuItem_Click);
            // 
            // cUSTOMERToolStripMenuItem
            // 
            this.cUSTOMERToolStripMenuItem.Name = "cUSTOMERToolStripMenuItem";
            this.cUSTOMERToolStripMenuItem.Size = new System.Drawing.Size(162, 37);
            this.cUSTOMERToolStripMenuItem.Text = "CUSTOMER";
            this.cUSTOMERToolStripMenuItem.Click += new System.EventHandler(this.cUSTOMERToolStripMenuItem_Click);
            // 
            // oRDERToolStripMenuItem
            // 
            this.oRDERToolStripMenuItem.Name = "oRDERToolStripMenuItem";
            this.oRDERToolStripMenuItem.Size = new System.Drawing.Size(108, 37);
            this.oRDERToolStripMenuItem.Text = "ORDER";
            this.oRDERToolStripMenuItem.Click += new System.EventHandler(this.oRDERToolStripMenuItem_Click);
            // 
            // pAYMENTToolStripMenuItem
            // 
            this.pAYMENTToolStripMenuItem.Name = "pAYMENTToolStripMenuItem";
            this.pAYMENTToolStripMenuItem.Size = new System.Drawing.Size(144, 37);
            this.pAYMENTToolStripMenuItem.Text = "PAYMENT";
            this.pAYMENTToolStripMenuItem.Click += new System.EventHandler(this.pAYMENTToolStripMenuItem_Click);
            // 
            // iNVOICEToolStripMenuItem
            // 
            this.iNVOICEToolStripMenuItem.Name = "iNVOICEToolStripMenuItem";
            this.iNVOICEToolStripMenuItem.Size = new System.Drawing.Size(136, 37);
            this.iNVOICEToolStripMenuItem.Text = "INVOICE";
            this.iNVOICEToolStripMenuItem.Click += new System.EventHandler(this.iNVOICEToolStripMenuItem_Click);
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(128, 37);
            this.lOGOUTToolStripMenuItem.Text = "LOGOUT";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // SERVICE_ORCHESTRATION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1415, 1039);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SERVICE_ORCHESTRATION";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SERVICE_ORCHESTRATION";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cUSTOMERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oRDERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pAYMENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNVOICEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
    }
}