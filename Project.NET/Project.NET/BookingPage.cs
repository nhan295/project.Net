using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

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


            UpdateDay();
            UpdateDate();
            LoadShowtimes();
            DefaultDay();
        }

        private void BookingPage_Load(object sender, EventArgs e)
        {
            panelTime.Visible = false;
            btnDay.PerformClick();
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            panelTime.Visible = !panelTime.Visible;
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

        private void LoadShowtimes()
        {
            // Xóa các button cũ nếu có
            foreach (var btn in timeButtons)
            {
                panelTime.Controls.Remove(btn);
            }
            timeButtons.Clear();

            string query = "SELECT time FROM Showtimes WHERE film_id = @filmId";
            using (SqlCommand cmd = new SqlCommand(query, clsConnectDB.conn))
            {
                cmd.Parameters.AddWithValue("@filmId", filmId);
                SqlDataReader reader = cmd.ExecuteReader();

                List<string> showtimes = new List<string>();
                while (reader.Read())
                {
                    showtimes.Add(reader["time"].ToString());
                }
                reader.Close();

                // Gán vào btnTime và btnTime2 nếu có
                if (showtimes.Count > 0)
                {
                    btnTime.Text = showtimes[0];
                    btnTime.Visible = true;
                    btnTime.Click += BtnTime_Click;
                }
                else
                {
                    btnTime.Visible = false;
                }

                if (showtimes.Count > 1)
                {
                    btnTime2.Text = showtimes[1];
                    btnTime2.Visible = true;
                    btnTime2.Click += BtnTime_Click;
                }
                else
                {
                    btnTime2.Visible = false;
                }

                // Nếu có nhiều hơn 2 suất chiếu, tạo thêm button động
                int x = btnTime2.Right + 10;
                int y = btnTime.Location.Y;
                for (int i = 2; i < showtimes.Count; i++)
                {
                    Button newButton = new Button
                    {
                        Text = showtimes[i],
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
    }
}
