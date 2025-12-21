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
            groupBox1 = new GroupBox();
            refresh = new ToolStripButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            toolStrip1.SuspendLayout();
            toolStrip2.SuspendLayout();
            statusStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { setting });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(607, 25);
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
            loginSettingToolStripMenuItem.Size = new Size(121, 22);
            loginSettingToolStripMenuItem.Text = "User Info";
            loginSettingToolStripMenuItem.Click += loginSettingToolStripMenuItem_Click;
            // 
            // toolStrip2
            // 
            toolStrip2.Items.AddRange(new ToolStripItem[] { btnCustomers, addTransaction, btnReport, btnreport2, refresh });
            toolStrip2.Location = new Point(0, 25);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(607, 94);
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
            statusStrip1.Location = new Point(0, 544);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(607, 22);
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
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Vazir", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(13, 125);
            groupBox1.Margin = new Padding(4, 6, 4, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 6, 4, 6);
            groupBox1.Size = new Size(340, 338);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Monthly report\n";
            // 
            // refresh
            // 
            refresh.Image = Properties.Resources._1371476342_Refresh;
            refresh.ImageScaling = ToolStripItemImageScaling.None;
            refresh.ImageTransparentColor = Color.Magenta;
            refresh.Name = "refresh";
            refresh.Size = new Size(50, 91);
            refresh.Text = "Refresh";
            refresh.TextImageRelation = TextImageRelation.ImageAboveText;
            refresh.Click += refresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 25);
            label1.Name = "label1";
            label1.Size = new Size(53, 19);
            label1.TabIndex = 0;
            label1.Text = "Income:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 55);
            label2.Name = "label2";
            label2.Size = new Size(64, 19);
            label2.TabIndex = 0;
            label2.Text = "Expenses:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 86);
            label3.Name = "label3";
            label3.Size = new Size(59, 19);
            label3.TabIndex = 0;
            label3.Text = "Balance :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 25);
            label4.Name = "label4";
            label4.Size = new Size(42, 19);
            label4.TabIndex = 1;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 55);
            label5.Name = "label5";
            label5.Size = new Size(42, 19);
            label5.TabIndex = 1;
            label5.Text = "label4";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(72, 86);
            label6.Name = "label6";
            label6.Size = new Size(16, 19);
            label6.TabIndex = 1;
            label6.Text = "1";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 566);
            Controls.Add(groupBox1);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip2);
            Controls.Add(toolStrip1);
            Font = new Font("Vazir", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 4, 4, 4);
            Name = "mainForm";
            Text = "Accounting App";
            Load += mainForm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
        private ToolStripButton refresh;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}
