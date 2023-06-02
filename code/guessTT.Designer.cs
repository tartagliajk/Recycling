namespace recycling
{
    partial class guessTT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guessTT));
            this.plasticPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.glassPic = new System.Windows.Forms.PictureBox();
            this.cardboardPic = new System.Windows.Forms.PictureBox();
            this.returnSign = new System.Windows.Forms.Button();
            this.plasticB = new System.Windows.Forms.RadioButton();
            this.glassB = new System.Windows.Forms.RadioButton();
            this.cardboardB = new System.Windows.Forms.RadioButton();
            this.Submit = new System.Windows.Forms.Button();
            this.guessingPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.plasticPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glassPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardboardPic)).BeginInit();
            this.guessingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // plasticPic
            // 
            this.plasticPic.Image = ((System.Drawing.Image)(resources.GetObject("plasticPic.Image")));
            this.plasticPic.Location = new System.Drawing.Point(108, 13);
            this.plasticPic.Name = "plasticPic";
            this.plasticPic.Size = new System.Drawing.Size(444, 397);
            this.plasticPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.plasticPic.TabIndex = 0;
            this.plasticPic.TabStop = false;
            this.plasticPic.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Knicknack", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(404, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 57);
            this.label1.TabIndex = 8;
            this.label1.Text = "Guess The Trash";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // glassPic
            // 
            this.glassPic.Image = ((System.Drawing.Image)(resources.GetObject("glassPic.Image")));
            this.glassPic.Location = new System.Drawing.Point(108, 13);
            this.glassPic.Name = "glassPic";
            this.glassPic.Size = new System.Drawing.Size(444, 397);
            this.glassPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.glassPic.TabIndex = 9;
            this.glassPic.TabStop = false;
            this.glassPic.Visible = false;
            // 
            // cardboardPic
            // 
            this.cardboardPic.Image = ((System.Drawing.Image)(resources.GetObject("cardboardPic.Image")));
            this.cardboardPic.Location = new System.Drawing.Point(108, 13);
            this.cardboardPic.Name = "cardboardPic";
            this.cardboardPic.Size = new System.Drawing.Size(444, 397);
            this.cardboardPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardboardPic.TabIndex = 10;
            this.cardboardPic.TabStop = false;
            // 
            // returnSign
            // 
            this.returnSign.BackColor = System.Drawing.Color.FloralWhite;
            this.returnSign.Font = new System.Drawing.Font("Knicknack", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.returnSign.ForeColor = System.Drawing.SystemColors.ControlText;
            this.returnSign.Location = new System.Drawing.Point(12, 664);
            this.returnSign.Name = "returnSign";
            this.returnSign.Size = new System.Drawing.Size(77, 43);
            this.returnSign.TabIndex = 11;
            this.returnSign.Text = "<--";
            this.returnSign.UseVisualStyleBackColor = false;
            this.returnSign.Click += new System.EventHandler(this.returnSign_Click);
            // 
            // plasticB
            // 
            this.plasticB.AutoSize = true;
            this.plasticB.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plasticB.Location = new System.Drawing.Point(83, 435);
            this.plasticB.Name = "plasticB";
            this.plasticB.Size = new System.Drawing.Size(106, 30);
            this.plasticB.TabIndex = 12;
            this.plasticB.TabStop = true;
            this.plasticB.Text = "Plastic";
            this.plasticB.UseVisualStyleBackColor = true;
            // 
            // glassB
            // 
            this.glassB.AutoSize = true;
            this.glassB.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.glassB.Location = new System.Drawing.Point(280, 435);
            this.glassB.Name = "glassB";
            this.glassB.Size = new System.Drawing.Size(93, 30);
            this.glassB.TabIndex = 13;
            this.glassB.TabStop = true;
            this.glassB.Text = "Glass";
            this.glassB.UseVisualStyleBackColor = true;
            // 
            // cardboardB
            // 
            this.cardboardB.AutoSize = true;
            this.cardboardB.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cardboardB.Location = new System.Drawing.Point(437, 435);
            this.cardboardB.Name = "cardboardB";
            this.cardboardB.Size = new System.Drawing.Size(152, 30);
            this.cardboardB.TabIndex = 14;
            this.cardboardB.TabStop = true;
            this.cardboardB.Text = "Cardboard";
            this.cardboardB.UseVisualStyleBackColor = true;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.FloralWhite;
            this.Submit.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Submit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Submit.Location = new System.Drawing.Point(271, 509);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(112, 34);
            this.Submit.TabIndex = 15;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // guessingPanel
            // 
            this.guessingPanel.Controls.Add(this.Submit);
            this.guessingPanel.Controls.Add(this.cardboardB);
            this.guessingPanel.Controls.Add(this.glassB);
            this.guessingPanel.Controls.Add(this.plasticB);
            this.guessingPanel.Controls.Add(this.cardboardPic);
            this.guessingPanel.Controls.Add(this.glassPic);
            this.guessingPanel.Controls.Add(this.plasticPic);
            this.guessingPanel.Location = new System.Drawing.Point(263, 100);
            this.guessingPanel.Name = "guessingPanel";
            this.guessingPanel.Size = new System.Drawing.Size(650, 564);
            this.guessingPanel.TabIndex = 16;
            // 
            // guessTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1194, 719);
            this.Controls.Add(this.guessingPanel);
            this.Controls.Add(this.returnSign);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "guessTT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.plasticPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glassPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardboardPic)).EndInit();
            this.guessingPanel.ResumeLayout(false);
            this.guessingPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox plasticPic;
        private Label label1;
        private PictureBox glassPic;
        private PictureBox cardboardPic;
        private Button returnSign;
        private RadioButton plasticB;
        private RadioButton glassB;
        private RadioButton cardboardB;
        private Button Submit;
        private Panel guessingPanel;
    }
}