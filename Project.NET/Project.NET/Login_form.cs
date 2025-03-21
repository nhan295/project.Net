using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Project.NET
{
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_form_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register_form registerForm = new Register_form();
            registerForm.Show();
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                clsConnectDB.OpenConnection();
                SqlCommand com = new SqlCommand("select * from Customer where cus_email=@CusEmail and cus_password=@CusPassword", clsConnectDB.conn);

                SqlParameter p1 = new SqlParameter("@CusEmail", SqlDbType.NVarChar);
                p1.Value = txtEmail.Text;
                SqlParameter p2 = new SqlParameter("@CusPassword", SqlDbType.NVarChar);
                p2.Value = txtPass.Text;

                com.Parameters.Add(p1);
                com.Parameters.Add(p2);

                SqlDataReader reader = com.ExecuteReader();
                if (reader.HasRows)
                {
                    // Luu id cua khach hang
                    if (reader.Read())
                    {
                        clsSession.CusId = reader.GetInt32(0);
                        clsSession.CusName = reader.GetString(1);

                        //MessageBox.Show("Customer ID: " + clsSession.CusName, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    //MessageBox.Show("Dang nhap thanh cong", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    HomePage home = new HomePage();
                    home.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Dang nhap that bai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clsConnectDB.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void peye_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '\0')
            {
                phide.BringToFront();
                txtPass.PasswordChar = '*';
            }
        }

        private void phide_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '*')
            {
                peye.BringToFront();
                txtPass.PasswordChar = '\0';
            }
        }
    }
}
