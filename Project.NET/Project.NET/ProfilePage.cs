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
    }
}
