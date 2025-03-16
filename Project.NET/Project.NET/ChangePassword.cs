using System;
using System.Windows.Forms;
using System.Drawing;

namespace Project.NET
{
    public partial class ChangePassword : Form
    {
        private bool isCurrentVisible = false;
        private bool isNewVisible = false;
        private bool isConfirmVisible = false;


        public ChangePassword()
        {
            InitializeComponent();
        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblCurrent_Click(object sender, EventArgs e)
        {

        }

        private void picCurrent_Click(object sender, EventArgs e)
        {
            isCurrentVisible = !isCurrentVisible;
            txtCurrent.PasswordChar = isCurrentVisible ? '\0' : '*';
            picCurrent.Image = Image.FromFile(isCurrentVisible
                ? @"D:\GitHub\project.Net\Project.NET\Project.NET\Resources\eye.png"
                : @"D:\GitHub\project.Net\Project.NET\Project.NET\Resources\hidden.png");
        }

        private void picNew_Click(object sender, EventArgs e)
        {
            isNewVisible = !isNewVisible;
            txtNew.PasswordChar = isNewVisible ? '\0' : '*';
            picNew.Image = Image.FromFile(isNewVisible
                ? @"D:\GitHub\project.Net\Project.NET\Project.NET\Resources\eye.png"
                : @"D:\GitHub\project.Net\Project.NET\Project.NET\Resources\hidden.png");
        }

        private void picConfirm_Click(object sender, EventArgs e)
        {
            isConfirmVisible = !isConfirmVisible;
            txtConfirm.PasswordChar = isConfirmVisible ? '\0' : '*';
            picConfirm.Image = Image.FromFile(isConfirmVisible
                ? @"D:\GitHub\project.Net\Project.NET\Project.NET\Resources\eye.png"
                : @"D:\GitHub\project.Net\Project.NET\Project.NET\Resources\hidden.png");
        }

    }
}
