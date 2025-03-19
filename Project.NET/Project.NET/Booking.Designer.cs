namespace Project.NET
{
    partial class Booking
    {
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnUpcoming;
        private System.Windows.Forms.Button btnWatched;
        private System.Windows.Forms.Panel pnlUpcomingMovies;
        private System.Windows.Forms.Panel pnlWatchedMovies;
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnUpcoming = new System.Windows.Forms.Button();
            this.btnWatched = new System.Windows.Forms.Button();
            this.pnlUpcomingMovies = new System.Windows.Forms.Panel();
            this.pnlWatchedMovies = new System.Windows.Forms.Panel();
            this.lblNote = new System.Windows.Forms.Label();

            // Form properties
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(640, 500);
            this.Text = "Booking";

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Text = "Booking";

            // btnUpcoming
            this.btnUpcoming.Location = new System.Drawing.Point(20, 60);
            this.btnUpcoming.Size = new System.Drawing.Size(150, 40);
            this.btnUpcoming.Text = "Phim sắp xem";
            this.btnUpcoming.Click += new System.EventHandler(this.btnUpcoming_Click);

            // btnWatched
            this.btnWatched.Location = new System.Drawing.Point(180, 60);
            this.btnWatched.Size = new System.Drawing.Size(150, 40);
            this.btnWatched.Text = "Phim đã xem";
            this.btnWatched.Click += new System.EventHandler(this.btnWatched_Click);

            // pnlUpcomingMovies
            this.pnlUpcomingMovies = new System.Windows.Forms.Panel();
            this.pnlUpcomingMovies.Location = new System.Drawing.Point(20, 110);
            this.pnlUpcomingMovies.Size = new System.Drawing.Size(600, 300);
            this.pnlUpcomingMovies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpcomingMovies.AutoScroll = true; // Bật cuộn

            // pnlWatchedMovies
            this.pnlWatchedMovies = new System.Windows.Forms.Panel();
            this.pnlWatchedMovies.Location = new System.Drawing.Point(20, 110);
            this.pnlWatchedMovies.Size = new System.Drawing.Size(600, 300);
            this.pnlWatchedMovies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWatchedMovies.AutoScroll = true; // Bật cuộn
            this.pnlWatchedMovies.Visible = false;

            // lblNote
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Italic);
            this.lblNote.Location = new System.Drawing.Point(20, 420);
            this.lblNote.Size = new System.Drawing.Size(500, 20);
            this.lblNote.Text = "Chỉ hiển thị giao dịch trong vòng 3 tháng gần nhất, vui lòng liên hệ 0909009099";

            // ========== Thẻ phim ==========
            CreateMovieCards();

            // Add controls
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnUpcoming);
            this.Controls.Add(this.btnWatched);
            this.Controls.Add(this.pnlUpcomingMovies);
            this.Controls.Add(this.pnlWatchedMovies);
            this.Controls.Add(this.lblNote);
            this.ResumeLayout(false);
            this.PerformLayout();
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

                pnlUpcomingMovies.Controls.Add(moviePanel);
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

                pnlWatchedMovies.Controls.Add(moviePanel);
            }
        }


    }
}
