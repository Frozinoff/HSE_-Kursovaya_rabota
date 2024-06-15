namespace CityAirport
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авиакомпанииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.самолетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пассажирыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.местаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рейсыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бронированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.бронированиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(717, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.авиакомпанииToolStripMenuItem,
            this.самолетыToolStripMenuItem,
            this.пассажирыToolStripMenuItem,
            this.местаToolStripMenuItem,
            this.рейсыToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // авиакомпанииToolStripMenuItem
            // 
            this.авиакомпанииToolStripMenuItem.Name = "авиакомпанииToolStripMenuItem";
            this.авиакомпанииToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.авиакомпанииToolStripMenuItem.Text = "Авиакомпании";
            this.авиакомпанииToolStripMenuItem.Click += new System.EventHandler(this.авиакомпанииToolStripMenuItem_Click);
            // 
            // самолетыToolStripMenuItem
            // 
            this.самолетыToolStripMenuItem.Name = "самолетыToolStripMenuItem";
            this.самолетыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.самолетыToolStripMenuItem.Text = "Самолеты";
            this.самолетыToolStripMenuItem.Click += new System.EventHandler(this.самолетыToolStripMenuItem_Click);
            // 
            // пассажирыToolStripMenuItem
            // 
            this.пассажирыToolStripMenuItem.Name = "пассажирыToolStripMenuItem";
            this.пассажирыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.пассажирыToolStripMenuItem.Text = "Пассажиры";
            this.пассажирыToolStripMenuItem.Click += new System.EventHandler(this.пассажирыToolStripMenuItem_Click);
            // 
            // местаToolStripMenuItem
            // 
            this.местаToolStripMenuItem.Name = "местаToolStripMenuItem";
            this.местаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.местаToolStripMenuItem.Text = "Места";
            this.местаToolStripMenuItem.Click += new System.EventHandler(this.местаToolStripMenuItem_Click);
            // 
            // рейсыToolStripMenuItem
            // 
            this.рейсыToolStripMenuItem.Name = "рейсыToolStripMenuItem";
            this.рейсыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.рейсыToolStripMenuItem.Text = "Рейсы";
            this.рейсыToolStripMenuItem.Click += new System.EventHandler(this.рейсыToolStripMenuItem_Click);
            // 
            // бронированиеToolStripMenuItem
            // 
            this.бронированиеToolStripMenuItem.Name = "бронированиеToolStripMenuItem";
            this.бронированиеToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.бронированиеToolStripMenuItem.Text = "Бронирование";
            this.бронированиеToolStripMenuItem.Click += new System.EventHandler(this.бронированиеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 378);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Городской аэропорт";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авиакомпанииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem самолетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пассажирыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бронированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem местаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рейсыToolStripMenuItem;
    }
}

