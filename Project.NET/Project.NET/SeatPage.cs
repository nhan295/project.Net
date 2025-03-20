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
    public partial class SeatPage: Form
    {

        private int showtimeId;
        private List<Button> seatButtons = new List<Button>();

        public SeatPage(int showtimeId)
        {
            InitializeComponent();
            this.showtimeId = showtimeId;
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

                    // Số ghế mỗi hàng
                    int colCount = 10;
                    int rowCount = (int)Math.Ceiling((double)totalSeats / colCount);

                    // Kích thước ghế
                    int buttonSize = 50;
                    int spacing = 10; // Khoảng cách giữa các ghế

                    // Kích thước panel
                    int panelWidth = panelSeats.Width;
                    int panelHeight = panelSeats.Height;

                    // Căn giữa theo chiều ngang
                    int totalRowWidth = (buttonSize + spacing) * colCount - spacing;
                    int startX = (panelWidth - totalRowWidth) / 2;
                    if (startX < 0) startX = 10;

                    // Căn giữa theo chiều dọc
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
                            BackColor = isBooked ? Color.Red : Color.LightGreen,
                            Enabled = !isBooked
                        };

                        seatButton.Click += SeatButton_Click;
                        panelSeats.Controls.Add(seatButton);
                        seatButtons.Add(seatButton);

                        seatIndex++;
                        if (seatIndex % colCount == 0) // Xuống hàng
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
                    string updateQuery = "UPDATE Seats SET seat_status = 1 WHERE showtime_id = @showtimeId AND seat_number = @seatNumber";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, clsConnectDB.conn))
                    {
                        cmd.Parameters.AddWithValue("@showtimeId", this.showtimeId);
                        cmd.Parameters.AddWithValue("@seatNumber", seat);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Đặt ghế thành công!");
                LoadSeats(); // Cập nhật lại ghế sau khi đặt
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đặt ghế: " + ex.Message);
            }
        }
    

        public SeatPage()
        {
            InitializeComponent();
        }
    }
}
