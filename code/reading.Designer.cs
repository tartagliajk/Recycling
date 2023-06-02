namespace recycling
{
    partial class reading
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
            this.readTexts = new System.Windows.Forms.Panel();
            this.readingTB = new System.Windows.Forms.Label();
            this.returnText = new System.Windows.Forms.Button();
            this.cardbordBut = new System.Windows.Forms.Button();
            this.glassBut = new System.Windows.Forms.Button();
            this.plasticBut = new System.Windows.Forms.Button();
            this.generalBut = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.readTexts.SuspendLayout();
            this.SuspendLayout();
            // 
            // readTexts
            // 
            this.readTexts.BackColor = System.Drawing.Color.Transparent;
            this.readTexts.Controls.Add(this.readingTB);
            this.readTexts.Controls.Add(this.returnText);
            this.readTexts.Controls.Add(this.cardbordBut);
            this.readTexts.Controls.Add(this.glassBut);
            this.readTexts.Controls.Add(this.plasticBut);
            this.readTexts.Controls.Add(this.generalBut);
            this.readTexts.Controls.Add(this.label5);
            this.readTexts.Location = new System.Drawing.Point(66, 32);
            this.readTexts.Name = "readTexts";
            this.readTexts.Size = new System.Drawing.Size(1058, 616);
            this.readTexts.TabIndex = 12;
            // 
            // readingTB
            // 
            this.readingTB.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.readingTB.ForeColor = System.Drawing.Color.FloralWhite;
            this.readingTB.Location = new System.Drawing.Point(94, 84);
            this.readingTB.Name = "readingTB";
            this.readingTB.Size = new System.Drawing.Size(876, 448);
            this.readingTB.TabIndex = 6;
            this.readingTB.Text = "Press one of the buttons to read a text!";
            // 
            // returnText
            // 
            this.returnText.BackColor = System.Drawing.Color.FloralWhite;
            this.returnText.Font = new System.Drawing.Font("Knicknack", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.returnText.Location = new System.Drawing.Point(14, 561);
            this.returnText.Name = "returnText";
            this.returnText.Size = new System.Drawing.Size(61, 34);
            this.returnText.TabIndex = 5;
            this.returnText.Text = "<--";
            this.returnText.UseVisualStyleBackColor = false;
            this.returnText.Click += new System.EventHandler(this.returnText_Click);
            // 
            // cardbordBut
            // 
            this.cardbordBut.BackColor = System.Drawing.Color.FloralWhite;
            this.cardbordBut.Font = new System.Drawing.Font("Knicknack", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cardbordBut.Location = new System.Drawing.Point(753, 549);
            this.cardbordBut.Name = "cardbordBut";
            this.cardbordBut.Size = new System.Drawing.Size(147, 41);
            this.cardbordBut.TabIndex = 4;
            this.cardbordBut.Text = "Cardbord";
            this.cardbordBut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cardbordBut.UseVisualStyleBackColor = false;
            this.cardbordBut.Click += new System.EventHandler(this.cardbordBut_Click);
            // 
            // glassBut
            // 
            this.glassBut.BackColor = System.Drawing.Color.FloralWhite;
            this.glassBut.Font = new System.Drawing.Font("Knicknack", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.glassBut.Location = new System.Drawing.Point(570, 549);
            this.glassBut.Name = "glassBut";
            this.glassBut.Size = new System.Drawing.Size(147, 41);
            this.glassBut.TabIndex = 3;
            this.glassBut.Text = "Glass";
            this.glassBut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.glassBut.UseVisualStyleBackColor = false;
            this.glassBut.Click += new System.EventHandler(this.glassBut_Click);
            // 
            // plasticBut
            // 
            this.plasticBut.BackColor = System.Drawing.Color.FloralWhite;
            this.plasticBut.Font = new System.Drawing.Font("Knicknack", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plasticBut.Location = new System.Drawing.Point(397, 549);
            this.plasticBut.Name = "plasticBut";
            this.plasticBut.Size = new System.Drawing.Size(147, 41);
            this.plasticBut.TabIndex = 2;
            this.plasticBut.Text = "Plastic";
            this.plasticBut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.plasticBut.UseVisualStyleBackColor = false;
            this.plasticBut.Click += new System.EventHandler(this.plasticBut_Click);
            // 
            // generalBut
            // 
            this.generalBut.BackColor = System.Drawing.Color.FloralWhite;
            this.generalBut.Font = new System.Drawing.Font("Knicknack", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generalBut.Location = new System.Drawing.Point(233, 549);
            this.generalBut.Name = "generalBut";
            this.generalBut.Size = new System.Drawing.Size(147, 41);
            this.generalBut.TabIndex = 1;
            this.generalBut.Text = "General";
            this.generalBut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generalBut.UseVisualStyleBackColor = false;
            this.generalBut.Click += new System.EventHandler(this.generalBut_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Knicknack", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FloralWhite;
            this.label5.Location = new System.Drawing.Point(440, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 61);
            this.label5.TabIndex = 0;
            this.label5.Text = "Reading!";
            // 
            // reading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1194, 719);
            this.Controls.Add(this.readTexts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "reading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.readTexts.ResumeLayout(false);
            this.readTexts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel readTexts;
        private Label readingTB;
        private Button returnText;
        private Button cardbordBut;
        private Button glassBut;
        private Button plasticBut;
        private Button generalBut;
        private Label label5;
    }
}