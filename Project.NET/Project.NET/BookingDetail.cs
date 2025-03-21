using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.NET
{
    public partial class BookingDetail : Form
    {
        private int invoiceId;
        public BookingDetail(int invoiceId)
        {
            InitializeComponent();
            this.invoiceId = invoiceId;
        }

        private void BookingDetail_Load(object sender, EventArgs e)
        {
            try
            {
                clsConnectDB.OpenConnection();
                SqlCommand com = new SqlCommand(@"select f.title, f.thumbnail, sc.room_name, s.show_date, s.show_time, c.cinema_name, c.location, se.seat_number 
                                                from invoice i 
                                                inner join film f on i.film_id = f.film_id 
                                                inner join screeningroom sc on i.screeningroom_id = sc.screeningroom_id
                                                inner join showtimes s on i.showtime_id = s.showtime_id 
                                                inner join cinema c on i.cinema_id = c.cinema_id 
                                                inner join seat se on i.seat_id = se.seat_id 
                                                where invoice_id = @invoiceId;", clsConnectDB.conn);
                SqlParameter p = new SqlParameter("@invoiceId", SqlDbType.Int);
                p.Value = this.invoiceId;
                com.Parameters.Add(p);

                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    lblFilmTitle.Text = reader["title"].ToString();
                    lblDate.Text = Convert.ToDateTime(reader["show_date"]).ToString("yyyy-MM-dd");
                    lblTime.Text = reader["show_time"].ToString();
                    txtCinema.Text = reader["cinema_name"].ToString();
                    lblCinemaAddress.Text = reader["location"].ToString();
                    txtSeat.Text = reader["seat_number"].ToString();
                    txtScreeningRoom.Text = reader["room_name"].ToString();

                    string imageName = reader["thumbnail"].ToString().Trim();

                    Image movieImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
                    if (movieImage != null)
                    {
                        picThumb.Image = movieImage;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy ảnh: " + imageName, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                clsConnectDB.CloseConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
