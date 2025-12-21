namespace AccountingApp
{
    partial class frmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            toolStrip1 = new ToolStrip();
            btnEdit = new ToolStripButton();
            btnDelete = new ToolStripButton();
            btnref = new ToolStripButton();
            btnPrint = new ToolStripButton();
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            label3 = new Label();
            txtTo = new MaskedTextBox();
            label2 = new Label();
            textFrom = new MaskedTextBox();
            cmContact = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Contact = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnEdit, btnDelete, btnref, btnPrint });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(685, 54);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnEdit
            // 
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageScaling = ToolStripItemImageScaling.None;
            btnEdit.ImageTransparentColor = Color.Magenta;
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(36, 51);
            btnEdit.Text = "Edit";
            btnEdit.TextImageRelation = TextImageRelation.ImageAboveText;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageScaling = ToolStripItemImageScaling.None;
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(44, 51);
            btnDelete.Text = "Delete";
            btnDelete.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnref
            // 
            btnref.Image = (Image)resources.GetObject("btnref.Image");
            btnref.ImageScaling = ToolStripItemImageScaling.None;
            btnref.ImageTransparentColor = Color.Magenta;
            btnref.Name = "btnref";
            btnref.Size = new Size(50, 51);
            btnref.Text = "Refresh";
            btnref.TextImageRelation = TextImageRelation.ImageAboveText;
            btnref.Click += btnref_Click;
            // 
            // btnPrint
            // 
            btnPrint.Image = (Image)resources.GetObject("btnPrint.Image");
            btnPrint.ImageScaling = ToolStripItemImageScaling.None;
            btnPrint.ImageTransparentColor = Color.Magenta;
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(36, 51);
            btnPrint.Text = "Print";
            btnPrint.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPrint.Click += btnPrint_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textFrom);
            groupBox1.Controls.Add(cmContact);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 68);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(668, 61);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(565, 19);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 27);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(414, 23);
            label3.Name = "label3";
            label3.Size = new Size(23, 19);
            label3.TabIndex = 5;
            label3.Text = "To";
            // 
            // txtTo
            // 
            txtTo.Location = new Point(442, 19);
            txtTo.Margin = new Padding(3, 4, 3, 4);
            txtTo.Mask = "0000/00/00";
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(100, 26);
            txtTo.TabIndex = 4;
            txtTo.ValidatingType = typeof(DateTime);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 23);
            label2.Name = "label2";
            label2.Size = new Size(38, 19);
            label2.TabIndex = 3;
            label2.Text = "From";
            // 
            // textFrom
            // 
            textFrom.Location = new Point(303, 19);
            textFrom.Margin = new Padding(3, 4, 3, 4);
            textFrom.Mask = "0000/00/00";
            textFrom.Name = "textFrom";
            textFrom.Size = new Size(100, 26);
            textFrom.TabIndex = 2;
            textFrom.ValidatingType = typeof(DateTime);
            // 
            // cmContact
            // 
            cmContact.DropDownStyle = ComboBoxStyle.DropDownList;
            cmContact.FormattingEnabled = true;
            cmContact.Location = new Point(64, 19);
            cmContact.Margin = new Padding(3, 4, 3, 4);
            cmContact.Name = "cmContact";
            cmContact.Size = new Size(180, 27);
            cmContact.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(52, 19);
            label1.TabIndex = 0;
            label1.Text = "Contact";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Contact, Amount, Column2, Column1 });
            dataGridView1.Location = new Point(12, 135);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(668, 517);
            dataGridView1.TabIndex = 2;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // Contact
            // 
            Contact.DataPropertyName = "FullName";
            Contact.HeaderText = "Contact";
            Contact.Name = "Contact";
            Contact.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Description";
            Column2.HeaderText = "Description";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "DateShamsi";
            Column1.FillWeight = 200F;
            Column1.HeaderText = "Date";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 200;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // frmReport
            // 
            AutoScaleDimensions = new SizeF(7F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 666);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            Font = new Font("Vazir", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmReport";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmReport";
            Load += frmReport_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnEdit;
        private ToolStripButton btnDelete;
        private ToolStripButton btnref;
        private ToolStripButton btnPrint;
        private GroupBox groupBox1;
        private Label label1;
        private Button btnSearch;
        private Label label3;
        private MaskedTextBox txtTo;
        private Label label2;
        private MaskedTextBox textFrom;
        private ComboBox cmContact;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Contact;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}