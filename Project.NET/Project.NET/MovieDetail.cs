using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Project.NET
{
    public partial class MovieDetail : Form
    {
        public MovieDetail()
        {
            InitializeComponent();
        }

        private void MovieDetail_Load(object sender, EventArgs e)
        {
            try
            {
                clsConnectDB.OpenConnection();
                int filmId = 3; //clsCurrentFilm.FilmId;
                SqlCommand com = new SqlCommand("select title, release_date, s.time, descriptions, rated, genre_name, director, film_language, thumbnail " +
                                                "from film f inner join Showtimes s on f.film_id = s.film_id " +
                                                "inner join Genre g on f.genre_id = g.genre_id " +
                                                "where f.film_id=@filmId", clsConnectDB.conn);
                SqlParameter p = new SqlParameter("@filmId", SqlDbType.Int);
                p.Value = filmId;
                com.Parameters.Add(p);

                SqlDataReader reader = com.ExecuteReader();

                if(reader.HasRows)
                {
                    if(reader.Read())
                    {
                        txtTitle.Text = reader["title"].ToString();
                        txtDate.Text = Convert.ToDateTime(reader["release_date"]).ToString("yyyy-MM-dd");
                        txtTimeshow.Text = reader["time"].ToString();
                        txtDecrip.Text = reader["descriptions"].ToString();
                        txtRatedCnt.Text = reader["rated"].ToString();
                        txtGerneCnt.Text = reader["genre_name"].ToString();
                        txtDirectorCnt.Text = reader["director"].ToString();
                        txtLanguageCnt.Text = reader["film_language"].ToString();

                        string imgPath = "../../../assets/images/" + reader["thumbnail"].ToString();
                        pictureBox1.Image = Image.FromFile(imgPath);
                        pictureBox2.Image = Image.FromFile(imgPath);
                    }
                }
                else
                {
                    clsConnectDB.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
