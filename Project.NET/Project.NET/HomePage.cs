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
            LoadNameMovies();
            LoadMovies();
            timer1.Tick += TimerSlide_Tick;
            timer1.Start();
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            txtName.Text = clsSession.CusName;
        }

        private void LoadMovies()
        {
            clsConnectDB.OpenConnection();
            
            string query = "SELECT TOP 6 film_id, thumbnail FROM film ORDER BY film_id ASC";
            using (SqlCommand com = new SqlCommand(query, clsConnectDB.conn))
            {
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    PictureBox[] filmFrames = { FilmFrame1, FilmFrame2, FilmFrame3, FilmFrame4, FilmFrame5, FilmFrame6 };
                    int[] filmIds = new int[6];
                    int index = 0;

                    while (reader.Read() && index < filmFrames.Length)
                    {
                        filmIds[index] = Convert.ToInt32(reader["film_id"]); 
                        string imageName = reader["thumbnail"].ToString();
                        Image movieImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);

                        if (movieImage != null)
                        {
                            filmFrames[index].Image = movieImage;
                        }
                        else
                        {
                            filmFrames[index].Image = Properties.Resources.images;
                        }

                        filmFrames[index].SizeMode = PictureBoxSizeMode.StretchImage;


                        int filmId = filmIds[index];
                        filmFrames[index].Click += (s, e) => OpenMovieDetail(filmId);

                        index++;
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



        private void LoadNameMovies()
        {
            clsConnectDB.OpenConnection();

            string query = "SELECT TOP 6 title FROM film ORDER BY film_id ASC";
            using (SqlCommand com = new SqlCommand(query, clsConnectDB.conn))
            {
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    TextBox[] filmName = { FilmName1, FilmName2, FilmName3, FilmName4, FilmName5, FilmName6 };
                    int index = 0;

                    while (reader.Read() && index < filmName.Length)
                    {
                        string filmname = reader["title"].ToString();


                        filmName[index].Text = filmname;


                        index++;
                    }
                }
            }
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
    }
}
