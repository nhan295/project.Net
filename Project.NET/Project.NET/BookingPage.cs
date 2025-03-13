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
    public partial class BookingPage : Form
    {
        private Button selectedButton = null;

        public BookingPage()
        {
            InitializeComponent();
           
            UpdateDay();
            UpdateDate();
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
            List<Label> labbellist = new List<Label> { labDate, labDate1, labDate2, labDate3, labDate4, labDate5 };
            DateTime today = DateTime.Now;

            for (int i = 0; i < labbellist.Count; i++)
            {
                labbellist[i].Text = today.AddDays(i).ToString("dddd");
            }
        }


    }
}
