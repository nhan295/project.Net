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
                    cmd.Parameters.AddWithValue("@cus_id", userId);
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
    }
}
