using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project.NET
{
    public partial class BookingHistoryPage : Form
    {
        private int cusId;
        public BookingHistoryPage()
        {
            InitializeComponent();
            this.cusId = clsSession.CusId;
            LoadInvoices(cusId);


        }

        private void btnUpcoming_Click(object sender, EventArgs e)
        {
            
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void LoadInvoices(int cusId)
        {
            if (cusId <= 0)
            {
                MessageBox.Show("Customer ID không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsConnectDB.OpenConnection();

            string query = @"
        SELECT f.title, s.show_date, c.cinema_name
        FROM Invoice i
        JOIN Film f ON i.film_id = f.film_id
        JOIN Showtimes s ON i.showtime_id = s.showtime_id
        JOIN Cinema c ON i.cinema_id = c.cinema_id
        WHERE i.cus_id = @cus_id";

            using (SqlCommand cmd = new SqlCommand(query, clsConnectDB.conn))
            {
                cmd.Parameters.AddWithValue("@cus_id", cusId);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    flowLayoutPanel1.Controls.Clear(); // Xóa danh sách cũ trước khi load mới

                    while (reader.Read())
                    {
                        string film = reader["title"].ToString();
                        DateTime showtime = Convert.ToDateTime(reader["show_date"]);
                        string formattedShowtime = showtime.ToString("dd MMM yyyy hh:mm tt");
                        string cinema = reader["cinema_name"].ToString();

                        CreateInvoicePanel(film, formattedShowtime, cinema);
                    }
                }
            }
        }

        private void CreateInvoicePanel(string film, string showtime, string cinema)
        {
            Panel panel = new Panel();
            panel.Size = new Size(450, 100);
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Margin = new Padding(10);

            Label lblFilm = new Label();
            lblFilm.Text = film;
            lblFilm.Font = new Font("Arial", 12, FontStyle.Bold);
            lblFilm.Location = new Point(10, 10);
            lblFilm.AutoSize = true;

            Label lblShowtime = new Label();
            lblShowtime.Text = showtime;
            lblShowtime.Font = new Font("Arial", 10, FontStyle.Italic);
            lblShowtime.ForeColor = Color.Gray;
            lblShowtime.Location = new Point(10, 35);
            lblShowtime.AutoSize = true;

            Label lblCinema = new Label();
            lblCinema.Text = cinema;
            lblCinema.Font = new Font("Arial", 10);
            lblCinema.ForeColor = Color.DarkBlue;
            lblCinema.Location = new Point(10, 55);
            lblCinema.AutoSize = true;

            panel.Controls.Add(lblFilm);
            panel.Controls.Add(lblShowtime);
            panel.Controls.Add(lblCinema);

            flowLayoutPanel1.Controls.Add(panel);
        }




        private void pnlUpcomingMovies_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
