using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Project.NET
{
    public partial class BookingPage : Form
    {
        private int filmId;
        private string filmTitle;
        private Button selectedButton = null;
        private List<Button> timeButtons = new List<Button>(); // Danh sách button suất chiếu

        public BookingPage(int filmId, string filmTitle)
        {
            InitializeComponent();
            this.filmId = filmId;
            this.filmTitle = filmTitle;
            labelName.Text = filmTitle;

            clsConnectDB.OpenConnection();
            LoadCinemaList(); // Tải danh sách rạp
            cbCinema.SelectedIndexChanged += cbCinema_SelectedIndexChanged;
        }





        // Chổ này là show cái drop box các rạp phim làm sao để người ta chọn index theo kiểu drop các rạp rồi chọn rạp mới ra giờ
        private void LoadCinemaList()
        {
            clsConnectDB.OpenConnection();
            string query = "SELECT c.cinema_id, c.cinema_name FROM Cinema c " +
                           "INNER JOIN movieCinema m ON c.cinema_id = m.cinema_id " +
                           "WHERE m.film_id=@filmId";

            using (SqlCommand com = new SqlCommand(query, clsConnectDB.conn))
            {
                try
                {
                    com.Parameters.AddWithValue("@filmId", this.filmId);
                    using (SqlDataReader reader = com.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        cbCinema.DisplayMember = "cinema_name"; // Hiển thị tên rạp
                        cbCinema.ValueMember = "cinema_id"; // Lưu ID của rạp
                        cbCinema.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }


        private void cbCinema_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCinema.SelectedValue != null)
            {
                int cinemaId = Convert.ToInt32(cbCinema.SelectedValue);

                LoadShowtimes(cinemaId);
                panelTime.Visible = true;
            }
        }


        private void btnDay_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (selectedButton != null)
            {
                selectedButton.BackColor = Color.White;
            }

            clickedButton.BackColor = Color.Salmon;
            selectedButton = clickedButton;
        }

        private void DefaultDay()
        {
            btnDay.BackColor = Color.Salmon;
            selectedButton = btnDay;
        }

        private void UpdateDay()
        {
            List<Button> buttonList = new List<Button> { btnDay, btnDay1, btnDay2, btnDay3, btnDay4, btnDay5 };
            DateTime today = DateTime.Now;

            for (int i = 0; i < buttonList.Count; i++)
            {
                buttonList[i].Text = today.AddDays(i).ToString("dd");
                buttonList[i].Click += btnDay_Click;
            }
        }

        private void UpdateDate()
        {
            List<Label> labelList = new List<Label> { labDate, labDate1, labDate2, labDate3, labDate4, labDate5 };
            DateTime today = DateTime.Now;

            for (int i = 0; i < labelList.Count; i++)
            {
                labelList[i].Text = today.AddDays(i).ToString("dddd");
            }
        }

        private void LoadShowtimes(int cinemaId)
        {
            // Xóa các button suất chiếu cũ
            foreach (var btn in timeButtons)
            {
                panelTime.Controls.Remove(btn);
            }
            timeButtons.Clear();

            string query = "SELECT time FROM Showtimes s " +
                "inner join movieCinema m on s.film_id = m.film_id " +
                "WHERE s.film_id = @filmId AND m.cinema_id = @cinemaId";

            using (SqlCommand cmd = new SqlCommand(query, clsConnectDB.conn))
            {
                cmd.Parameters.AddWithValue("@filmId", this.filmId);
                cmd.Parameters.AddWithValue("@cinemaId", cinemaId);

                SqlDataReader reader = cmd.ExecuteReader();
                List<string> showtimes = new List<string>();

                while (reader.Read())
                {
                    showtimes.Add(reader["time"].ToString());
                }
                reader.Close();

                int x = 20;
                int y = 10;

                foreach (var time in showtimes)
                {
                    Button newButton = new Button
                    {
                        Text = time,
                        Location = new Point(x, y),
                        Size = new Size(60, 30),
                        BackColor = Color.White
                    };

                    newButton.Click += BtnTime_Click;
                    panelTime.Controls.Add(newButton);
                    timeButtons.Add(newButton);

                    x += 70; 
                }
            }
        }


        private void BtnTime_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            MessageBox.Show($"Bạn đã chọn suất chiếu: {clickedButton.Text}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
