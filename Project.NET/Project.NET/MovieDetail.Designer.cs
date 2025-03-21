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
            txtRatedCnt = new TextBox();
            txtGerneCnt = new TextBox();
            txtLanguageCnt = new TextBox();
            txtDirectorCnt = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)PosterFrame).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CoverFrame).BeginInit();
            SuspendLayout();
            // 
            // PosterFrame
            // 
            PosterFrame.Location = new Point(11, 101);
            PosterFrame.Name = "PosterFrame";
            PosterFrame.Size = new Size(130, 171);
            PosterFrame.SizeMode = PictureBoxSizeMode.StretchImage;
            PosterFrame.TabIndex = 1;
            PosterFrame.TabStop = false;
            // 
            // CoverFrame
            // 
            CoverFrame.Location = new Point(-3, 0);
            CoverFrame.Name = "CoverFrame";
            CoverFrame.Size = new Size(566, 179);
            CoverFrame.SizeMode = PictureBoxSizeMode.StretchImage;
            CoverFrame.TabIndex = 2;
            CoverFrame.TabStop = false;
            // 
            // txtDecrip
            // 
            txtDecrip.Location = new Point(11, 293);
            txtDecrip.Multiline = true;
            txtDecrip.Name = "txtDecrip";
            txtDecrip.ReadOnly = true;
            txtDecrip.Size = new Size(545, 108);
            txtDecrip.TabIndex = 3;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = SystemColors.Menu;
            txtTitle.Location = new Point(157, 195);
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
            btnBooking.Click += btnBooking_Click_1;
            // 
            // txtDate
            // 
            txtDate.BackColor = SystemColors.Menu;
            txtDate.Location = new Point(157, 245);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(77, 27);
            txtDate.TabIndex = 6;
            // 
            // txtTimeshow
            // 
            txtTimeshow.BackColor = SystemColors.Menu;
            txtTimeshow.Location = new Point(283, 245);
            txtTimeshow.Name = "txtTimeshow";
            txtTimeshow.Size = new Size(77, 27);
            txtTimeshow.TabIndex = 7;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(11, 420);
            label1.Name = "label1";
            label1.Size = new Size(63, 28);
            label1.TabIndex = 16;
            label1.Text = "Rated";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(11, 468);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 18;
            label3.Text = "Genre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 513);
            label2.Name = "label2";
            label2.Size = new Size(83, 28);
            label2.TabIndex = 19;
            label2.Text = "Director";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 557);
            label4.Name = "label4";
            label4.Size = new Size(97, 28);
            label4.TabIndex = 20;
            label4.Text = "Language";
            // 
            // MovieDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 675);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtDirectorCnt);
            Controls.Add(txtLanguageCnt);
            Controls.Add(txtGerneCnt);
            Controls.Add(txtRatedCnt);
            Controls.Add(txtTimeshow);
            Controls.Add(txtDate);
            Controls.Add(btnBooking);
            Controls.Add(txtTitle);
            Controls.Add(txtDecrip);
            Controls.Add(PosterFrame);
            Controls.Add(CoverFrame);
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
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}