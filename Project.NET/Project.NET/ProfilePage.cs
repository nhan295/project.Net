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
            try
            {
                clsConnectDB.OpenConnection();
                SqlCommand com = new SqlCommand(
                    "update customer set cus_name=@cusName, cus_phone=@cusPhone, cus_email=@cusEmail, cus_address=@cusAddress, cus_birthday=@cusBirthday " +
                    "where cus_id=@cusId", clsConnectDB.conn);
                SqlParameter p1 = new SqlParameter("@cusName", SqlDbType.NVarChar);
                SqlParameter p2 = new SqlParameter("@cusPhone", SqlDbType.NVarChar);
                SqlParameter p3 = new SqlParameter("@cusEmail", SqlDbType.NVarChar);
                SqlParameter p4 = new SqlParameter("@cusAddress", SqlDbType.NVarChar);
                SqlParameter p5 = new SqlParameter("@cusBirthday", SqlDbType.Date);
                SqlParameter p6 = new SqlParameter("@cusId", SqlDbType.Int);

                p1.Value = txtName.Text;
                p2.Value = txtPhone.Text;
                p3.Value = txtGmail.Text;
                p4.Value = txtCity.Text;
                if (dtpBirthday.Value.Date < DateTime.Now.Date)
                    p5.Value = dtpBirthday.Value.Date;
                else
                {
                    MessageBox.Show("Please select a valid date of birth", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                p6.Value = cusId;

                com.Parameters.Add(p1);
                com.Parameters.Add(p2);
                com.Parameters.Add(p3);
                com.Parameters.Add(p4);
                com.Parameters.Add(p5);
                com.Parameters.Add(p6);

                int rowsAffected = com.ExecuteNonQuery();
                clsConnectDB.CloseConnection();

                if(rowsAffected > 0)
                {
                    MessageBox.Show("Profile updated successfully!", "Update Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
                    clsConnectDB.CloseConnection();

                    if (rowsAffected > 0)
                    {
                        clsSession.CusId = 0;
                        MessageBox.Show("Account deleted!", "Delete Account", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Owner?.Hide();
                        this.Owner?.Close();
                        this.Hide();
                        this.Close();
                        Login_form login = new Login_form();
                        login.ShowDialog();
                        Application.Exit();
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
                clsConnectDB.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Load data: " + ex, "Failed" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
