using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Project.NET
{
    public partial class Register_form : Form
    {
        public Register_form()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void phide_Click(object sender, EventArgs e)
        {
            if (txtRegpass.PasswordChar == '*')
            {
                peye.BringToFront();
                txtRegpass.PasswordChar = '\0';
            }
        }

        private void peye_Click(object sender, EventArgs e)
        {
            if (txtRegpass.PasswordChar == '\0')
            {
                phide.BringToFront();
                txtRegpass.PasswordChar = '*';
            }
        }

        private void peye1_Click(object sender, EventArgs e)
        {
            if (txtConfirmpass.PasswordChar == '\0')
            {
                phide1.BringToFront();
                txtConfirmpass.PasswordChar = '*';
            }
        }

        private void phide1_Click(object sender, EventArgs e)
        {
            if (txtConfirmpass.PasswordChar == '*')
            {
                peye1.BringToFront();
                txtConfirmpass.PasswordChar = '\0';
            }
        }

        private void Register_form_Load(object sender, EventArgs e)
        {

        }

        private bool ValidateRegisterForm(string name, string phoneNumber, string email, string address, string password, string confirmPassword)
        {
            string errors = "";

            // Validate cho tên
            if (string.IsNullOrWhiteSpace(name)) errors += "Vui lòng nhập tên.\n";

            // Validate cho số điện thoại
            if (string.IsNullOrWhiteSpace(phoneNumber)) errors += "Vui lòng nhập số điện thoại.\n";
            else if (!Regex.IsMatch(phoneNumber, @"^0\d{9,10}$")) { errors += "Vui lòng nhập đúng định dạng số điện thoại.\n"; }

            // Validate cho email
            if (string.IsNullOrWhiteSpace(email)) errors += "Vui lòng nhập email.\n";
            else if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) { errors += "Vui lòng nhập đúng định dạng email.\n"; }

            // Validate cho address
            if (string.IsNullOrWhiteSpace(address)) errors += "Vui lòng chọn địa chỉ.\n";

            // Validate cho password va confirmPassword
            if (string.IsNullOrWhiteSpace(password)) errors += "Vui lòng nhập mật khẩu.\n";
            else if (password.Length < 6) { errors += "Mật khẩu cần ít nhất 6 kí tự.\n"; }

            if (string.IsNullOrWhiteSpace(confirmPassword)) errors += "Vui lòng xác nhận mật khẩu.\n";
            else if (password != confirmPassword) { errors += "Mật khẩu không khớp.\n"; }

            // Hiển thị lỗi
            if (!string.IsNullOrEmpty(errors))
            {
                MessageBox.Show(errors, "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            } else
            {
                return true;
            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtRegname.Text;
            string phoneNumber = txtPhone.Text;
            string email = txtEmail.Text;
            string address = cboAddress.SelectedItem?.ToString() ?? "";
            string password = txtRegpass.Text;
            string confirmPassword = txtConfirmpass.Text;

            bool checkRegister =ValidateRegisterForm(name, phoneNumber, email, address, password, confirmPassword);

            try 
            {
                if (checkRegister)
                {
                    clsConnectDB.OpenConnection();
                    SqlCommand com = new SqlCommand("if not exists (select 1 from Customer where cus_email=@email or cus_phone=@phoneNumber)" +
                                                    "begin " +
                                                        "insert into Customer(cus_name, cus_phone, cus_email, cus_address, cus_password) " +
                                                        "output inserted.cus_id " + //lây user id sau khi tạo
                                                        "values(@name, @phoneNumber, @email, @address, @password); " +
                                                    "end", clsConnectDB.conn);

                    SqlParameter p1 = new SqlParameter("@name", SqlDbType.NVarChar);
                    SqlParameter p2 = new SqlParameter("@phoneNumber", SqlDbType.NVarChar);
                    SqlParameter p3 = new SqlParameter("@email", SqlDbType.NVarChar);
                    SqlParameter p4 = new SqlParameter("@address", SqlDbType.NVarChar);
                    SqlParameter p5 = new SqlParameter("@password", SqlDbType.NVarChar);

                    p1.Value = name;
                    p2.Value = phoneNumber;
                    p3.Value = email;
                    p4.Value = address;
                    p5.Value = password;

                    com.Parameters.Add(p1);
                    com.Parameters.Add(p2);
                    com.Parameters.Add(p3);
                    com.Parameters.Add(p4);
                    com.Parameters.Add(p5);

                    object result = com.ExecuteScalar();
                    int userId = result != null ? Convert.ToInt32(result) : -1;

                    if (userId > 0)
                    {
                        MessageBox.Show("Đăng ký thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        HomePage home = new HomePage();
                        home.ShowDialog();
                        this.Close();
                        clsSession.CusId = userId;
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clsConnectDB.CloseConnection();
                    }
                }
            } 
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
