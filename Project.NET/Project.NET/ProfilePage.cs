using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Project.NET;

namespace ProfilePageApp
{
    public partial class ProfilePage : Form
    {
        private int cusId = clsSession.CusId;

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
                try
                {
                    clsConnectDB.OpenConnection();
                    SqlCommand com = new SqlCommand("delete from Customer where cus_id=@cusId", clsConnectDB.conn);

                    SqlParameter p = new SqlParameter("@cusId", SqlDbType.Int);
                    p.Value = cusId;
                    com.Parameters.Add(p);

                    int rowsAffected = com.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        clsSession.CusId = 0;
                        MessageBox.Show("Account deleted!", "Delete Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        Application.Restart();
                    }
                } 
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {
            try
            {
                clsConnectDB.OpenConnection();
                SqlCommand com = new SqlCommand("select cus_name, cus_phone, cus_email, cus_address, cus_birthday from Customer where cus_id=@cusId", clsConnectDB.conn);
                SqlParameter p = new SqlParameter("@cusId", SqlDbType.Int);
                p.Value = cusId;
                com.Parameters.Add(p);

                SqlDataReader reader = com.ExecuteReader();
                if(reader.HasRows)
                {
                    if(reader.Read())
                    {
                        txtName.Text = reader.GetString(0);
                        txtPhone.Text = reader.GetString(1);
                        txtGmail.Text = reader.GetString(2);
                        txtCity.Text = reader.GetString(3);

                        if(!reader.IsDBNull(4))
                        {
                            dtpBirthday.Value = reader.GetDateTime(4);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Load data: " + ex, "Failed" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
