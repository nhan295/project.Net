using System;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.Data.SqlClient;
using System.Data;


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


        private void btnChange_Click(object sender, EventArgs e)
        {
            int userId = clsSession.CusId;
            string currentPassword = txtCurrent.Text;
            string newPassword = txtNew.Text;
            string confirmPassword = txtConfirm.Text;

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu mới không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                clsConnectDB.OpenConnection();
                string query = "SELECT * FROM Customer WHERE cus_id = @UserId AND cus_password = @CurrentPassword";
                SqlCommand com = new SqlCommand(query, clsConnectDB.conn);

                com.Parameters.AddWithValue("@UserId", userId);
                com.Parameters.AddWithValue("@CurrentPassword", currentPassword);

                SqlDataReader reader = com.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Close(); // Đóng reader trước khi thực thi lệnh khác

                    // Gọi stored procedure và xử lý kết quả trả về
                    SqlCommand cmd = new SqlCommand("ChangeUserPassword", clsConnectDB.conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@new_pwd", newPassword);

                    // Đọc kết quả trả về từ stored procedure
                    SqlDataReader resultReader = cmd.ExecuteReader();

                    if (resultReader.Read())
                    {
                        int success = resultReader.GetInt32(0); // Đọc giá trị Success

                        if (success == 1)
                        {
                            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Không thể đổi mật khẩu!", "Lỗi");
                        }
                    }

                    resultReader.Close();
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Mật khẩu hiện tại không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
            }
            finally
            {
                clsConnectDB.CloseConnection();
            }
        }

        private void peye1_Click(object sender, EventArgs e)
        {
            if (txtCurrent.PasswordChar == '\0')
            {
                phide1.BringToFront();
                (txtCurrent.PasswordChar) = '*';
            }
        }

        private void phide1_Click(object sender, EventArgs e)
        {
            if (txtCurrent.PasswordChar == '*')
            {
                peye1.BringToFront();
                txtCurrent.PasswordChar = '\0';
            }
        }

        private void peye2_Click(object sender, EventArgs e)
        {
            if (txtNew.PasswordChar == '\0')
            {
                phide2.BringToFront();
                (txtNew.PasswordChar) = '*';
            }
        }

        private void phide2_Click(object sender, EventArgs e)
        {
            if (txtNew.PasswordChar == '*')
            {
                peye2.BringToFront();
                txtNew.PasswordChar = '\0';
            }
        }

        private void peye3_Click(object sender, EventArgs e)
        {
            if (txtConfirm.PasswordChar == '\0')
            {
                phide3.BringToFront();
                (txtConfirm.PasswordChar) = '*';
            }
        }

        private void phide3_Click(object sender, EventArgs e)
        {
            if (txtConfirm.PasswordChar == '*')
            {
                peye3.BringToFront();
                txtConfirm.PasswordChar = '\0';
            }
        }
    }
}
