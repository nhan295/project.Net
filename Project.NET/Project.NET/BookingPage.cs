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
        private List<Button> timeButtons = new List<Button>();

        public BookingPage(int filmId, string filmTitle)
        {
            InitializeComponent();
            this.filmId = filmId;
            this.filmTitle = filmTitle;
            labelName.Text = filmTitle;
            UpdateDate();
            DefaultDay();
            UpdateDay();
            clsConnectDB.OpenConnection();
            LoadCinemaList();
            cbCinema.SelectedIndexChanged += cbCinema_SelectedIndexChanged;
        }

        private void LoadCinemaList()
        {
            clsConnectDB.OpenConnection();
            string query = @"SELECT DISTINCT c.cinema_id, c.cinema_name 
                 FROM Cinema c
                 INNER JOIN MovieCinema mc ON c.cinema_id = mc.cinema_id
                 WHERE mc.film_id = @filmId";

            using (SqlCommand com = new SqlCommand(query, clsConnectDB.conn))
            {
                try
                {
                    com.Parameters.AddWithValue("@filmId", this.filmId);
                    using (SqlDataReader reader = com.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        cbCinema.DisplayMember = "cinema_name";
                        cbCinema.ValueMember = "cinema_id";
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
            if (cbCinema.SelectedValue == null || selectedButton == null)
            {
                panelTime.Visible = false;
                return;
            }

            if (int.TryParse(cbCinema.SelectedValue.ToString(), out int cinemaId))
            {
                string selectedDate = selectedButton.Tag.ToString();
                clsSession.CinemaId = cinemaId;
                LoadShowtimes(cinemaId, selectedDate);
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

            if (cbCinema.SelectedValue != null)
            {
                int cinemaId = Convert.ToInt32(cbCinema.SelectedValue);
                string selectedDate = clickedButton.Tag.ToString();
                LoadShowtimes(cinemaId, selectedDate);
            }
        }

        private void DefaultDay()
        {
            btnDay.BackColor = Color.Salmon;
            selectedButton = btnDay;
        }

        private void UpdateDay()
        {
            List<Button> buttonList = new List<Button> { btnDay, btnDay1, btnDay2, btnDay3, btnDay4, btnDay5, btnDay6 };
            DateTime today = DateTime.Now;

            for (int i = 0; i < buttonList.Count; i++)
            {
                buttonList[i].Text = today.AddDays(i).ToString("dd");
                buttonList[i].Tag = today.AddDays(i).ToString("yyyy-MM-dd");
                buttonList[i].Click += btnDay_Click;
            }
        }

        private void UpdateDate()
        {
            List<Label> labelList = new List<Label> { labDate, labDate1, labDate2, labDate3, labDate4, labDate5, labDay6 };
            DateTime today = DateTime.Now;

            for (int i = 0; i < labelList.Count; i++)
            {
                labelList[i].Text = today.AddDays(i).ToString("dddd");
            }
        }

        private void LoadShowtimes(int cinemaId, string showDate)
        {
            foreach (var btn in timeButtons)
            {
                panelTime.Controls.Remove(btn);
            }
            timeButtons.Clear();

            string query = @"SELECT showtime_id, show_time FROM Showtimes 
                     WHERE film_id = @filmId AND cinema_id = @cinemaId AND show_date = @showDate";

            using (SqlCommand cmd = new SqlCommand(query, clsConnectDB.conn))
            {
                cmd.Parameters.AddWithValue("@filmId", this.filmId);
                cmd.Parameters.AddWithValue("@cinemaId", cinemaId);
                cmd.Parameters.AddWithValue("@showDate", showDate);


                SqlDataReader reader = cmd.ExecuteReader();
                List<(int, string)> showtimes = new List<(int, string)>();


                while (reader.Read())
                {
                    int showtimeId = Convert.ToInt32(reader["showtime_id"]);
                    string showTime = reader["show_time"].ToString();
                    showtimes.Add((showtimeId, showTime));

                }
                reader.Close();

                int x = 20;
                int y = 10;

                foreach (var (showtimeId, time) in showtimes)
                {
                    Button newButton = new Button
                    {
                        Text = DateTime.Parse(time).ToString("HH:mm"),
                        Location = new Point(x, y),
                        Size = new Size(60, 30),
                        BackColor = Color.White,
                        Tag = showtimeId
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
            int showtimeId = (int)clickedButton.Tag;
            clsSession.ShowtimeId = showtimeId;
            SeatPage seatPage = new SeatPage();
            seatPage.Show();

            //this.Hide(); 
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

        private void labDay6_Click(object sender, EventArgs e)
        {

        }

        private void cbCinema_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
