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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            toolStrip1 = new ToolStrip();
            setting = new ToolStripDropDownButton();
            loginSettingToolStripMenuItem = new ToolStripMenuItem();
            toolStrip2 = new ToolStrip();
            btnCustomers = new ToolStripButton();
            addTransaction = new ToolStripButton();
            btnReport = new ToolStripButton();
            btnreport2 = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            toolStrip1.SuspendLayout();
            toolStrip2.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { setting });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(672, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // setting
            // 
            setting.DisplayStyle = ToolStripItemDisplayStyle.Text;
            setting.DropDownItems.AddRange(new ToolStripItem[] { loginSettingToolStripMenuItem });
            setting.Image = (Image)resources.GetObject("setting.Image");
            setting.ImageTransparentColor = Color.Magenta;
            setting.Name = "setting";
            setting.Size = new Size(57, 22);
            setting.Text = "Setting";
            setting.TextImageRelation = TextImageRelation.TextBeforeImage;
            // 
            // loginSettingToolStripMenuItem
            // 
            loginSettingToolStripMenuItem.Name = "loginSettingToolStripMenuItem";
            loginSettingToolStripMenuItem.Size = new Size(180, 22);
            loginSettingToolStripMenuItem.Text = "User Info";
            loginSettingToolStripMenuItem.Click += loginSettingToolStripMenuItem_Click;
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
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 609);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(672, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(118, 17);
            toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(6F, 9F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 631);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip2);
            Controls.Add(toolStrip1);
            Font = new Font("Visitor TT2 BRK", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "mainForm";
            Text = "Accounting App";
            Load += mainForm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStrip toolStrip2;
        private ToolStripButton btnCustomers;
        private ToolStripButton addTransaction;
        private ToolStripButton btnReport;
        private ToolStripButton btnreport2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer timer1;
        private ToolStripDropDownButton setting;
        private ToolStripMenuItem loginSettingToolStripMenuItem;
    }
}
