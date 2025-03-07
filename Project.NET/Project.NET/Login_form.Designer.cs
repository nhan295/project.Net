namespace Project.NET
{
    partial class Login_form
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            txtEmail = new TextBox();
            txtPass = new TextBox();
            btn_login = new Button();
            linkLabel1 = new LinkLabel();
            btn_register = new Button();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cinema_hall_white_blank_screen_600nw_2469487437;
            pictureBox1.Location = new Point(2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(560, 249);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(69, 289);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.padlock;
            pictureBox3.Location = new Point(69, 361);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(138, 289);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(302, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(138, 361);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(302, 27);
            txtPass.TabIndex = 4;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.DarkRed;
            btn_login.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = SystemColors.ButtonHighlight;
            btn_login.Location = new Point(138, 425);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(302, 55);
            btn_login.TabIndex = 5;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10F);
            linkLabel1.LinkColor = Color.MediumBlue;
            linkLabel1.Location = new Point(219, 501);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(149, 23);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot password ?";
            // 
            // btn_register
            // 
            btn_register.BackColor = SystemColors.ButtonFace;
            btn_register.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold);
            btn_register.ForeColor = SystemColors.ControlDarkDark;
            btn_register.Location = new Point(166, 603);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(250, 48);
            btn_register.TabIndex = 7;
            btn_register.Text = "Create Membership Account";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 12F);
            label1.Location = new Point(269, 550);
            label1.Name = "label1";
            label1.Size = new Size(39, 27);
            label1.TabIndex = 8;
            label1.Text = "OR";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.minus;
            pictureBox4.Location = new Point(117, 551);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(162, 26);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.minus;
            pictureBox5.Location = new Point(288, 551);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(162, 26);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // Login_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 675);
            Controls.Add(label1);
            Controls.Add(btn_register);
            Controls.Add(linkLabel1);
            Controls.Add(btn_login);
            Controls.Add(txtPass);
            Controls.Add(txtEmail);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Name = "Login_form";
            Text = "Login";
            Load += Login_form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox txtEmail;
        private TextBox txtPass;
        private Button btn_login;
        private LinkLabel linkLabel1;
        private Button btn_register;
        private Label label1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}
