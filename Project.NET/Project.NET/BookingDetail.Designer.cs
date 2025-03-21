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
            picThumb = new PictureBox();
            lblFilmTitle = new Label();
            lblDate = new Label();
            label3 = new Label();
            lblTime = new Label();
            pictureBox2 = new PictureBox();
            txtCinema = new Label();
            lblCinemaAddress = new Label();
            txtSeat = new TextBox();
            txtScreeningRoom = new TextBox();
            label7 = new Label();
            txtTotalPrice = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picThumb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // picThumb
            // 
            picThumb.Location = new Point(12, 12);
            picThumb.Name = "picThumb";
            picThumb.Size = new Size(301, 351);
            picThumb.SizeMode = PictureBoxSizeMode.StretchImage;
            picThumb.TabIndex = 0;
            picThumb.TabStop = false;
            // 
            // lblFilmTitle
            // 
            lblFilmTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilmTitle.Location = new Point(320, 12);
            lblFilmTitle.Name = "lblFilmTitle";
            lblFilmTitle.Size = new Size(393, 34);
            lblFilmTitle.TabIndex = 1;
            // 
            // lblDate
            // 
            lblDate.Location = new Point(331, 52);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(140, 23);
            lblDate.TabIndex = 2;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(486, 52);
            label3.Name = "label3";
            label3.Size = new Size(1, 20);
            label3.TabIndex = 3;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(511, 52);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(0, 20);
            lblTime.TabIndex = 4;
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
            // 
            // txtCinema
            // 
            txtCinema.AutoSize = true;
            txtCinema.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCinema.Location = new Point(376, 97);
            txtCinema.Name = "txtCinema";
            txtCinema.Size = new Size(0, 28);
            txtCinema.TabIndex = 6;
            // 
            // lblCinemaAddress
            // 
            lblCinemaAddress.AutoSize = true;
            lblCinemaAddress.Location = new Point(331, 148);
            lblCinemaAddress.MaximumSize = new Size(300, 0);
            lblCinemaAddress.Name = "lblCinemaAddress";
            lblCinemaAddress.Size = new Size(0, 20);
            lblCinemaAddress.TabIndex = 13;
            lblCinemaAddress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSeat
            // 
            txtSeat.Location = new Point(376, 233);
            txtSeat.Name = "txtSeat";
            txtSeat.Size = new Size(57, 27);
            txtSeat.TabIndex = 9;
            // 
            // txtScreeningRoom
            // 
            txtScreeningRoom.Location = new Point(376, 202);
            txtScreeningRoom.Name = "txtScreeningRoom";
            txtScreeningRoom.Size = new Size(79, 27);
            txtScreeningRoom.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(550, 209);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 11;
            label7.Text = "Total:";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(597, 206);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(116, 27);
            txtTotalPrice.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.room;
            pictureBox1.Location = new Point(337, 202);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.seat;
            pictureBox3.Location = new Point(337, 233);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // BookingDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 375);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(txtTotalPrice);
            Controls.Add(label7);
            Controls.Add(txtScreeningRoom);
            Controls.Add(txtSeat);
            Controls.Add(lblCinemaAddress);
            Controls.Add(txtCinema);
            Controls.Add(pictureBox2);
            Controls.Add(lblTime);
            Controls.Add(label3);
            Controls.Add(lblDate);
            Controls.Add(lblFilmTitle);
            Controls.Add(picThumb);
            Name = "BookingDetail";
            Text = "BookingDetail";
            Load += BookingDetail_Load;
            ((System.ComponentModel.ISupportInitialize)picThumb).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picThumb;
        private Label lblFilmTitle;
        private Label lblDate;
        private Label label3;
        private Label lblTime;
        private PictureBox pictureBox2;
        private Label txtCinema;
        private Label lblCinemaAddress;
        private TextBox txtSeat;
        private TextBox txtScreeningRoom;
        private Label label7;
        private TextBox txtTotalPrice;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
    }
}