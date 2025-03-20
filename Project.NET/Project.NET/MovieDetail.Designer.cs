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
            PosterFrame = new PictureBox();
            CoverFrame = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)PosterFrame).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CoverFrame).BeginInit();
            SuspendLayout();
            // 
            // PosterFrame
            // 
            PosterFrame.Location = new Point(10, 76);
            PosterFrame.Margin = new Padding(3, 2, 3, 2);
            PosterFrame.Name = "PosterFrame";
            PosterFrame.Size = new Size(114, 128);
            PosterFrame.SizeMode = PictureBoxSizeMode.StretchImage;
            PosterFrame.TabIndex = 1;
            PosterFrame.TabStop = false;
            // 
            // CoverFrame
            // 
            CoverFrame.Location = new Point(-3, 0);
            CoverFrame.Margin = new Padding(3, 2, 3, 2);
            CoverFrame.Name = "CoverFrame";
            CoverFrame.Size = new Size(495, 134);
            CoverFrame.SizeMode = PictureBoxSizeMode.StretchImage;
            CoverFrame.TabIndex = 2;
            CoverFrame.TabStop = false;
            // 
            // txtDecrip
            // 
            txtDecrip.Location = new Point(10, 220);
            txtDecrip.Margin = new Padding(3, 2, 3, 2);
            txtDecrip.Multiline = true;
            txtDecrip.Name = "txtDecrip";
            txtDecrip.ReadOnly = true;
            txtDecrip.Size = new Size(477, 82);
            txtDecrip.TabIndex = 3;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = SystemColors.Menu;
            txtTitle.Location = new Point(137, 146);
            txtTitle.Margin = new Padding(3, 2, 3, 2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(178, 23);
            txtTitle.TabIndex = 4;
            // 
            // btnBooking
            // 
            btnBooking.BackColor = Color.DarkRed;
            btnBooking.Font = new Font("Segoe UI Variable Display", 14F, FontStyle.Bold);
            btnBooking.ForeColor = SystemColors.Window;
            btnBooking.Location = new Point(91, 450);
            btnBooking.Margin = new Padding(3, 2, 3, 2);
            btnBooking.Name = "btnBooking";
            btnBooking.Size = new Size(310, 47);
            btnBooking.TabIndex = 5;
            btnBooking.Text = "Book Now";
            btnBooking.UseVisualStyleBackColor = false;
            btnBooking.Click += btnBooking_Click_1;
            // 
            // txtDate
            // 
            txtDate.BackColor = SystemColors.Menu;
            txtDate.Location = new Point(137, 184);
            txtDate.Margin = new Padding(3, 2, 3, 2);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(68, 23);
            txtDate.TabIndex = 6;
            // 
            // txtTimeshow
            // 
            txtTimeshow.BackColor = SystemColors.Menu;
            txtTimeshow.Location = new Point(248, 184);
            txtTimeshow.Margin = new Padding(3, 2, 3, 2);
            txtTimeshow.Name = "txtTimeshow";
            txtTimeshow.Size = new Size(68, 23);
            txtTimeshow.TabIndex = 7;
            // 
            // txtRated
            // 
            txtRated.Location = new Point(10, 315);
            txtRated.Margin = new Padding(3, 2, 3, 2);
            txtRated.Name = "txtRated";
            txtRated.ReadOnly = true;
            txtRated.Size = new Size(80, 23);
            txtRated.TabIndex = 8;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(10, 351);
            txtGenre.Margin = new Padding(3, 2, 3, 2);
            txtGenre.Name = "txtGenre";
            txtGenre.ReadOnly = true;
            txtGenre.Size = new Size(80, 23);
            txtGenre.TabIndex = 9;
            // 
            // txtDicretor
            // 
            txtDicretor.Location = new Point(10, 385);
            txtDicretor.Margin = new Padding(3, 2, 3, 2);
            txtDicretor.Name = "txtDicretor";
            txtDicretor.ReadOnly = true;
            txtDicretor.Size = new Size(80, 23);
            txtDicretor.TabIndex = 10;
            // 
            // txtLanguage
            // 
            txtLanguage.Location = new Point(10, 418);
            txtLanguage.Margin = new Padding(3, 2, 3, 2);
            txtLanguage.Name = "txtLanguage";
            txtLanguage.ReadOnly = true;
            txtLanguage.Size = new Size(80, 23);
            txtLanguage.TabIndex = 11;
            // 
            // txtRatedCnt
            // 
            txtRatedCnt.Location = new Point(113, 315);
            txtRatedCnt.Margin = new Padding(3, 2, 3, 2);
            txtRatedCnt.Name = "txtRatedCnt";
            txtRatedCnt.ReadOnly = true;
            txtRatedCnt.Size = new Size(356, 23);
            txtRatedCnt.TabIndex = 12;
            // 
            // txtGerneCnt
            // 
            txtGerneCnt.Location = new Point(113, 351);
            txtGerneCnt.Margin = new Padding(3, 2, 3, 2);
            txtGerneCnt.Name = "txtGerneCnt";
            txtGerneCnt.ReadOnly = true;
            txtGerneCnt.Size = new Size(356, 23);
            txtGerneCnt.TabIndex = 13;
            // 
            // txtLanguageCnt
            // 
            txtLanguageCnt.Location = new Point(113, 418);
            txtLanguageCnt.Margin = new Padding(3, 2, 3, 2);
            txtLanguageCnt.Name = "txtLanguageCnt";
            txtLanguageCnt.ReadOnly = true;
            txtLanguageCnt.Size = new Size(356, 23);
            txtLanguageCnt.TabIndex = 14;
            // 
            // txtDirectorCnt
            // 
            txtDirectorCnt.Location = new Point(113, 385);
            txtDirectorCnt.Margin = new Padding(3, 2, 3, 2);
            txtDirectorCnt.Name = "txtDirectorCnt";
            txtDirectorCnt.ReadOnly = true;
            txtDirectorCnt.Size = new Size(356, 23);
            txtDirectorCnt.TabIndex = 15;
            // 
            // MovieDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 506);
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
            Controls.Add(PosterFrame);
            Controls.Add(CoverFrame);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MovieDetail";
            Text = "MovieDetail";
            Load += MovieDetail_Load;
            ((System.ComponentModel.ISupportInitialize)PosterFrame).EndInit();
            ((System.ComponentModel.ISupportInitialize)CoverFrame).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox PosterFrame;
        private PictureBox CoverFrame;
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