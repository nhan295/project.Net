namespace Project.NET
{
    partial class ChangePassword
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblCurrent;
        private Label lblNew;
        private Label lblConfirm;
        private TextBox txtCurrent;
        private TextBox txtNew;
        private TextBox txtConfirm;
        private PictureBox picCurrent;
        private PictureBox picNew;
        private PictureBox picConfirm;
        private Button btnChange;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            lblTitle = new Label();
            lblCurrent = new Label();
            lblNew = new Label();
            lblConfirm = new Label();
            txtCurrent = new TextBox();
            txtNew = new TextBox();
            txtConfirm = new TextBox();
            picCurrent = new PictureBox();
            picNew = new PictureBox();
            picConfirm = new PictureBox();
            btnChange = new Button();
            ((System.ComponentModel.ISupportInitialize)picCurrent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNew).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picConfirm).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(12, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(221, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Change Password";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblCurrent
            // 
            lblCurrent.AutoSize = true;
            lblCurrent.Location = new Point(12, 60);
            lblCurrent.Name = "lblCurrent";
            lblCurrent.Size = new Size(125, 20);
            lblCurrent.TabIndex = 1;
            lblCurrent.Text = "Current Password:";
            lblCurrent.Click += lblCurrent_Click;
            // 
            // lblNew
            // 
            lblNew.AutoSize = true;
            lblNew.Location = new Point(12, 100);
            lblNew.Name = "lblNew";
            lblNew.Size = new Size(107, 20);
            lblNew.TabIndex = 4;
            lblNew.Text = "New Password:";
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Location = new Point(12, 140);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(130, 20);
            lblConfirm.TabIndex = 7;
            lblConfirm.Text = "Confirm Password:";
            // 
            // txtCurrent
            // 
            txtCurrent.Location = new Point(150, 60);
            txtCurrent.Name = "txtCurrent";
            txtCurrent.PasswordChar = '*';
            txtCurrent.Size = new Size(378, 27);
            txtCurrent.TabIndex = 2;
            // 
            // txtNew
            // 
            txtNew.Location = new Point(150, 100);
            txtNew.Name = "txtNew";
            txtNew.PasswordChar = '*';
            txtNew.Size = new Size(378, 27);
            txtNew.TabIndex = 5;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(150, 137);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PasswordChar = '*';
            txtConfirm.Size = new Size(378, 27);
            txtConfirm.TabIndex = 8;
            txtConfirm.TextChanged += txtConfirm_TextChanged;
            // 
            // picCurrent
            // 
            picCurrent.Image = (Image)resources.GetObject("picCurrent.Image");
            picCurrent.Location = new Point(534, 67);
            picCurrent.Name = "picCurrent";
            picCurrent.Size = new Size(20, 20);
            picCurrent.SizeMode = PictureBoxSizeMode.StretchImage;
            picCurrent.TabIndex = 3;
            picCurrent.TabStop = false;
            picCurrent.Click += picCurrent_Click;
            // 
            // picNew
            // 
            picNew.Image = (Image)resources.GetObject("picNew.Image");
            picNew.Location = new Point(534, 107);
            picNew.Name = "picNew";
            picNew.Size = new Size(20, 20);
            picNew.SizeMode = PictureBoxSizeMode.StretchImage;
            picNew.TabIndex = 6;
            picNew.TabStop = false;
            picNew.Click += picNew_Click;
            // 
            // picConfirm
            // 
            picConfirm.Image = (Image)resources.GetObject("picConfirm.Image");
            picConfirm.Location = new Point(534, 144);
            picConfirm.Name = "picConfirm";
            picConfirm.Size = new Size(20, 20);
            picConfirm.SizeMode = PictureBoxSizeMode.StretchImage;
            picConfirm.TabIndex = 9;
            picConfirm.TabStop = false;
            picConfirm.Click += picConfirm_Click;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(298, 195);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(230, 30);
            btnChange.TabIndex = 10;
            btnChange.Text = "Change Password";
            btnChange.Click += btnChange_Click;
            // 
            // ChangePassword
            // 
            ClientSize = new Size(596, 246);
            Controls.Add(lblTitle);
            Controls.Add(lblCurrent);
            Controls.Add(txtCurrent);
            Controls.Add(picCurrent);
            Controls.Add(lblNew);
            Controls.Add(txtNew);
            Controls.Add(picNew);
            Controls.Add(lblConfirm);
            Controls.Add(txtConfirm);
            Controls.Add(picConfirm);
            Controls.Add(btnChange);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Password";
            ((System.ComponentModel.ISupportInitialize)picCurrent).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNew).EndInit();
            ((System.ComponentModel.ISupportInitialize)picConfirm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
