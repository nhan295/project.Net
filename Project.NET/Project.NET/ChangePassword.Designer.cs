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
            lblTitle = new Label();
            lblCurrent = new Label();
            lblNew = new Label();
            lblConfirm = new Label();
            txtCurrent = new TextBox();
            txtNew = new TextBox();
            txtConfirm = new TextBox();
            btnChange = new Button();
            peye1 = new PictureBox();
            phide1 = new PictureBox();
            peye2 = new PictureBox();
            phide2 = new PictureBox();
            peye3 = new PictureBox();
            phide3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)peye1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)phide1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)peye2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)phide2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)peye3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)phide3).BeginInit();
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
            // btnChange
            // 
            btnChange.Location = new Point(298, 195);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(230, 30);
            btnChange.TabIndex = 10;
            btnChange.Text = "Change Password";
            btnChange.Click += btnChange_Click;
            // 
            // peye1
            // 
            peye1.Image = Properties.Resources.eye;
            peye1.Location = new Point(501, 60);
            peye1.Name = "peye1";
            peye1.Size = new Size(27, 27);
            peye1.SizeMode = PictureBoxSizeMode.StretchImage;
            peye1.TabIndex = 11;
            peye1.TabStop = false;
            peye1.Click += peye1_Click;
            // 
            // phide1
            // 
            phide1.Image = Properties.Resources.hidden;
            phide1.Location = new Point(501, 60);
            phide1.Name = "phide1";
            phide1.Size = new Size(27, 27);
            phide1.SizeMode = PictureBoxSizeMode.StretchImage;
            phide1.TabIndex = 14;
            phide1.TabStop = false;
            phide1.Click += phide1_Click;
            // 
            // peye2
            // 
            peye2.Image = Properties.Resources.eye;
            peye2.Location = new Point(501, 100);
            peye2.Name = "peye2";
            peye2.Size = new Size(27, 27);
            peye2.SizeMode = PictureBoxSizeMode.StretchImage;
            peye2.TabIndex = 15;
            peye2.TabStop = false;
            peye2.Click += peye2_Click;
            // 
            // phide2
            // 
            phide2.Image = Properties.Resources.hidden;
            phide2.Location = new Point(501, 100);
            phide2.Name = "phide2";
            phide2.Size = new Size(27, 27);
            phide2.SizeMode = PictureBoxSizeMode.StretchImage;
            phide2.TabIndex = 16;
            phide2.TabStop = false;
            phide2.Click += phide2_Click;
            // 
            // peye3
            // 
            peye3.Image = Properties.Resources.eye;
            peye3.Location = new Point(501, 137);
            peye3.Name = "peye3";
            peye3.Size = new Size(27, 27);
            peye3.SizeMode = PictureBoxSizeMode.StretchImage;
            peye3.TabIndex = 17;
            peye3.TabStop = false;
            peye3.Click += peye3_Click;
            // 
            // phide3
            // 
            phide3.Image = Properties.Resources.hidden;
            phide3.Location = new Point(501, 137);
            phide3.Name = "phide3";
            phide3.Size = new Size(27, 27);
            phide3.SizeMode = PictureBoxSizeMode.StretchImage;
            phide3.TabIndex = 18;
            phide3.TabStop = false;
            phide3.Click += phide3_Click;
            // 
            // ChangePassword
            // 
            ClientSize = new Size(596, 246);
            Controls.Add(phide3);
            Controls.Add(peye3);
            Controls.Add(phide2);
            Controls.Add(peye2);
            Controls.Add(phide1);
            Controls.Add(peye1);
            Controls.Add(lblTitle);
            Controls.Add(lblCurrent);
            Controls.Add(txtCurrent);
            Controls.Add(lblNew);
            Controls.Add(txtNew);
            Controls.Add(lblConfirm);
            Controls.Add(txtConfirm);
            Controls.Add(btnChange);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Password";
            ((System.ComponentModel.ISupportInitialize)peye1).EndInit();
            ((System.ComponentModel.ISupportInitialize)phide1).EndInit();
            ((System.ComponentModel.ISupportInitialize)peye2).EndInit();
            ((System.ComponentModel.ISupportInitialize)phide2).EndInit();
            ((System.ComponentModel.ISupportInitialize)peye3).EndInit();
            ((System.ComponentModel.ISupportInitialize)phide3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private PictureBox peye1;
        private PictureBox phide1;
        private PictureBox peye2;
        private PictureBox phide2;
        private PictureBox peye3;
        private PictureBox phide3;
    }
}
