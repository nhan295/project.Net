﻿namespace Project.NET
{
    partial class Register_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register_form));
            pictureBox1 = new PictureBox();
            txtRegname = new TextBox();
            txtPhone = new TextBox();
            txtConfirmpass = new TextBox();
            txtEmail = new TextBox();
            txtRegpass = new TextBox();
            label1 = new Label();
            btnRegister = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cboAddress = new ComboBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            peye = new PictureBox();
            phide = new PictureBox();
            peye1 = new PictureBox();
            phide1 = new PictureBox();
            label7 = new Label();
            login_link = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)peye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)phide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)peye1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)phide1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(560, 214);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtRegname
            // 
            txtRegname.Location = new Point(88, 248);
            txtRegname.Name = "txtRegname";
            txtRegname.PlaceholderText = "Username";
            txtRegname.Size = new Size(432, 27);
            txtRegname.TabIndex = 1;
            txtRegname.TextChanged += textBox1_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(88, 297);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone number";
            txtPhone.Size = new Size(432, 27);
            txtPhone.TabIndex = 2;
            // 
            // txtConfirmpass
            // 
            txtConfirmpass.Location = new Point(88, 504);
            txtConfirmpass.Name = "txtConfirmpass";
            txtConfirmpass.PasswordChar = '*';
            txtConfirmpass.PlaceholderText = "Confirm Password";
            txtConfirmpass.Size = new Size(432, 27);
            txtConfirmpass.TabIndex = 3;
            txtConfirmpass.TextChanged += txtConfirmpass_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(88, 348);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(432, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtRegpass
            // 
            txtRegpass.Location = new Point(88, 447);
            txtRegpass.Name = "txtRegpass";
            txtRegpass.PasswordChar = '*';
            txtRegpass.PlaceholderText = "Password";
            txtRegpass.Size = new Size(432, 27);
            txtRegpass.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(76, 248);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 6;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DarkRed;
            btnRegister.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold);
            btnRegister.ForeColor = SystemColors.ButtonHighlight;
            btnRegister.Location = new Point(161, 555);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(239, 50);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(76, 297);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(192, 0, 0);
            label3.Location = new Point(76, 447);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(192, 0, 0);
            label4.Location = new Point(76, 399);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(192, 0, 0);
            label5.Location = new Point(76, 348);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 11;
            // 
            // cboAddress
            // 
            cboAddress.FormattingEnabled = true;
            cboAddress.Items.AddRange(new object[] { "An Giang", "Bà Rịa - Vũng Tàu", "Bắc Giang", "Bắc Kạn", "Bắc Ninh", "Bến Tre", "Bình Định", "Bình Dương", "Bình Phước", "Bình Thuận", "Cà Mau", "Cần Thơ", "Cao Bằng", "Đà Nẵng", "Đắk Lắk", "Đắk Nông", "Điện Biên", "Đồng Nai", "Đồng Tháp", "Gia Lai", "Hà Giang", "Hà Nam", "Hà Nội", "Hà Tĩnh", "Hải Dương", "Hải Phòng", "Hậu Giang", "Hòa Bình", "Hưng Yên", "Khánh Hòa", "Kiên Giang", "Kon Tum", "Lai Châu", "Lâm Đồng", "Lạng Sơn", "Lào Cai", "Long An", "Nam Định", "Nghệ An", "Ninh Bình", "Ninh Thuận", "Phú Thọ", "Phú Yên", "Quảng Bình", "Quảng Nam", "Quảng Ngãi", "Quảng Ninh", "Quảng Trị", "Sóc Trăng", "Sơn La", "Tây Ninh", "Thái Bình", "Thái Nguyên", "Thanh Hóa", "Thừa Thiên Huế", "Tiền Giang", "TP. Hồ Chí Minh", "Trà Vinh", "Tuyên Quang", "Vĩnh Long", "Vĩnh Phúc", "Yên Bái" });
            cboAddress.Location = new Point(88, 396);
            cboAddress.Name = "cboAddress";
            cboAddress.Size = new Size(432, 28);
            cboAddress.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(88, 399);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 14;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(38, 248);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.padlock;
            pictureBox3.Location = new Point(38, 447);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.email;
            pictureBox4.Location = new Point(38, 348);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 27);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.phone_call;
            pictureBox5.Location = new Point(38, 297);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 27);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 18;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.confirm;
            pictureBox6.Location = new Point(38, 504);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(32, 27);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 19;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.pin;
            pictureBox7.Location = new Point(38, 399);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(32, 27);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 20;
            pictureBox7.TabStop = false;
            // 
            // peye
            // 
            peye.Image = Properties.Resources.eye;
            peye.Location = new Point(495, 447);
            peye.Name = "peye";
            peye.Size = new Size(25, 27);
            peye.SizeMode = PictureBoxSizeMode.StretchImage;
            peye.TabIndex = 21;
            peye.TabStop = false;
            peye.Click += peye_Click;
            // 
            // phide
            // 
            phide.Image = Properties.Resources.hidden;
            phide.Location = new Point(495, 447);
            phide.Name = "phide";
            phide.Size = new Size(25, 27);
            phide.SizeMode = PictureBoxSizeMode.StretchImage;
            phide.TabIndex = 22;
            phide.TabStop = false;
            phide.Click += phide_Click;
            // 
            // peye1
            // 
            peye1.Image = Properties.Resources.eye;
            peye1.Location = new Point(495, 504);
            peye1.Name = "peye1";
            peye1.Size = new Size(25, 27);
            peye1.SizeMode = PictureBoxSizeMode.StretchImage;
            peye1.TabIndex = 23;
            peye1.TabStop = false;
            peye1.Click += peye1_Click;
            // 
            // phide1
            // 
            phide1.Image = Properties.Resources.hidden;
            phide1.Location = new Point(495, 504);
            phide1.Name = "phide1";
            phide1.Size = new Size(25, 27);
            phide1.SizeMode = PictureBoxSizeMode.StretchImage;
            phide1.TabIndex = 24;
            phide1.TabStop = false;
            phide1.Click += phide1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(165, 619);
            label7.Name = "label7";
            label7.Size = new Size(151, 23);
            label7.TabIndex = 25;
            label7.Text = "Have an account ?";
            // 
            // login_link
            // 
            login_link.AutoSize = true;
            login_link.Font = new Font("Segoe UI", 10F);
            login_link.Location = new Point(313, 619);
            login_link.Name = "login_link";
            login_link.Size = new Size(52, 23);
            login_link.TabIndex = 26;
            login_link.TabStop = true;
            login_link.Text = "Login";
            login_link.LinkClicked += login_link_LinkClicked;
            // 
            // Register_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 675);
            Controls.Add(login_link);
            Controls.Add(label7);
            Controls.Add(phide1);
            Controls.Add(peye1);
            Controls.Add(phide);
            Controls.Add(peye);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label6);
            Controls.Add(cboAddress);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnRegister);
            Controls.Add(label1);
            Controls.Add(txtRegpass);
            Controls.Add(txtEmail);
            Controls.Add(txtConfirmpass);
            Controls.Add(txtPhone);
            Controls.Add(txtRegname);
            Controls.Add(pictureBox1);
            Name = "Register_form";
            Text = "Register";
            Load += Register_form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)peye).EndInit();
            ((System.ComponentModel.ISupportInitialize)phide).EndInit();
            ((System.ComponentModel.ISupportInitialize)peye1).EndInit();
            ((System.ComponentModel.ISupportInitialize)phide1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Button btnRegister;
        private TextBox txtRegname;
        private TextBox txtPhone;
        private TextBox txtConfirmpass;
        private TextBox txtEmail;
        private TextBox txtRegpass;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cboAddress;
        private Label label6;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox peye;
        private PictureBox phide;
        private PictureBox peye1;
        private PictureBox phide1;
        private Label label7;
        private LinkLabel login_link;
    }
}