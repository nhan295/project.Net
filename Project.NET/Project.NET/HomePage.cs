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
    public partial class HomePage : Form
    {
        private string[] imagePaths = {
            @"D:\GitHub\project.Net\Project.NET\Project.NET\Resources\phone-call.png",
            @"D:\GitHub\project.Net\Project.NET\Project.NET\Resources\padlock.png",
            @"D:\GitHub\project.Net\Project.NET\Project.NET\Resources\images.jpg"
        };
        private int currentIndex = 0;
        public HomePage()
        {
            InitializeComponent();
            LoadMovieGrid();
            pictureBoxBanner.ImageLocation = imagePaths[currentIndex]; // Hiển thị ảnh đầu tiên
            timer2.Tick += TimerSlide_Tick;
            timer2.Start();
        }
        private void TimerSlide_Tick(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % imagePaths.Length; // Chuyển ảnh tiếp theo
            pictureBoxBanner.ImageLocation = imagePaths[currentIndex];
        }
        private void LoadMovieGrid()
        {
            string[] imagePaths = {
                @"D:\GitHub\project.Net\Project.NET\Project.NET\Resources\cinema-hall-white-blank-screen-600nw-2469487437.jpg",
                @"D:\GitHub\project.Net\Project.NET\Project.NET\Resources\cinema-hall-white-blank-screen-600nw-2469487437.jpg",
                @"D:\GitHub\project.Net\Project.NET\Project.NET\Resources\cinema-hall-white-blank-screen-600nw-2469487437.jpg",
                @"D:\GitHub\project.Net\Project.NET\Project.NET\Resources\cinema-hall-white-blank-screen-600nw-2469487437.jpg",
                @"D:\GitHub\project.Net\Project.NET\Project.NET\Resources\cinema-hall-white-blank-screen-600nw-2469487437.jpg",
                @"D:\GitHub\project.Net\Project.NET\Project.NET\Resources\cinema-hall-white-blank-screen-600nw-2469487437.jpg",
                @"D:\GitHub\project.Net\Project.NET\Project.NET\Resources\cinema-hall-white-blank-screen-600nw-2469487437.jpg",
                @"D:\GitHub\project.Net\Project.NET\Project.NET\Resources\cinema-hall-white-blank-screen-600nw-2469487437.jpg",
                @"D:\GitHub\project.Net\Project.NET\Project.NET\Resources\cinema-hall-white-blank-screen-600nw-2469487437.jpg"
            };

            foreach (string path in imagePaths)
            {
                PictureBox pic = new PictureBox
                {
                    ImageLocation = path,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Width = 150,
                    Height = 200,
                    Margin = new Padding(10) // Tạo khoảng cách giữa các ảnh
                };
                flowLayoutPanelMovies.Controls.Add(pic); // Thêm vào FlowLayoutPanel
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
