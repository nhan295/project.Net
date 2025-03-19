using System;
using System.Windows.Forms;

namespace Project.NET
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        private void btnUpcoming_Click(object sender, EventArgs e)
        {
            pnlUpcomingMovies.Visible = true;
            pnlWatchedMovies.Visible = false;
        }

        private void btnWatched_Click(object sender, EventArgs e)
        {
            pnlUpcomingMovies.Visible = false;
            pnlWatchedMovies.Visible = true;
        }
    }
}
