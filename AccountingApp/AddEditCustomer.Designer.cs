namespace AccountingApp
{
    partial class AddEditCustomer
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
            label6 = new Label();
            label5 = new Label();
            txt_Address = new TextBox();
            label4 = new Label();
            txt_Email = new TextBox();
            label3 = new Label();
            txt_Mobile = new TextBox();
            label2 = new Label();
            txt_Name = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            ChooseImage = new Button();
            Customerimage = new PictureBox();
            submir = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Customerimage).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_Address);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_Email);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_Mobile);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_Name);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(325, 291);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Data";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(56, 72);
            label6.Name = "label6";
            label6.Size = new Size(13, 17);
            label6.TabIndex = 9;
            label6.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(56, 21);
            label5.Name = "label5";
            label5.Size = new Size(13, 17);
            label5.TabIndex = 8;
            label5.Text = "*";
            // 
            // txt_Address
            // 
            txt_Address.Location = new Point(6, 192);
            txt_Address.Multiline = true;
            txt_Address.Name = "txt_Address";
            txt_Address.Size = new Size(313, 81);
            txt_Address.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 171);
            label4.Name = "label4";
            label4.Size = new Size(63, 17);
            label4.TabIndex = 6;
            label4.Text = "Address :";
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(6, 142);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(313, 25);
            txt_Email.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 121);
            label3.Name = "label3";
            label3.Size = new Size(46, 17);
            label3.TabIndex = 4;
            label3.Text = "Email :";
            // 
            // txt_Mobile
            // 
            txt_Mobile.Location = new Point(6, 92);
            txt_Mobile.Name = "txt_Mobile";
            txt_Mobile.Size = new Size(313, 25);
            txt_Mobile.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 71);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 2;
            label2.Text = "Mobile :";
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(6, 42);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(313, 25);
            txt_Name.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(50, 17);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ChooseImage);
            groupBox2.Controls.Add(Customerimage);
            groupBox2.Location = new Point(343, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(204, 299);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Image";
            // 
            // ChooseImage
            // 
            ChooseImage.Dock = DockStyle.Bottom;
            ChooseImage.Location = new Point(3, 270);
            ChooseImage.Name = "ChooseImage";
            ChooseImage.Size = new Size(198, 26);
            ChooseImage.TabIndex = 1;
            ChooseImage.Text = "Choose Image";
            ChooseImage.UseVisualStyleBackColor = true;
            ChooseImage.Click += ChooseImage_Click;
            // 
            // Customerimage
            // 
            Customerimage.Dock = DockStyle.Top;
            Customerimage.Image = Properties.Resources.no_picture_available_icon_20;
            Customerimage.Location = new Point(3, 21);
            Customerimage.Name = "Customerimage";
            Customerimage.Size = new Size(198, 241);
            Customerimage.SizeMode = PictureBoxSizeMode.StretchImage;
            Customerimage.TabIndex = 0;
            Customerimage.TabStop = false;
            // 
            // submir
            // 
            submir.BackColor = Color.LightGreen;
            submir.Location = new Point(177, 312);
            submir.Name = "submir";
            submir.Size = new Size(197, 34);
            submir.TabIndex = 2;
            submir.Text = "Register";
            submir.UseVisualStyleBackColor = false;
            submir.Click += submir_Click;
            // 
            // AddEditCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 356);
            Controls.Add(submir);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddEditCustomer";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Customer";
            Load += AddEditCustomer_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Customerimage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_Address;
        private Label label4;
        private TextBox txt_Email;
        private Label label3;
        private TextBox txt_Mobile;
        private Label label2;
        private TextBox txt_Name;
        private Label label1;
        private GroupBox groupBox2;
        private PictureBox Customerimage;
        private Button ChooseImage;
        private Button submir;
        private Label label6;
        private Label label5;
    }
}