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
            pictureBox3 = new PictureBox();
            txtSeat = new TextBox();
            txtScreeningRoom = new TextBox();
            label7 = new Label();
            txtTotalPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picThumb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // picThumb
            // 
            picThumb.Location = new Point(15, 15);
            picThumb.Margin = new Padding(4, 4, 4, 4);
            picThumb.Name = "picThumb";
            picThumb.Size = new Size(376, 439);
            picThumb.SizeMode = PictureBoxSizeMode.StretchImage;
            picThumb.TabIndex = 0;
            picThumb.TabStop = false;
            // 
            // lblFilmTitle
            // 
            lblFilmTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilmTitle.Location = new Point(400, 15);
            lblFilmTitle.Margin = new Padding(4, 0, 4, 0);
            lblFilmTitle.Name = "lblFilmTitle";
            lblFilmTitle.Size = new Size(491, 42);
            lblFilmTitle.TabIndex = 1;
            // 
            // lblDate
            // 
            lblDate.Location = new Point(414, 65);
            lblDate.Margin = new Padding(4, 0, 4, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(175, 29);
            lblDate.TabIndex = 2;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(608, 65);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(1, 25);
            label3.TabIndex = 3;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(639, 65);
            lblTime.Margin = new Padding(4, 0, 4, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(0, 25);
            lblTime.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(414, 109);
            pictureBox2.Margin = new Padding(4, 4, 4, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // txtCinema
            // 
            txtCinema.AutoSize = true;
            txtCinema.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCinema.Location = new Point(470, 121);
            txtCinema.Margin = new Padding(4, 0, 4, 0);
            txtCinema.Name = "txtCinema";
            txtCinema.Size = new Size(0, 32);
            txtCinema.TabIndex = 6;
            // 
            // lblCinemaAddress
            // 
            lblCinemaAddress.AutoSize = true;
            lblCinemaAddress.Location = new Point(414, 185);
            lblCinemaAddress.Margin = new Padding(4, 0, 4, 0);
            lblCinemaAddress.MaximumSize = new Size(375, 0);
            lblCinemaAddress.Name = "lblCinemaAddress";
            lblCinemaAddress.Size = new Size(0, 25);
            lblCinemaAddress.TabIndex = 13;
            lblCinemaAddress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(414, 252);
            pictureBox3.Margin = new Padding(4, 4, 4, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(49, 72);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // txtSeat
            // 
            txtSeat.Location = new Point(470, 291);
            txtSeat.Margin = new Padding(4, 4, 4, 4);
            txtSeat.Name = "txtSeat";
            txtSeat.Size = new Size(70, 31);
            txtSeat.TabIndex = 9;
            // 
            // txtScreeningRoom
            // 
            txtScreeningRoom.Location = new Point(470, 252);
            txtScreeningRoom.Margin = new Padding(4, 4, 4, 4);
            txtScreeningRoom.Name = "txtScreeningRoom";
            txtScreeningRoom.Size = new Size(98, 31);
            txtScreeningRoom.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(688, 261);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(53, 25);
            label7.TabIndex = 11;
            label7.Text = "Total:";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(746, 258);
            txtTotalPrice.Margin = new Padding(4, 4, 4, 4);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(144, 31);
            txtTotalPrice.TabIndex = 12;
            // 
            // BookingDetail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 469);
            Controls.Add(txtTotalPrice);
            Controls.Add(label7);
            Controls.Add(txtScreeningRoom);
            Controls.Add(txtSeat);
            Controls.Add(pictureBox3);
            Controls.Add(lblCinemaAddress);
            Controls.Add(txtCinema);
            Controls.Add(pictureBox2);
            Controls.Add(lblTime);
            Controls.Add(label3);
            Controls.Add(lblDate);
            Controls.Add(lblFilmTitle);
            Controls.Add(picThumb);
            Margin = new Padding(4, 4, 4, 4);
            Name = "BookingDetail";
            Text = "BookingDetail";
            Load += BookingDetail_Load;
            ((System.ComponentModel.ISupportInitialize)picThumb).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox3;
        private TextBox txtSeat;
        private TextBox txtScreeningRoom;
        private Label label7;
        private TextBox txtTotalPrice;
    }
}