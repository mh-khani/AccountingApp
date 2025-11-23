namespace AccountingApp
{
    partial class NewTransaction
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
            groupBox1 = new GroupBox();
            DGVcustomer = new DataGridView();
            FullName = new DataGridViewTextBoxColumn();
            customersearch = new TextBox();
            label1 = new Label();
            Contacttxt = new TextBox();
            income = new RadioButton();
            Payment = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            amount = new NumericUpDown();
            label4 = new Label();
            des = new TextBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVcustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amount).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DGVcustomer);
            groupBox1.Controls.Add(customersearch);
            groupBox1.Location = new Point(349, 15);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(223, 427);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customers";
            // 
            // DGVcustomer
            // 
            DGVcustomer.AllowUserToAddRows = false;
            DGVcustomer.AllowUserToDeleteRows = false;
            DGVcustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVcustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVcustomer.Columns.AddRange(new DataGridViewColumn[] { FullName });
            DGVcustomer.Location = new Point(6, 65);
            DGVcustomer.Margin = new Padding(3, 4, 3, 4);
            DGVcustomer.Name = "DGVcustomer";
            DGVcustomer.ReadOnly = true;
            DGVcustomer.Size = new Size(211, 354);
            DGVcustomer.TabIndex = 1;
            DGVcustomer.CellClick += DGVcustomer_CellClick;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "CustomerName";
            FullName.HeaderText = "Full Name";
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // customersearch
            // 
            customersearch.Location = new Point(6, 28);
            customersearch.Margin = new Padding(3, 4, 3, 4);
            customersearch.Name = "customersearch";
            customersearch.Size = new Size(211, 26);
            customersearch.TabIndex = 0;
            customersearch.TextChanged += customersearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 19);
            label1.Name = "label1";
            label1.Size = new Size(59, 19);
            label1.TabIndex = 1;
            label1.Text = "Contact :";
            // 
            // Contacttxt
            // 
            Contacttxt.Location = new Point(73, 15);
            Contacttxt.Margin = new Padding(3, 4, 3, 4);
            Contacttxt.Name = "Contacttxt";
            Contacttxt.ReadOnly = true;
            Contacttxt.Size = new Size(255, 26);
            Contacttxt.TabIndex = 2;
            // 
            // income
            // 
            income.AutoSize = true;
            income.Location = new Point(123, 64);
            income.Margin = new Padding(3, 4, 3, 4);
            income.Name = "income";
            income.Size = new Size(67, 23);
            income.TabIndex = 3;
            income.TabStop = true;
            income.Text = "income";
            income.UseVisualStyleBackColor = true;
            // 
            // Payment
            // 
            Payment.AutoSize = true;
            Payment.Location = new Point(191, 64);
            Payment.Margin = new Padding(3, 4, 3, 4);
            Payment.Name = "Payment";
            Payment.Size = new Size(72, 23);
            Payment.TabIndex = 4;
            Payment.TabStop = true;
            Payment.Text = "Expense";
            Payment.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 66);
            label2.Name = "label2";
            label2.Size = new Size(110, 19);
            label2.TabIndex = 1;
            label2.Text = "Transaction Type :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 115);
            label3.Name = "label3";
            label3.Size = new Size(60, 19);
            label3.TabIndex = 1;
            label3.Text = "Amount :";
            // 
            // amount
            // 
            amount.Location = new Point(73, 113);
            amount.Margin = new Padding(3, 4, 3, 4);
            amount.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            amount.Name = "amount";
            amount.Size = new Size(253, 26);
            amount.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 164);
            label4.Name = "label4";
            label4.Size = new Size(77, 19);
            label4.TabIndex = 1;
            label4.Text = "Description :";
            // 
            // des
            // 
            des.Location = new Point(13, 204);
            des.Margin = new Padding(3, 4, 3, 4);
            des.Multiline = true;
            des.Name = "des";
            des.Size = new Size(315, 201);
            des.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.GreenYellow;
            button1.Location = new Point(95, 413);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(127, 28);
            button1.TabIndex = 7;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // NewTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 457);
            Controls.Add(button1);
            Controls.Add(des);
            Controls.Add(amount);
            Controls.Add(Payment);
            Controls.Add(income);
            Controls.Add(Contacttxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Font = new Font("Vazir", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "NewTransaction";
            StartPosition = FormStartPosition.CenterParent;
            Text = "New Transaction";
            Load += NewTransaction_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVcustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)amount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView DGVcustomer;
        private TextBox customersearch;
        private DataGridViewTextBoxColumn FullName;
        private Label label1;
        private TextBox Contacttxt;
        private RadioButton income;
        private RadioButton Payment;
        private Label label2;
        private Label label3;
        private NumericUpDown amount;
        private Label label4;
        private TextBox des;
        private Button button1;
    }
}