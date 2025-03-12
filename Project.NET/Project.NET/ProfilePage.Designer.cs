namespace ProfilePageApp
{
    partial class ProfilePage
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblGmail;
        private Label lblName;
        private Label lblBirthday;
        private Label lblPhone;
        private Label lblCity;
        private TextBox txtGmail;
        private TextBox txtName;
        private DateTimePicker dtpBirthday;
        private TextBox txtPhone;
        private TextBox txtCity;
        private Button btnUpdateProfile;
        private Button btnDeleteAccount;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblGmail = new Label();
            lblName = new Label();
            lblBirthday = new Label();
            lblPhone = new Label();
            lblCity = new Label();
            txtGmail = new TextBox();
            txtName = new TextBox();
            dtpBirthday = new DateTimePicker();
            txtPhone = new TextBox();
            txtCity = new TextBox();
            btnUpdateProfile = new Button();
            btnDeleteAccount = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(249, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Account Information";
            // 
            // lblGmail
            // 
            lblGmail.Location = new Point(20, 94);
            lblGmail.Name = "lblGmail";
            lblGmail.Size = new Size(100, 23);
            lblGmail.TabIndex = 2;
            lblGmail.Text = "Gmail:";
            // 
            // lblName
            // 
            lblName.Location = new Point(20, 171);
            lblName.Name = "lblName";
            lblName.Size = new Size(66, 23);
            lblName.TabIndex = 5;
            lblName.Text = "Name:";
            lblName.Click += lblName_Click;
            // 
            // lblBirthday
            // 
            lblBirthday.Location = new Point(20, 200);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(100, 23);
            lblBirthday.TabIndex = 7;
            lblBirthday.Text = "Birthday:";
            lblBirthday.Click += lblBirthday_Click;
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(20, 279);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(124, 23);
            lblPhone.TabIndex = 14;
            lblPhone.Text = "Mobile Phone:";
            lblPhone.Click += lblPhone_Click;
            // 
            // lblCity
            // 
            lblCity.Location = new Point(20, 325);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(100, 23);
            lblCity.TabIndex = 16;
            lblCity.Text = "Address";
            lblCity.Click += lblCity_Click;
            // 
            // txtGmail
            // 
            txtGmail.Location = new Point(150, 90);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(482, 27);
            txtGmail.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(150, 167);
            txtName.Name = "txtName";
            txtName.Size = new Size(482, 27);
            txtName.TabIndex = 6;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Format = DateTimePickerFormat.Short;
            dtpBirthday.Location = new Point(150, 200);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(200, 27);
            dtpBirthday.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(150, 275);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 27);
            txtPhone.TabIndex = 15;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(150, 321);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(482, 27);
            txtCity.TabIndex = 17;
            // 
            // btnUpdateProfile
            // 
            btnUpdateProfile.Location = new Point(476, 366);
            btnUpdateProfile.Name = "btnUpdateProfile";
            btnUpdateProfile.Size = new Size(75, 35);
            btnUpdateProfile.TabIndex = 20;
            btnUpdateProfile.Text = "Update Profile";
            btnUpdateProfile.Click += btnUpdateProfile_Click;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new Point(557, 366);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(75, 35);
            btnDeleteAccount.TabIndex = 21;
            btnDeleteAccount.Text = "Delete Account";
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkGray;
            textBox1.Location = new Point(20, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(612, 27);
            textBox1.TabIndex = 22;
            textBox1.Text = "My Account is...";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DarkGray;
            textBox2.Location = new Point(20, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(612, 27);
            textBox2.TabIndex = 23;
            textBox2.Text = "More information";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.DarkGray;
            textBox3.Location = new Point(20, 242);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(612, 27);
            textBox3.TabIndex = 24;
            textBox3.Text = "Contact";
            // 
            // ProfilePage
            // 
            BackColor = Color.White;
            ClientSize = new Size(658, 409);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblTitle);
            Controls.Add(lblGmail);
            Controls.Add(txtGmail);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblBirthday);
            Controls.Add(dtpBirthday);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(lblCity);
            Controls.Add(txtCity);
            Controls.Add(btnUpdateProfile);
            Controls.Add(btnDeleteAccount);
            Name = "ProfilePage";
            Text = "Profile Page";
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
