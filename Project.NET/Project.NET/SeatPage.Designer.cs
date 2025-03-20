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
            btnBook = new Button();
            Screen = new PictureBox();
            panelSeats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Screen).BeginInit();
            SuspendLayout();
            // 
            // panelSeats
            // 
            panelSeats.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelSeats.Controls.Add(btnBook);
            panelSeats.Location = new Point(108, 120);
            panelSeats.Name = "panelSeats";
            panelSeats.Size = new Size(600, 300);
            panelSeats.TabIndex = 0;
            // 
            // btnBook
            // 
            btnBook.Location = new Point(28, 32);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(75, 23);
            btnBook.TabIndex = 0;
            btnBook.Text = "button1";
            btnBook.UseVisualStyleBackColor = true;
            // 
            // Screen
            // 
            Screen.Location = new Point(108, 21);
            Screen.Name = "Screen";
            Screen.Size = new Size(600, 80);
            Screen.TabIndex = 1;
            Screen.TabStop = false;
            // 
            // SeatPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Screen);
            Controls.Add(panelSeats);
            Name = "SeatPage";
            Text = "SeatPage";
            panelSeats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Screen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSeats;
        private Button btnBook;
        private PictureBox Screen;
    }
}