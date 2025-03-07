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
                SqlCommand com = new SqlCommand("select * from Customer where cus_email=@cus_email and cus_password=@cus_password", clsConnectDB.conn);

                SqlParameter p1 = new SqlParameter("@cus_email", SqlDbType.NVarChar);
                p1.Value = txtEmail.Text;
                SqlParameter p2 = new SqlParameter("@cus_password", SqlDbType.NVarChar);
                p2.Value = txtPass.Text;

                com.Parameters.Add(p1);
                com.Parameters.Add(p2);

                SqlDataReader reader = com.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Dang nhap thanh cong", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.Hide();

                } else
                {
                    MessageBox.Show("Dang nhap that bai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
