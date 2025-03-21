namespace Project.NET
{
    partial class BookingHistoryPage
    {
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnUpcoming;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.PictureBox picMovie1, picMovie2, picMovie3;
        private System.Windows.Forms.PictureBox picMovie4, picMovie5, picMovie6;

        private System.Windows.Forms.Label lblMovieTitle1, lblMovieTitle2, lblMovieTitle3;
        private System.Windows.Forms.Label lblMovieTitle4, lblMovieTitle5, lblMovieTitle6;

        private System.Windows.Forms.Label lblMovieDesc1, lblMovieDesc2, lblMovieDesc3;
        private System.Windows.Forms.Label lblMovieDesc4, lblMovieDesc5, lblMovieDesc6;

        private System.Windows.Forms.Label lblCinema1, lblCinema2, lblCinema3;
        private System.Windows.Forms.Label lblCinema4, lblCinema5, lblCinema6;

        private System.Windows.Forms.Label lblPrice1, lblPrice2, lblPrice3;
        private System.Windows.Forms.Label lblPrice4, lblPrice5, lblPrice6;

        private System.Windows.Forms.Button btnBook1, btnBook2, btnBook3;
        private System.Windows.Forms.Button btnDetail4, btnDetail5, btnDetail6;

        private void InitializeComponent()
        {
            lblTitle = new Label();
            btnUpcoming = new Button();
            lblNote = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(125, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Booking";
            // 
            // btnUpcoming
            // 
            btnUpcoming.Location = new Point(20, 60);
            btnUpcoming.Name = "btnUpcoming";
            btnUpcoming.Size = new Size(150, 40);
            btnUpcoming.TabIndex = 1;
            btnUpcoming.Text = "Booked Movies";
            btnUpcoming.Click += btnUpcoming_Click;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Font = new Font("Arial", 8F, FontStyle.Italic);
            lblNote.Location = new Point(2, 428);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(635, 16);
            lblNote.TabIndex = 5;
            lblNote.Text = "Only transactions from the last 3 months are displayed. For assistance, please contact 0909009099";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(20, 106);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(600, 300);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // BookingHistoryPage
            // 
            ClientSize = new Size(640, 500);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lblTitle);
            Controls.Add(btnUpcoming);
            Controls.Add(lblNote);
            Name = "BookingHistoryPage";
            Text = "Booking";
            ResumeLayout(false);
            PerformLayout();
        }

        private void CreateMovieCards()
        {
            int startX = 10, startY = 10, spacing = 120;

            // ========== Phim sắp xem ==========
            for (int i = 0; i < 3; i++)
            {
                Panel moviePanel = new Panel
                {
                    Size = new System.Drawing.Size(550, 110),
                    Location = new System.Drawing.Point(startX, startY + i * spacing),
                    BackColor = System.Drawing.Color.DarkGray,  // Đặt màu nền darkgray
                    BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                };

                PictureBox picMovie = new PictureBox
                {
                    Size = new System.Drawing.Size(80, 80),
                    Location = new System.Drawing.Point(10, 15),
                    BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                    ImageLocation = "project.Net\\Project.NET\\Project.NET\\Resources\\godfather.png",
                    SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
                };

                Label lblTitle = new Label
                {
                    Text = "Tên phim " + (i + 1),
                    Location = new System.Drawing.Point(100, 10),
                    Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold),
                    AutoSize = true
                };

                Label lblDesc = new Label
                {
                    Text = "Mô tả phim...",
                    Location = new System.Drawing.Point(100, 30),
                    AutoSize = true
                };

                Label lblCinema = new Label
                {
                    Text = "Rạp: CGV",
                    Location = new System.Drawing.Point(100, 50),
                    AutoSize = true
                };

                Label lblPrice = new Label
                {
                    Text = "Giá: 100,000đ",
                    Location = new System.Drawing.Point(100, 70),
                    AutoSize = true
                };

                Button btnBook = new Button
                {
                    Text = "Booking",
                    Location = new System.Drawing.Point(400, 40), // Đẩy xuống xa hơn
                    Size = new System.Drawing.Size(100, 30)
                };

                moviePanel.Controls.Add(picMovie);
                moviePanel.Controls.Add(lblTitle);
                moviePanel.Controls.Add(lblDesc);
                moviePanel.Controls.Add(lblCinema);
                moviePanel.Controls.Add(lblPrice);
                moviePanel.Controls.Add(btnBook);


            }

            // ========== Phim đã xem ==========
            for (int i = 0; i < 3; i++)
            {
                Panel moviePanel = new Panel
                {
                    Size = new System.Drawing.Size(550, 110),
                    Location = new System.Drawing.Point(startX, startY + i * spacing),
                    BackColor = System.Drawing.Color.DarkGray, // Đặt màu nền darkgray
                    BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                };

                PictureBox picMovie = new PictureBox
                {
                    Size = new System.Drawing.Size(80, 80),
                    Location = new System.Drawing.Point(10, 15),
                    BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                    ImageLocation = "project.Net\\Project.NET\\Project.NET\\Resources\\godfather.png",
                    SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
                };

                Label lblTitle = new Label
                {
                    Text = "Tên phim " + (i + 4),
                    Location = new System.Drawing.Point(100, 10),
                    Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold),
                    AutoSize = true
                };

                Label lblDesc = new Label
                {
                    Text = "Mô tả phim...",
                    Location = new System.Drawing.Point(100, 30),
                    AutoSize = true
                };

                Label lblCinema = new Label
                {
                    Text = "Rạp: Lotte",
                    Location = new System.Drawing.Point(100, 50),
                    AutoSize = true
                };

                Label lblPrice = new Label
                {
                    Text = "Giá: 120,000đ",
                    Location = new System.Drawing.Point(100, 70),
                    AutoSize = true
                };

                Button btnDetail = new Button
                {
                    Text = "View Detail",
                    Location = new System.Drawing.Point(400, 40), // Đẩy xuống xa hơn
                    Size = new System.Drawing.Size(100, 30)
                };

                moviePanel.Controls.Add(picMovie);
                moviePanel.Controls.Add(lblTitle);
                moviePanel.Controls.Add(lblDesc);
                moviePanel.Controls.Add(lblCinema);
                moviePanel.Controls.Add(lblPrice);
                moviePanel.Controls.Add(btnDetail);

                
            }
        }
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
