using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.NET
{
    public partial class SeatPage : Form
    {

        private int cusId, cinemaId, filmId, showtimeId;
        private List<Button> seatButtons = new List<Button>();

        public SeatPage()
        {
            InitializeComponent();

            this.cusId = clsSession.CusId;
            this.cinemaId = clsSession.CinemaId;
            this.filmId = clsSession.FilmId;
            this.showtimeId = clsSession.ShowtimeId;

            LoadSeats();
        }
        private int selectedScreeningRoomId; 

        private void LoadSeats()
        {
            if (panelSeats == null)
            {
                MessageBox.Show("Lỗi: panelSeats chưa được tạo!");
                return;
            }

            try
            {
                clsConnectDB.OpenConnection();


                string roomQuery = "SELECT DISTINCT screeningroom_id FROM Seat WHERE showtime_id = @showtimeId";
                List<int> roomIds = new List<int>();

                using (SqlCommand cmd = new SqlCommand(roomQuery, clsConnectDB.conn))
                {
                    cmd.Parameters.AddWithValue("@showtimeId", this.showtimeId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        roomIds.Add(reader.GetInt32(0));
                    }
                    reader.Close();
                }

                if (roomIds.Count == 0)
                {
                    MessageBox.Show("Không có phòng chiếu nào cho suất này!");
                    return;
                }
                Random rand = new Random();
                selectedScreeningRoomId = roomIds[rand.Next(roomIds.Count)];

                string seatQuery = "SELECT seat_number, seat_status FROM Seat WHERE showtime_id = @showtimeId AND screeningroom_id = @screeningRoomId";

                using (SqlCommand cmd = new SqlCommand(seatQuery, clsConnectDB.conn))
                {
                    cmd.Parameters.AddWithValue("@showtimeId", this.showtimeId);
                    cmd.Parameters.AddWithValue("@screeningRoomId", selectedScreeningRoomId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    panelSeats.Controls.Clear();
                    seatButtons.Clear();

                    int totalSeats = 0;
                    List<(string, bool)> seatData = new List<(string, bool)>();

                    while (reader.Read())
                    {
                        string seatNumber = reader["seat_number"].ToString();
                        bool isBooked = reader["seat_status"].ToString() == "1";
                        seatData.Add((seatNumber, isBooked));
                        totalSeats++;
                    }
                    reader.Close();

                    if (totalSeats == 0)
                    {
                        MessageBox.Show("Không tìm thấy ghế trong phòng này!");
                        return;
                    }

                    panelSeats.Controls.Clear();
                    seatButtons.Clear();

                    int rowCount = 3; 
                    int[] seatsPerRow = { 3, 3, 4 }; 

                    int buttonSize = 50; 
                    int panelWidth = panelSeats.Width;
                    int panelHeight = panelSeats.Height;

                    int y = 10; 
                    int seatIndex = 0;

                    for (int row = 0; row < rowCount; row++)
                    {
                        int colCount = seatsPerRow[row]; 

                        int totalButtonWidth = colCount * buttonSize;
                        int spacing = (panelWidth - totalButtonWidth) / (colCount + 1);

                        int x = spacing; 

                        for (int col = 0; col < colCount; col++)
                        {
                            if (seatIndex >= totalSeats) break;

                            var (seatNumber, isBooked) = seatData[seatIndex];

                            Button seatButton = new Button
                            {
                                Text = seatNumber,
                                Size = new Size(buttonSize, buttonSize),
                                Location = new Point(x, y),
                                BackColor = isBooked ? Color.Gray : Color.LightGreen,
                                Enabled = !isBooked
                            };

                            seatButton.Click += SeatButton_Click;
                            panelSeats.Controls.Add(seatButton);
                            seatButtons.Add(seatButton);

                            x += buttonSize + spacing; 
                            seatIndex++;
                        }
                        y += buttonSize + 30;
                    }




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải ghế: " + ex.Message);
            }
        }







        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton.BackColor == Color.LightGreen)
            {
                clickedButton.BackColor = Color.Blue; 
            }
            else if (clickedButton.BackColor == Color.Blue)
            {
                clickedButton.BackColor = Color.LightGreen; 
            }
        }

        private void Screen_Click(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            List<string> selectedSeats = new List<string>();

            foreach (var button in seatButtons)
            {
                if (button.BackColor == Color.Blue) 
                {
                    selectedSeats.Add(button.Text);
                }
            }

            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế!");
                return;
            }

            try
            {
                if (clsConnectDB.conn.State != ConnectionState.Open)
                    clsConnectDB.OpenConnection();

                foreach (var seat in selectedSeats)
                {

                    string seatQuery = "SELECT seat_id FROM Seat WHERE seat_number = @seatNumber AND showtime_id = @showtimeId AND screeningroom_id = @screeningRoomId";
                    int seatId = -1;

                    using (SqlCommand seatCmd = new SqlCommand(seatQuery, clsConnectDB.conn))
                    {
                        seatCmd.Parameters.AddWithValue("@seatNumber", seat);
                        seatCmd.Parameters.AddWithValue("@showtimeId", this.showtimeId);
                        seatCmd.Parameters.AddWithValue("@screeningRoomId", selectedScreeningRoomId); 
                        seatId = Convert.ToInt32(seatCmd.ExecuteScalar());
                    }

                    if (seatId != -1)
                    {
                        string insertInvoiceQuery = @"
                INSERT INTO Invoice (cus_id, screeningroom_id, film_id, seat_id, cinema_id, showtime_id) 
                VALUES (@cusId, @screeningRoomId, @filmId, @seatId, @cinemaId, @showtimeId)";

                        using (SqlCommand cmd = new SqlCommand(insertInvoiceQuery, clsConnectDB.conn))
                        {
                            cmd.Parameters.AddWithValue("@cusId", this.cusId);
                            cmd.Parameters.AddWithValue("@screeningRoomId", selectedScreeningRoomId); 
                            cmd.Parameters.AddWithValue("@filmId", this.filmId);
                            cmd.Parameters.AddWithValue("@seatId", seatId);
                            cmd.Parameters.AddWithValue("@cinemaId", this.cinemaId);
                            cmd.Parameters.AddWithValue("@showtimeId", this.showtimeId);
                            cmd.ExecuteNonQuery();
                        }

                        string updateSeatQuery = "UPDATE Seat SET seat_status = 1 WHERE seat_id = @seatId";
                        using (SqlCommand updateCmd = new SqlCommand(updateSeatQuery, clsConnectDB.conn))
                        {
                            updateCmd.Parameters.AddWithValue("@seatId", seatId);
                            updateCmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Đặt vé thành công!");
                LoadSeats(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đặt ghế: " + ex.Message);
            }
        }



    }
}
