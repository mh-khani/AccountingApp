namespace AccountingApp
{
    partial class frmCustomer
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
            toolStrip1 = new ToolStrip();
            btn_Refresh = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btn_add = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btn_edit = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            btn_delete = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel1 = new ToolStripLabel();
            toolStripTextBox1 = new ToolStripTextBox();
            dataGridView1 = new DataGridView();
            CustomerID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Mobile = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btn_Refresh, toolStripSeparator3, btn_add, toolStripSeparator2, btn_edit, toolStripSeparator4, btn_delete, toolStripSeparator1, toolStripLabel1, toolStripTextBox1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(667, 37);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btn_Refresh
            // 
            btn_Refresh.Alignment = ToolStripItemAlignment.Right;
            btn_Refresh.Image = Properties.Resources.User_4_Refresh;
            btn_Refresh.ImageTransparentColor = Color.Magenta;
            btn_Refresh.Name = "btn_Refresh";
            btn_Refresh.Size = new Size(66, 56);
            btn_Refresh.Text = "Refresh";
            btn_Refresh.Click += btn_Refresh_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 59);
            // 
            // btn_add
            // 
            btn_add.Alignment = ToolStripItemAlignment.Right;
            btn_add.Image = Properties.Resources.User_7_Add;
            btn_add.ImageTransparentColor = Color.Magenta;
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(49, 56);
            btn_add.Text = "Add";
            btn_add.Click += btn_add_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 59);
            // 
            // btn_edit
            // 
            btn_edit.Alignment = ToolStripItemAlignment.Right;
            btn_edit.Image = Properties.Resources.User_7_Edit_2;
            btn_edit.ImageTransparentColor = Color.Magenta;
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(47, 56);
            btn_edit.Text = "Edit";
            btn_edit.Click += btn_edit_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 59);
            // 
            // btn_delete
            // 
            btn_delete.Alignment = ToolStripItemAlignment.Right;
            btn_delete.BackgroundImageLayout = ImageLayout.None;
            btn_delete.Image = Properties.Resources.User_4_Delete;
            btn_delete.ImageTransparentColor = Color.Magenta;
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(60, 56);
            btn_delete.Text = "Delete";
            btn_delete.Click += btn_delete_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 59);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(45, 56);
            toolStripLabel1.Text = "Search:";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.BackColor = SystemColors.ScrollBar;
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(150, 59);
            toolStripTextBox1.Text = " ";
            toolStripTextBox1.TextChanged += toolStripTextBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CustomerID, FullName, Mobile, Email, Address });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(667, 300);
            dataGridView1.TabIndex = 1;
            // 
            // CustomerID
            // 
            CustomerID.DataPropertyName = "CustomerID";
            CustomerID.HeaderText = "ID";
            CustomerID.Name = "CustomerID";
            CustomerID.ReadOnly = true;
            CustomerID.Visible = false;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "Full Name";
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // Mobile
            // 
            Mobile.DataPropertyName = "Mobile";
            Mobile.HeaderText = "Mobile";
            Mobile.Name = "Mobile";
            Mobile.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Address";
            Address.Name = "Address";
            Address.ReadOnly = true;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 337);
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            Font = new Font("Neou", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmCustomer";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Person List";
            Load += frmCustomer_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btn_add;
        private ToolStripButton btn_delete;
        private ToolStripButton btn_edit;
        private ToolStripButton btn_Refresh;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Mobile;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Address;
    }
}