namespace ProfilePageApp
{
    partial class ProfilePage
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblAccount;
        private Label lblGmail;
        private Label lblMoreInfo;
        private Label lblName;
        private Label lblBirthday;
        private Label lblGender;
        private Label lblTheater;
        private Label lblContact;
        private Label lblPhone;
        private Label lblCity;
        private Label lblDistrict;
        private TextBox txtGmail;
        private TextBox txtName;
        private DateTimePicker dtpBirthday;
        private ComboBox cbGender;
        private ComboBox cbTheater;
        private TextBox txtPhone;
        private TextBox txtCity;
        private TextBox txtDistrict;
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
            this.lblTitle = new Label();
            this.lblAccount = new Label();
            this.lblGmail = new Label();
            this.lblMoreInfo = new Label();
            this.lblName = new Label();
            this.lblBirthday = new Label();
            this.lblGender = new Label();
            this.lblTheater = new Label();
            this.lblContact = new Label();
            this.lblPhone = new Label();
            this.lblCity = new Label();
            this.lblDistrict = new Label();
            this.txtGmail = new TextBox();
            this.txtName = new TextBox();
            this.dtpBirthday = new DateTimePicker();
            this.cbGender = new ComboBox();
            this.cbTheater = new ComboBox();
            this.txtPhone = new TextBox();
            this.txtCity = new TextBox();
            this.txtDistrict = new TextBox();
            this.btnUpdateProfile = new Button();
            this.btnDeleteAccount = new Button();
            this.SuspendLayout();

            // Title
            this.lblTitle.Text = "Account Information";
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.AutoSize = true;

            // Account Info
            this.lblAccount.Text = "My Account is...";
            this.lblAccount.ForeColor = System.Drawing.Color.Gray;
            this.lblAccount.Location = new System.Drawing.Point(20, 60);
            this.lblAccount.AutoSize = true;

            // Gmail
            this.lblGmail.Text = "Gmail:";
            this.lblGmail.Location = new System.Drawing.Point(20, 90);
            this.txtGmail.Location = new System.Drawing.Point(150, 90);
            this.txtGmail.Width = 200;

            // More Information
            this.lblMoreInfo.Text = "More Information";
            this.lblMoreInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblMoreInfo.Location = new System.Drawing.Point(20, 130);
            this.lblMoreInfo.AutoSize = true;

            // Name
            this.lblName.Text = "Name:";
            this.lblName.Location = new System.Drawing.Point(20, 160);
            this.txtName.Location = new System.Drawing.Point(150, 160);
            this.txtName.Width = 200;

            // Birthday
            this.lblBirthday.Text = "Birthday:";
            this.lblBirthday.Location = new System.Drawing.Point(20, 190);
            this.dtpBirthday.Location = new System.Drawing.Point(150, 190);
            this.dtpBirthday.Format = DateTimePickerFormat.Short;

            // Gender
            this.lblGender.Text = "Gender:";
            this.lblGender.Location = new System.Drawing.Point(20, 220);
            this.cbGender.Location = new System.Drawing.Point(150, 220);
            this.cbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });

            // Prefer Theater
            this.lblTheater.Text = "Prefer Theater:";
            this.lblTheater.Location = new System.Drawing.Point(20, 250);
            this.cbTheater.Location = new System.Drawing.Point(150, 250);
            this.cbTheater.Items.AddRange(new object[] { "Cinema 1", "Cinema 2", "Cinema 3" });

            // Contact Information
            this.lblContact.Text = "Contact";
            this.lblContact.ForeColor = System.Drawing.Color.Gray;
            this.lblContact.Location = new System.Drawing.Point(20, 290);
            this.lblContact.AutoSize = true;

            // Mobile Phone
            this.lblPhone.Text = "Mobile Phone:";
            this.lblPhone.Location = new System.Drawing.Point(20, 320);
            this.txtPhone.Location = new System.Drawing.Point(150, 320);
            this.txtPhone.Width = 200;

            // City
            this.lblCity.Text = "City:";
            this.lblCity.Location = new System.Drawing.Point(20, 350);
            this.txtCity.Location = new System.Drawing.Point(150, 350);
            this.txtCity.Width = 200;

            // District
            this.lblDistrict.Text = "District:";
            this.lblDistrict.Location = new System.Drawing.Point(20, 380);
            this.txtDistrict.Location = new System.Drawing.Point(150, 380);
            this.txtDistrict.Width = 200;

            // Buttons
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.Location = new System.Drawing.Point(150, 420);
            this.btnUpdateProfile.Click += new EventHandler(this.btnUpdateProfile_Click);

            this.btnDeleteAccount.Text = "Delete Account";
            this.btnDeleteAccount.Location = new System.Drawing.Point(270, 420);
            this.btnDeleteAccount.Click += new EventHandler(this.btnDeleteAccount_Click);

            // Form Settings
            this.ClientSize = new System.Drawing.Size(400, 480);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblGmail);
            this.Controls.Add(this.txtGmail);
            this.Controls.Add(this.lblMoreInfo);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.lblTheater);
            this.Controls.Add(this.cbTheater);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblDistrict);
            this.Controls.Add(this.txtDistrict);
            this.Controls.Add(this.btnUpdateProfile);
            this.Controls.Add(this.btnDeleteAccount);
            this.Text = "Profile Page";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
