using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProfilePageApp;
using Microsoft.Data.SqlClient;

namespace Project.NET
{
    public partial class HomePage : Form
    {
        private List<string> movieImages = new List<string>();

        private Image[] slideImages = {
            Properties.Resources.toy,
            Properties.Resources.frozen,
            Properties.Resources.inception

    };
        private int currentIndex = 0;
        public HomePage()
        {
            InitializeComponent();
            LoadSlideImage();
            LoadMovies();
            
            timer1.Tick += TimerSlide_Tick;
            timer1.Start();
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            txtName.Text = clsSession.CusName;
        }

        private void LoadMovies()
        {
            clsConnectDB.OpenConnection();

            // Lấy danh sách phim có status = 'Showing'
            string query = "SELECT film_id, title, thumbnail FROM film WHERE film_status = 'Showing' ORDER BY film_id ASC";

            using (SqlCommand com = new SqlCommand(query, clsConnectDB.conn))
            {
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    flowFilmPanel1.Controls.Clear(); // Xóa các phần tử cũ trước khi load mới

                    while (reader.Read())
                    {
                        int filmId = Convert.ToInt32(reader["film_id"]);
                        string filmTitle = reader["title"].ToString();
                        string imageName = reader["thumbnail"].ToString();

                        // Load ảnh từ resource
                        Image movieImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                        if (movieImage == null)
                        {
                            movieImage = Properties.Resources.images;
                        }

                        // Tạo Panel chứa ảnh và tên phim
                        Panel filmPanel = new Panel
                        {
                            Size = new Size(150, 220),
                            Margin = new Padding(10),
                            BorderStyle = BorderStyle.FixedSingle
                        };

                        // Tạo PictureBox hiển thị thumbnail
                        PictureBox pictureBox = new PictureBox
                        {
                            Image = movieImage,
                            Size = new Size(150, 180),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Cursor = Cursors.Hand
                        };

                        // Sự kiện khi click vào ảnh phim
                        pictureBox.Click += (s, e) => OpenMovieDetail(filmId);

                        // Tạo Label hiển thị tên phim
                        Label nameLabel = new Label
                        {
                            Text = filmTitle,
                            AutoSize = false,
                            Size = new Size(150, 40),
                            TextAlign = ContentAlignment.MiddleCenter,
                            Font = new Font("Arial", 10, FontStyle.Bold),
                            ForeColor = Color.Black
                        };

                        // Thêm PictureBox và Label vào Panel
                        filmPanel.Controls.Add(pictureBox);
                        filmPanel.Controls.Add(nameLabel);
                        nameLabel.Location = new Point(0, pictureBox.Height);

                        // Thêm Panel vào flowFilmPanel1
                        flowFilmPanel1.Controls.Add(filmPanel);
                    }
                }
            }
        }

        private void LoadCommingMovies()
        {
            clsConnectDB.OpenConnection();

            // Lấy danh sách phim có status = 'Showing'
            string query = "SELECT film_id, title, thumbnail FROM film WHERE film_status = 'Comming' ORDER BY film_id ASC";

            using (SqlCommand com = new SqlCommand(query, clsConnectDB.conn))
            {
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    flowFilmPanel1.Controls.Clear(); // Xóa các phần tử cũ trước khi load mới

                    while (reader.Read())
                    {
                        int filmId = Convert.ToInt32(reader["film_id"]);
                        string filmTitle = reader["title"].ToString();
                        string imageName = reader["thumbnail"].ToString();

                        // Load ảnh từ resource
                        Image movieImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                        if (movieImage == null)
                        {
                            movieImage = Properties.Resources.images;
                        }

                        // Tạo Panel chứa ảnh và tên phim
                        Panel filmPanel = new Panel
                        {
                            Size = new Size(150, 220),
                            Margin = new Padding(10),
                            BorderStyle = BorderStyle.FixedSingle
                        };

                        // Tạo PictureBox hiển thị thumbnail
                        PictureBox pictureBox = new PictureBox
                        {
                            Image = movieImage,
                            Size = new Size(150, 180),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Cursor = Cursors.Hand
                        };

                        // Sự kiện khi click vào ảnh phim
                        pictureBox.Click += (s, e) => OpenMovieDetail(filmId);

                        // Tạo Label hiển thị tên phim
                        Label nameLabel = new Label
                        {
                            Text = filmTitle,
                            AutoSize = false,
                            Size = new Size(150, 40),
                            TextAlign = ContentAlignment.MiddleCenter,
                            Font = new Font("Arial", 10, FontStyle.Bold),
                            ForeColor = Color.Black
                        };

                        // Thêm PictureBox và Label vào Panel
                        filmPanel.Controls.Add(pictureBox);
                        filmPanel.Controls.Add(nameLabel);
                        nameLabel.Location = new Point(0, pictureBox.Height);

                        // Thêm Panel vào flowFilmPanel1
                        flowFilmPanel1.Controls.Add(filmPanel);
                    }
                }
            }
        }

        private void OpenMovieDetail(int filmId)
        {
            clsSession.FilmId = filmId;
            MovieDetail detailForm = new MovieDetail(filmId);
            detailForm.ShowDialog();
        }






        private void LoadSlideImage()
        {
            pictureBox3.Image = slideImages[currentIndex];
        }

        private void TimerSlide_Tick(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % slideImages.Length;
            pictureBox3.Image = slideImages[currentIndex];
        }


        private void label1_Click(object sender, EventArgs e)
        {
            LoadMovies();
        }

        bool sidebarExpand = false;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 0)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 217)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }

            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }



        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void btnAccountInformation_Click(object sender, EventArgs e)
        {

            ProfilePage profilePage = new ProfilePage();
            profilePage.Owner = this;
            profilePage.ShowDialog();

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            clsSession.CusId = 0;
            Login_form login = new Login_form();
            this.Hide();
            login.ShowDialog();
            this.Close();

        }

        private void btn_ChangePass_Click(object sender, EventArgs e)
        {
            ChangePassword ChangePass = new ChangePassword();
            ChangePass.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Ticket_Click(object sender, EventArgs e)
        {
            BookingHistoryPage bookingHistoryPage = new BookingHistoryPage();
            bookingHistoryPage.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            BookingHistoryPage bookingHistoryPage = new BookingHistoryPage();
            bookingHistoryPage.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            LoadCommingMovies();
        }
    }
}
