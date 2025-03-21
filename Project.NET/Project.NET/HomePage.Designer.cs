namespace Project.NET
{
    partial class HomePage
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel7 = new Panel();
            btnLogOut = new Button();
            pictureBox2 = new PictureBox();
            panel8 = new Panel();
            pictureBox8 = new PictureBox();
            btnAccountInformation = new Button();
            panel9 = new Panel();
            pictureBox7 = new PictureBox();
            btn_Ticket = new Button();
            panel3 = new Panel();
            btn_ChangePass = new Button();
            pictureBox15 = new PictureBox();
            panel6 = new Panel();
            pictureBox5 = new PictureBox();
            txtName = new TextBox();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            btn_menu = new PictureBox();
            sidebar = new FlowLayoutPanel();
            timer1 = new System.Windows.Forms.Timer(components);
            flowFilmPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_menu).BeginInit();
            sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(166, 166);
            label1.Name = "label1";
            label1.Size = new Size(137, 25);
            label1.TabIndex = 0;
            label1.Text = "Now Showing";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(757, 34);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(458, 166);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 2;
            label2.Text = "Coming Soon";
            label2.Click += label2_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnLogOut);
            panel7.Controls.Add(pictureBox2);
            panel7.Location = new Point(3, 146);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(195, 31);
            panel7.TabIndex = 9;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = SystemColors.InactiveCaptionText;
            btnLogOut.ForeColor = SystemColors.ButtonFace;
            btnLogOut.Location = new Point(40, -9);
            btnLogOut.Margin = new Padding(3, 2, 3, 2);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(160, 53);
            btnLogOut.TabIndex = 7;
            btnLogOut.Text = "Log Out";
            btnLogOut.TextAlign = ContentAlignment.MiddleLeft;
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logout;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(pictureBox8);
            panel8.Controls.Add(btnAccountInformation);
            panel8.Location = new Point(3, 41);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(195, 31);
            panel8.TabIndex = 9;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.user2;
            pictureBox8.Location = new Point(0, 2);
            pictureBox8.Margin = new Padding(3, 2, 3, 2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(35, 31);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 8;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // btnAccountInformation
            // 
            btnAccountInformation.BackColor = SystemColors.InactiveCaptionText;
            btnAccountInformation.ForeColor = SystemColors.ButtonFace;
            btnAccountInformation.Location = new Point(40, -9);
            btnAccountInformation.Margin = new Padding(3, 2, 3, 2);
            btnAccountInformation.Name = "btnAccountInformation";
            btnAccountInformation.Size = new Size(160, 53);
            btnAccountInformation.TabIndex = 7;
            btnAccountInformation.Text = "Account Information";
            btnAccountInformation.TextAlign = ContentAlignment.MiddleLeft;
            btnAccountInformation.UseVisualStyleBackColor = false;
            btnAccountInformation.Click += btnAccountInformation_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(pictureBox7);
            panel9.Controls.Add(btn_Ticket);
            panel9.Location = new Point(3, 111);
            panel9.Margin = new Padding(3, 2, 3, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(195, 31);
            panel9.TabIndex = 9;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.ticket;
            pictureBox7.Location = new Point(0, 0);
            pictureBox7.Margin = new Padding(3, 2, 3, 2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(35, 27);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 10;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // btn_Ticket
            // 
            btn_Ticket.BackColor = SystemColors.InactiveCaptionText;
            btn_Ticket.ForeColor = SystemColors.ButtonFace;
            btn_Ticket.Location = new Point(40, -9);
            btn_Ticket.Margin = new Padding(3, 2, 3, 2);
            btn_Ticket.Name = "btn_Ticket";
            btn_Ticket.Size = new Size(160, 53);
            btn_Ticket.TabIndex = 7;
            btn_Ticket.Text = "My Tickets";
            btn_Ticket.TextAlign = ContentAlignment.MiddleLeft;
            btn_Ticket.UseVisualStyleBackColor = false;
            btn_Ticket.Click += btn_Ticket_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_ChangePass);
            panel3.Controls.Add(pictureBox15);
            panel3.Location = new Point(3, 76);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(195, 31);
            panel3.TabIndex = 8;
            panel3.Paint += panel3_Paint;
            // 
            // btn_ChangePass
            // 
            btn_ChangePass.BackColor = SystemColors.InactiveCaptionText;
            btn_ChangePass.ForeColor = SystemColors.ButtonFace;
            btn_ChangePass.Location = new Point(40, -9);
            btn_ChangePass.Margin = new Padding(3, 2, 3, 2);
            btn_ChangePass.Name = "btn_ChangePass";
            btn_ChangePass.Size = new Size(160, 53);
            btn_ChangePass.TabIndex = 7;
            btn_ChangePass.Text = "Change password";
            btn_ChangePass.TextAlign = ContentAlignment.MiddleLeft;
            btn_ChangePass.UseVisualStyleBackColor = false;
            btn_ChangePass.Click += btn_ChangePass_Click;
            // 
            // pictureBox15
            // 
            pictureBox15.Image = Properties.Resources.password;
            pictureBox15.Location = new Point(3, 4);
            pictureBox15.Margin = new Padding(3, 2, 3, 2);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(35, 27);
            pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox15.TabIndex = 11;
            pictureBox15.TabStop = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(pictureBox5);
            panel6.Controls.Add(txtName);
            panel6.Location = new Point(3, 2);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(199, 35);
            panel6.TabIndex = 10;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.dinosaur;
            pictureBox5.Location = new Point(3, 4);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 31);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // txtName
            // 
            txtName.Location = new Point(35, 13);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(149, 23);
            txtName.TabIndex = 9;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(178, 49);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(392, 106);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(315, 9);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 0;
            label3.Text = "CINEMAX";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.notification;
            pictureBox4.Location = new Point(61, 9);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 26);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // btn_menu
            // 
            btn_menu.Image = Properties.Resources.menu;
            btn_menu.Location = new Point(10, 9);
            btn_menu.Margin = new Padding(3, 2, 3, 2);
            btn_menu.Name = "btn_menu";
            btn_menu.Size = new Size(33, 22);
            btn_menu.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_menu.TabIndex = 6;
            btn_menu.TabStop = false;
            btn_menu.Click += btn_menu_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = SystemColors.ActiveCaptionText;
            sidebar.Controls.Add(panel6);
            sidebar.Controls.Add(panel8);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel9);
            sidebar.Controls.Add(panel7);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 34);
            sidebar.Margin = new Padding(3, 2, 3, 2);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(100, 396);
            sidebar.TabIndex = 7;
            // 
            // timer1
            // 
            timer1.Interval = 3000;
            // 
            // flowFilmPanel1
            // 
            flowFilmPanel1.AutoScroll = true;
            flowFilmPanel1.Location = new Point(61, 216);
            flowFilmPanel1.Name = "flowFilmPanel1";
            flowFilmPanel1.Size = new Size(642, 202);
            flowFilmPanel1.TabIndex = 8;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Window;
            ClientSize = new Size(757, 430);
            Controls.Add(flowFilmPanel1);
            Controls.Add(sidebar);
            Controls.Add(btn_menu);
            Controls.Add(pictureBox4);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HomePage";
            Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_menu).EndInit();
            sidebar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private System.Windows.Forms.Timer sidebarTransition;
        private PictureBox pictureBox2;
        private PictureBox btn_menu;
        private FlowLayoutPanel sidebar;
        private Panel panel3;
        private Panel panel6;
        private TextBox textBox1;
        private PictureBox pictureBox5;
        private Button btn_ChangePass;
        private Panel panel7;
        private Button button3;
        private Panel panel8;
        private Button btnAccountInformation;
        private Panel panel9;
        private Button btn_Ticket;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private System.Windows.Forms.Timer timer1;
        private Button btnLogOut;
        private PictureBox pictureBox15;
        private TextBox txtName;
        private FlowLayoutPanel flowFilmPanel1;
    }
}