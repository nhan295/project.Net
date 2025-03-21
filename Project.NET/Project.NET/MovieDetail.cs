using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Project.NET
{
    public partial class MovieDetail : Form
    {
        private int filmId;
        public MovieDetail(int filmId)
        {
            InitializeComponent();
            this.filmId = filmId;
        }

        private void MovieDetail_Load(object sender, EventArgs e)
        {
            try
            {
                clsConnectDB.OpenConnection();

                SqlCommand com = new SqlCommand("SELECT title, release_date, s.show_time, descriptions, rated, genre_name, director, film_language, thumbnail, film_status " +
                                                "FROM film f INNER JOIN Showtimes s ON f.film_id = s.film_id " +
                                                "INNER JOIN Genre g ON f.genre_id = g.genre_id " +
                                                "WHERE f.film_id=@filmId", clsConnectDB.conn);
                com.Parameters.AddWithValue("@filmId", filmId);

                SqlDataReader reader = com.ExecuteReader();

                if (reader.Read())
                {
                    txtTitle.Text = reader["title"].ToString();
                    txtDate.Text = Convert.ToDateTime(reader["release_date"]).ToString("yyyy-MM-dd");
                    txtTimeshow.Text = reader["show_time"].ToString();
                    txtDecrip.Text = reader["descriptions"].ToString();
                    txtRatedCnt.Text = reader["rated"].ToString();
                    txtGerneCnt.Text = reader["genre_name"].ToString();
                    txtDirectorCnt.Text = reader["director"].ToString();
                    txtLanguageCnt.Text = reader["film_language"].ToString();
                    string imageName = reader["thumbnail"].ToString().Trim();
                    string status = reader["film_status"].ToString(); // Lấy trạng thái phim

                    // Kiểm tra nếu status là "Coming" thì vô hiệu hóa nút Book Now
                    if (status.Equals("Comming", StringComparison.OrdinalIgnoreCase))
                    {
                        btnBooking.Enabled = false;
                        btnBooking.Text = "Coming Soon"; // Thay đổi text để người dùng biết
                    }

                    Image movieImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);

                    if (movieImage != null)
                    {
                        CoverFrame.Image = movieImage;
                        PosterFrame.Image = movieImage;
                    }
                    else
                    {
                        string imgPath = Path.Combine(Application.StartupPath, @"..\..\..\assets\images", imageName);

                        if (File.Exists(imgPath))
                        {
                            CoverFrame.Image = Image.FromFile(imgPath);
                            PosterFrame.Image = Image.FromFile(imgPath);
                        }
                        else
                        {
                            CoverFrame.Image = Properties.Resources.images;
                            PosterFrame.Image = Properties.Resources.images;
                        }
                    }

                    CoverFrame.SizeMode = PictureBoxSizeMode.StretchImage;
                    PosterFrame.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnBooking_Click(object sender, EventArgs e)
        {
            BookingPage bookingForm = new BookingPage(filmId, txtTitle.Text);
            bookingForm.ShowDialog();
        }

        private void btnBooking_Click_1(object sender, EventArgs e)
        {
            BookingPage bookingForm = new BookingPage(filmId, txtTitle.Text);
            bookingForm.ShowDialog();
        }
    }
}
