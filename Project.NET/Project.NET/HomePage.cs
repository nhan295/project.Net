using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProfilePageApp;

namespace Project.NET
{
    public partial class HomePage : Form
    {

        private Image[] slideImages = {
            Properties.Resources.toy,
            Properties.Resources.frozen,
            Properties.Resources.inception

    };
        private int currentIndex = 0;
        public HomePage()
        {
            InitializeComponent();
            LoadSlideImage();
            timer1.Tick += TimerSlide_Tick;
            timer1.Start();
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void LoadSlideImage()
        {
            pictureBox3.Image = slideImages[currentIndex];
        }

        private void TimerSlide_Tick(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % slideImages.Length;
            pictureBox3.Image = slideImages[currentIndex];
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        bool sidebarExpand = false;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 0)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 217)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }

            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }



        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void btnAccountInformation_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ProfilePage profilePage = new ProfilePage();
            profilePage.Owner = this;
            profilePage.ShowDialog();
            //this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            clsSession.CusId = 0;
            Login_form login = new Login_form();
            this.Hide();
            login.ShowDialog();
            this.Close();

        }

        private void btn_ChangePass_Click(object sender, EventArgs e)
        {
            ChangePassword ChangePass = new ChangePassword();
            ChangePass.ShowDialog();
        }
    }
}
