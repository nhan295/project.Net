namespace Project.NET
{
    partial class MovieDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieDetail));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtDecrip = new TextBox();
            txtTitle = new TextBox();
            btnBooking = new Button();
            txtDate = new TextBox();
            txtTimeshow = new TextBox();
            txtRated = new TextBox();
            txtGenre = new TextBox();
            txtDicretor = new TextBox();
            txtLanguage = new TextBox();
            txtRatedCnt = new TextBox();
            txtGerneCnt = new TextBox();
            txtLanguageCnt = new TextBox();
            txtDirectorCnt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 101);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(130, 170);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(566, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txtDecrip
            // 
            txtDecrip.Location = new Point(12, 294);
            txtDecrip.Multiline = true;
            txtDecrip.Name = "txtDecrip";
            txtDecrip.ReadOnly = true;
            txtDecrip.Size = new Size(545, 108);
            txtDecrip.TabIndex = 3;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = SystemColors.Menu;
            txtTitle.Location = new Point(157, 194);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(203, 27);
            txtTitle.TabIndex = 4;
            // 
            // btnBooking
            // 
            btnBooking.BackColor = Color.DarkRed;
            btnBooking.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold);
            btnBooking.ForeColor = SystemColors.Window;
            btnBooking.Location = new Point(104, 600);
            btnBooking.Name = "btnBooking";
            btnBooking.Size = new Size(354, 63);
            btnBooking.TabIndex = 5;
            btnBooking.Text = "Book Now";
            btnBooking.UseVisualStyleBackColor = false;
            // 
            // txtDate
            // 
            txtDate.BackColor = SystemColors.Menu;
            txtDate.Location = new Point(157, 246);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(77, 27);
            txtDate.TabIndex = 6;
            // 
            // txtTimeshow
            // 
            txtTimeshow.BackColor = SystemColors.Menu;
            txtTimeshow.Location = new Point(283, 246);
            txtTimeshow.Name = "txtTimeshow";
            txtTimeshow.Size = new Size(77, 27);
            txtTimeshow.TabIndex = 7;
            // 
            // txtRated
            // 
            txtRated.Location = new Point(12, 420);
            txtRated.Name = "txtRated";
            txtRated.ReadOnly = true;
            txtRated.Size = new Size(91, 27);
            txtRated.TabIndex = 8;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(12, 468);
            txtGenre.Name = "txtGenre";
            txtGenre.ReadOnly = true;
            txtGenre.Size = new Size(91, 27);
            txtGenre.TabIndex = 9;
            // 
            // txtDicretor
            // 
            txtDicretor.Location = new Point(12, 513);
            txtDicretor.Name = "txtDicretor";
            txtDicretor.ReadOnly = true;
            txtDicretor.Size = new Size(91, 27);
            txtDicretor.TabIndex = 10;
            // 
            // txtLanguage
            // 
            txtLanguage.Location = new Point(12, 557);
            txtLanguage.Name = "txtLanguage";
            txtLanguage.ReadOnly = true;
            txtLanguage.Size = new Size(91, 27);
            txtLanguage.TabIndex = 11;
            // 
            // txtRatedCnt
            // 
            txtRatedCnt.Location = new Point(129, 420);
            txtRatedCnt.Name = "txtRatedCnt";
            txtRatedCnt.ReadOnly = true;
            txtRatedCnt.Size = new Size(406, 27);
            txtRatedCnt.TabIndex = 12;
            // 
            // txtGerneCnt
            // 
            txtGerneCnt.Location = new Point(129, 468);
            txtGerneCnt.Name = "txtGerneCnt";
            txtGerneCnt.ReadOnly = true;
            txtGerneCnt.Size = new Size(406, 27);
            txtGerneCnt.TabIndex = 13;
            // 
            // txtLanguageCnt
            // 
            txtLanguageCnt.Location = new Point(129, 557);
            txtLanguageCnt.Name = "txtLanguageCnt";
            txtLanguageCnt.ReadOnly = true;
            txtLanguageCnt.Size = new Size(406, 27);
            txtLanguageCnt.TabIndex = 14;
            // 
            // txtDirectorCnt
            // 
            txtDirectorCnt.Location = new Point(129, 513);
            txtDirectorCnt.Name = "txtDirectorCnt";
            txtDirectorCnt.ReadOnly = true;
            txtDirectorCnt.Size = new Size(406, 27);
            txtDirectorCnt.TabIndex = 15;
            // 
            // MovieDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 675);
            Controls.Add(txtDirectorCnt);
            Controls.Add(txtLanguageCnt);
            Controls.Add(txtGerneCnt);
            Controls.Add(txtRatedCnt);
            Controls.Add(txtLanguage);
            Controls.Add(txtDicretor);
            Controls.Add(txtGenre);
            Controls.Add(txtRated);
            Controls.Add(txtTimeshow);
            Controls.Add(txtDate);
            Controls.Add(btnBooking);
            Controls.Add(txtTitle);
            Controls.Add(txtDecrip);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "MovieDetail";
            Text = "MovieDetail";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox txtTitle;
        private TextBox txtDate;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox txtDecrip;
        private Button btnBooking;
        private TextBox txtTimeshow;
        private TextBox txtRated;
        private TextBox txtGenre;
        private TextBox txtDicretor;
        private TextBox txtLanguage;
        private TextBox txtRatedCnt;
        private TextBox txtGerneCnt;
        private TextBox txtLanguageCnt;
        private TextBox txtDirectorCnt;
    }
}