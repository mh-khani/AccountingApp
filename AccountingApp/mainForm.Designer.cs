namespace AccountingApp
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            toolStrip1 = new ToolStrip();
            Setting = new ToolStripLabel();
            toolStrip2 = new ToolStrip();
            btnCustomers = new ToolStripButton();
            addTransaction = new ToolStripButton();
            btnReport = new ToolStripButton();
            btnreport2 = new ToolStripButton();
            toolStrip1.SuspendLayout();
            toolStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { Setting });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(672, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // Setting
            // 
            Setting.Name = "Setting";
            Setting.Size = new Size(44, 22);
            Setting.Text = "Setting";
            // 
            // toolStrip2
            // 
            toolStrip2.Items.AddRange(new ToolStripItem[] { btnCustomers, addTransaction, btnReport, btnreport2 });
            toolStrip2.Location = new Point(0, 25);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(672, 94);
            toolStrip2.TabIndex = 1;
            toolStrip2.Text = "toolStrip2";
            // 
            // btnCustomers
            // 
            btnCustomers.Image = Properties.Resources.User_7;
            btnCustomers.ImageScaling = ToolStripItemImageScaling.None;
            btnCustomers.ImageTransparentColor = Color.Magenta;
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(76, 91);
            btnCustomers.Text = "Customers";
            btnCustomers.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCustomers.Click += btnCustomers_Click_1;
            // 
            // addTransaction
            // 
            addTransaction.Image = Properties.Resources.Report_Add;
            addTransaction.ImageScaling = ToolStripItemImageScaling.None;
            addTransaction.ImageTransparentColor = Color.Magenta;
            addTransaction.Name = "addTransaction";
            addTransaction.Size = new Size(98, 91);
            addTransaction.Text = "New Transaction";
            addTransaction.TextImageRelation = TextImageRelation.ImageAboveText;
            addTransaction.Click += addTransaction_Click;
            // 
            // btnReport
            // 
            btnReport.Image = (Image)resources.GetObject("btnReport.Image");
            btnReport.ImageScaling = ToolStripItemImageScaling.None;
            btnReport.ImageTransparentColor = Color.Magenta;
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(89, 91);
            btnReport.Text = "Income Report";
            btnReport.TextImageRelation = TextImageRelation.ImageAboveText;
            btnReport.Click += btnReport_Click;
            // 
            // btnreport2
            // 
            btnreport2.Image = (Image)resources.GetObject("btnreport2.Image");
            btnreport2.ImageScaling = ToolStripItemImageScaling.None;
            btnreport2.ImageTransparentColor = Color.Magenta;
            btnreport2.Name = "btnreport2";
            btnreport2.Size = new Size(92, 91);
            btnreport2.Text = "Expense Report";
            btnreport2.TextImageRelation = TextImageRelation.ImageAboveText;
            btnreport2.Click += btnreport2_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(6F, 9F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 631);
            Controls.Add(toolStrip2);
            Controls.Add(toolStrip1);
            Font = new Font("Visitor TT2 BRK", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "mainForm";
            Text = "Accounting App";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel Setting;
        private ToolStrip toolStrip2;
        private ToolStripButton btnCustomers;
        private ToolStripButton addTransaction;
        private ToolStripButton btnReport;
        private ToolStripButton btnreport2;
    }
}
