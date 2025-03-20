namespace Project.NET
{
    partial class SeatPage
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
            panelSeats = new Panel();
            Screen = new PictureBox();
            btnBook = new Button();
            ((System.ComponentModel.ISupportInitialize)Screen).BeginInit();
            SuspendLayout();
            // 
            // panelSeats
            // 
            panelSeats.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelSeats.Location = new Point(100, 122);
            panelSeats.Name = "panelSeats";
            panelSeats.Size = new Size(600, 251);
            panelSeats.TabIndex = 0;
            // 
            // Screen
            // 
            Screen.Image = Properties.Resources.screen;
            Screen.Location = new Point(100, 21);
            Screen.Name = "Screen";
            Screen.Size = new Size(600, 80);
            Screen.SizeMode = PictureBoxSizeMode.CenterImage;
            Screen.TabIndex = 1;
            Screen.TabStop = false;
            Screen.Click += Screen_Click;
            // 
            // btnBook
            // 
            btnBook.Location = new Point(150, 400);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(500, 43);
            btnBook.TabIndex = 2;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // SeatPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBook);
            Controls.Add(Screen);
            Controls.Add(panelSeats);
            Name = "SeatPage";
            Text = "SeatPage";
            ((System.ComponentModel.ISupportInitialize)Screen).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btnBook;
        private Panel panelSeats;
        private PictureBox Screen;
       
    }
}