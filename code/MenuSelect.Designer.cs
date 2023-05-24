namespace recycling
{
    partial class MenuSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuSelect));
            this.truckPic = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuWelcome = new System.Windows.Forms.Label();
            this.reading = new System.Windows.Forms.Button();
            this.Tof = new System.Windows.Forms.Button();
            this.game = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.truckPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // truckPic
            // 
            this.truckPic.Image = ((System.Drawing.Image)(resources.GetObject("truckPic.Image")));
            this.truckPic.Location = new System.Drawing.Point(12, 469);
            this.truckPic.Name = "truckPic";
            this.truckPic.Size = new System.Drawing.Size(306, 238);
            this.truckPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.truckPic.TabIndex = 12;
            this.truckPic.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Knicknack", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FloralWhite;
            this.label2.Location = new System.Drawing.Point(276, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 62);
            this.label2.TabIndex = 13;
            this.label2.Text = "Menu";
            // 
            // menuWelcome
            // 
            this.menuWelcome.AutoSize = true;
            this.menuWelcome.Font = new System.Drawing.Font("Knicknack", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuWelcome.ForeColor = System.Drawing.Color.FloralWhite;
            this.menuWelcome.Location = new System.Drawing.Point(276, 218);
            this.menuWelcome.Name = "menuWelcome";
            this.menuWelcome.Size = new System.Drawing.Size(136, 42);
            this.menuWelcome.TabIndex = 14;
            this.menuWelcome.Text = "Welcome";
            // 
            // reading
            // 
            this.reading.BackColor = System.Drawing.Color.FloralWhite;
            this.reading.Font = new System.Drawing.Font("Knicknack", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reading.Location = new System.Drawing.Point(276, 317);
            this.reading.Name = "reading";
            this.reading.Size = new System.Drawing.Size(180, 43);
            this.reading.TabIndex = 15;
            this.reading.Text = "Reading";
            this.reading.UseVisualStyleBackColor = false;
            this.reading.Click += new System.EventHandler(this.reading_Click);
            // 
            // Tof
            // 
            this.Tof.BackColor = System.Drawing.Color.FloralWhite;
            this.Tof.Font = new System.Drawing.Font("Knicknack", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tof.Location = new System.Drawing.Point(276, 381);
            this.Tof.Name = "Tof";
            this.Tof.Size = new System.Drawing.Size(180, 43);
            this.Tof.TabIndex = 16;
            this.Tof.Text = "True or False";
            this.Tof.UseVisualStyleBackColor = false;
            this.Tof.Click += new System.EventHandler(this.Tof_Click);
            // 
            // game
            // 
            this.game.BackColor = System.Drawing.Color.FloralWhite;
            this.game.Font = new System.Drawing.Font("Knicknack", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.game.Location = new System.Drawing.Point(276, 448);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(180, 43);
            this.game.TabIndex = 17;
            this.game.Text = "Game";
            this.game.UseVisualStyleBackColor = false;
            this.game.Click += new System.EventHandler(this.game_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(634, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 333);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // MenuSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1194, 719);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.game);
            this.Controls.Add(this.Tof);
            this.Controls.Add(this.reading);
            this.Controls.Add(this.menuWelcome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.truckPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuSelect";
            ((System.ComponentModel.ISupportInitialize)(this.truckPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox truckPic;
        private Label label2;
        private Label menuWelcome;
        private Button reading;
        private Button Tof;
        private Button game;
        private PictureBox pictureBox1;
    }
}