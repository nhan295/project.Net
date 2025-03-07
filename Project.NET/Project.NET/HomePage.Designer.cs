namespace Project.NET
{
    partial class HomePage
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            lichChieuToolStripMenuItem = new ToolStripMenuItem();
            abcToolStripMenuItem = new ToolStripMenuItem();
            panelBanner = new Panel();
            pictureBoxBanner = new PictureBox();
            flowLayoutPanelMovies = new FlowLayoutPanel();
            timer2 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            menuStrip1.SuspendLayout();
            panelBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBanner).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DarkGray;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(562, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lichChieuToolStripMenuItem, abcToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // lichChieuToolStripMenuItem
            // 
            lichChieuToolStripMenuItem.Name = "lichChieuToolStripMenuItem";
            lichChieuToolStripMenuItem.Size = new Size(159, 26);
            lichChieuToolStripMenuItem.Text = "Lich Chieu";
            // 
            // abcToolStripMenuItem
            // 
            abcToolStripMenuItem.Name = "abcToolStripMenuItem";
            abcToolStripMenuItem.Size = new Size(159, 26);
            abcToolStripMenuItem.Text = "Abc";
            // 
            // panelBanner
            // 
            panelBanner.Controls.Add(pictureBoxBanner);
            panelBanner.Location = new Point(26, 41);
            panelBanner.Name = "panelBanner";
            panelBanner.Size = new Size(512, 150);
            panelBanner.TabIndex = 1;
            // 
            // pictureBoxBanner
            // 
            pictureBoxBanner.Dock = DockStyle.Fill;
            pictureBoxBanner.Image = Properties.Resources.cinema_hall_white_blank_screen_600nw_2469487437;
            pictureBoxBanner.Location = new Point(0, 0);
            pictureBoxBanner.Name = "pictureBoxBanner";
            pictureBoxBanner.Size = new Size(512, 150);
            pictureBoxBanner.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBanner.TabIndex = 0;
            pictureBoxBanner.TabStop = false;
            // 
            // flowLayoutPanelMovies
            // 
            flowLayoutPanelMovies.AutoScroll = true;
            flowLayoutPanelMovies.Location = new Point(0, 244);
            flowLayoutPanelMovies.Name = "flowLayoutPanelMovies";
            flowLayoutPanelMovies.Size = new Size(562, 402);
            flowLayoutPanelMovies.TabIndex = 2;
            // 
            // timer2
            // 
            timer2.Interval = 3000;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 206);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 3;
            label1.Text = "Phim Sex Dang Chieu";
            label1.Click += label1_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 675);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanelMovies);
            Controls.Add(panelBanner);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "HomePage";
            Text = "HomePage";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelBanner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxBanner).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem lichChieuToolStripMenuItem;
        private ToolStripMenuItem abcToolStripMenuItem;
        private Panel panelBanner;
        private PictureBox pictureBoxBanner;
        private FlowLayoutPanel flowLayoutPanelMovies;
        private System.Windows.Forms.Timer timer2;
        private Label label1;
    }
}