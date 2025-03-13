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
            lblUserName = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(289, 33);
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
            // 
            // lblBirthday
            // 
            lblBirthday.Location = new Point(20, 200);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(100, 23);
            lblBirthday.TabIndex = 7;
            lblBirthday.Text = "Birthday:";
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(20, 279);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(124, 23);
            lblPhone.TabIndex = 14;
            lblPhone.Text = "Mobile Phone:";
            // 
            // lblCity
            // 
            lblCity.Location = new Point(20, 325);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(100, 23);
            lblCity.TabIndex = 16;
            lblCity.Text = "Address";
            // 
            // txtGmail
            // 
            txtGmail.Location = new Point(150, 90);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(482, 31);
            txtGmail.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(150, 167);
            txtName.Name = "txtName";
            txtName.Size = new Size(482, 31);
            txtName.TabIndex = 6;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Format = DateTimePickerFormat.Short;
            dtpBirthday.Location = new Point(150, 200);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(200, 31);
            dtpBirthday.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(150, 275);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 31);
            txtPhone.TabIndex = 15;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(150, 321);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(482, 31);
            txtCity.TabIndex = 17;
            // 
            // btnUpdateProfile
            // 
            btnUpdateProfile.Location = new Point(414, 366);
            btnUpdateProfile.Name = "btnUpdateProfile";
            btnUpdateProfile.Size = new Size(137, 35);
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
            // lblUserName
            // 
            lblUserName.BackColor = Color.DarkGray;
            lblUserName.Location = new Point(20, 55);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(612, 20);
            lblUserName.TabIndex = 25;
            lblUserName.Text = "My account is...";
            // 
            // label2
            // 
            label2.BackColor = Color.DarkGray;
            label2.Location = new Point(20, 133);
            label2.Name = "label2";
            label2.Size = new Size(612, 20);
            label2.TabIndex = 26;
            label2.Text = "More information";
            // 
            // label3
            // 
            label3.BackColor = Color.DarkGray;
            label3.Location = new Point(20, 240);
            label3.Name = "label3";
            label3.Size = new Size(612, 20);
            label3.TabIndex = 27;
            label3.Text = "Contact";
            // 
            // ProfilePage
            // 
            BackColor = Color.White;
            ClientSize = new Size(658, 409);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblUserName);
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
            Load += ProfilePage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblUserName;
    }
}
