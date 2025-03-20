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

                string query = "SELECT seat_number, seat_status FROM Seat WHERE showtime_id = @showtimeId";

                using (SqlCommand cmd = new SqlCommand(query, clsConnectDB.conn))
                {
                    cmd.Parameters.AddWithValue("@showtimeId", this.showtimeId);
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


                    int colCount = 10;
                    int rowCount = (int)Math.Ceiling((double)totalSeats / colCount);


                    int buttonSize = 50;
                    int spacing = 10;


                    int panelWidth = panelSeats.Width;
                    int panelHeight = panelSeats.Height;


                    int totalRowWidth = (buttonSize + spacing) * colCount - spacing;
                    int startX = (panelWidth - totalRowWidth) / 2;
                    if (startX < 0) startX = 10;

                    int totalColumnHeight = (buttonSize + spacing) * rowCount - spacing;
                    int startY = (panelHeight - totalColumnHeight) / 2;
                    if (startY < 0) startY = 10;

                    int x = startX, y = startY;
                    int seatIndex = 0;

                    foreach (var (seatNumber, isBooked) in seatData)
                    {
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

                        seatIndex++;
                        if (seatIndex % colCount == 0)
                        {
                            x = startX;
                            y += buttonSize + spacing;
                        }
                        else
                        {
                            x += buttonSize + spacing;
                        }
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
                clickedButton.BackColor = Color.Blue; // Đổi màu khi chọn
            }
            else if (clickedButton.BackColor == Color.Blue)
            {
                clickedButton.BackColor = Color.LightGreen; // Bỏ chọn
            }
        }

        private void Screen_Click(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            List<string> selectedSeats = new List<string>();

            // Lấy danh sách ghế được chọn
            foreach (var button in seatButtons)
            {
                if (button.BackColor == Color.Blue) // Ghế đã chọn
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
                    // Lấy seat_id từ seat_number
                    string seatQuery = "SELECT seat_id FROM Seat WHERE seat_number = @seatNumber AND showtime_id = @showtimeId";
                    int seatId = -1;

                    using (SqlCommand seatCmd = new SqlCommand(seatQuery, clsConnectDB.conn))
                    {
                        seatCmd.Parameters.AddWithValue("@seatNumber", seat);
                        seatCmd.Parameters.AddWithValue("@showtimeId", this.showtimeId);
                        seatId = Convert.ToInt32(seatCmd.ExecuteScalar());
                    }

                    if (seatId != -1)
                    {
                        // Thêm dữ liệu vào Invoice
                        string insertInvoiceQuery = @"
    INSERT INTO Invoice (cus_id, screeningroom_id, film_id, seat_id, cinema_id, showtime_id) 
    VALUES (
        @cusId, 
        (SELECT TOP 1 screeningroom_id FROM ScreeningRoom WHERE cinema_id = @cinemaId ORDER BY NEWID()), 
        @filmId, 
        @seatId, 
        @cinemaId, 
        @showtimeId)";


                        using (SqlCommand cmd = new SqlCommand(insertInvoiceQuery, clsConnectDB.conn))
                        {
                            cmd.Parameters.AddWithValue("@cusId", this.cusId);
                            cmd.Parameters.AddWithValue("@filmId", this.filmId);
                            cmd.Parameters.AddWithValue("@seatId", seatId);
                            cmd.Parameters.AddWithValue("@cinemaId", this.cinemaId);
                            cmd.Parameters.AddWithValue("@showtimeId", this.showtimeId);
                            cmd.ExecuteNonQuery();
                        }

                        // Cập nhật trạng thái ghế
                        string updateSeatQuery = "UPDATE Seat SET seat_status = 1 WHERE seat_id = @seatId";
                        using (SqlCommand updateCmd = new SqlCommand(updateSeatQuery, clsConnectDB.conn))
                        {
                            updateCmd.Parameters.AddWithValue("@seatId", seatId);
                            updateCmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Đặt vé thành công!");
                LoadSeats(); // Cập nhật lại giao diện ghế
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đặt ghế: " + ex.Message);
            }
        }

    }
}
