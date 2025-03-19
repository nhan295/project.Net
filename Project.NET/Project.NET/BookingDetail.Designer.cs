namespace Project.NET
{
    partial class BookingDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingDetail));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label7 = new Label();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(301, 351);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(320, 12);
            label1.Name = "label1";
            label1.Size = new Size(393, 34);
            label1.TabIndex = 1;
            label1.Text = "Cháu Cháu cho chú gờ cu cái miếng";
            // 
            // label2
            // 
            label2.Location = new Point(331, 52);
            label2.Name = "label2";
            label2.Size = new Size(140, 23);
            label2.TabIndex = 2;
            label2.Text = "Thứ tư, 08/04/2025";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(486, 52);
            label3.Name = "label3";
            label3.Size = new Size(1, 20);
            label3.TabIndex = 3;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(511, 52);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 4;
            label4.Text = "18:20 ~ 20:17";
            label4.Click += label4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(331, 87);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(376, 97);
            label5.Name = "label5";
            label5.Size = new Size(187, 28);
            label5.TabIndex = 6;
            label5.Text = "Rạp cho chú gờ cu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(331, 148);
            label6.Name = "label6";
            label6.Size = new Size(269, 40);
            label6.TabIndex = 7;
            label6.Text = "Tầng 5, Lầu 13, Tòa nhà thổ, Đường 69, \r\nPhường Ác Quỷ, Quận FreeFire\r\n";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(331, 202);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(39, 58);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(376, 233);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(57, 27);
            textBox1.TabIndex = 9;
            textBox1.Text = "M8, M7";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(376, 202);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(79, 27);
            textBox2.TabIndex = 10;
            textBox2.Text = "Cinema 3";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(511, 209);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 11;
            label7.Text = "Tổng Cộng:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(597, 206);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(116, 27);
            textBox3.TabIndex = 12;
            textBox3.Text = "169.000VND";
            // 
            // BookingDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 375);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "BookingDetail";
            Text = "BookingDetail";
            Load += BookingDetail_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label7;
        private TextBox textBox3;
    }
}