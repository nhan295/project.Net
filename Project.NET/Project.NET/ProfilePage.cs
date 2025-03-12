using System;
using System.Windows.Forms;

namespace ProfilePageApp
{
    public partial class ProfilePage : Form
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Profile updated successfully!", "Update Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete your account?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Account deleted!", "Delete Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblCity_Click(object sender, EventArgs e)
        {

        }

        private void lblBirthday_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
