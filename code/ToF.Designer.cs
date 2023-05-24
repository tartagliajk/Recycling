namespace recycling
{
    partial class ToF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToF));
            this.quizPanel = new System.Windows.Forms.Panel();
            this.returnToF = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.Label();
            this.optionFalse = new System.Windows.Forms.Button();
            this.optionTrue = new System.Windows.Forms.Button();
            this.statement = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.startPanel = new System.Windows.Forms.Panel();
            this.startBut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.quizPanel.SuspendLayout();
            this.startPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // quizPanel
            // 
            this.quizPanel.Controls.Add(this.answer);
            this.quizPanel.Controls.Add(this.optionFalse);
            this.quizPanel.Controls.Add(this.optionTrue);
            this.quizPanel.Controls.Add(this.statement);
            this.quizPanel.Controls.Add(this.label6);
            this.quizPanel.Location = new System.Drawing.Point(167, 117);
            this.quizPanel.Name = "quizPanel";
            this.quizPanel.Size = new System.Drawing.Size(858, 450);
            this.quizPanel.TabIndex = 14;
            // 
            // returnToF
            // 
            this.returnToF.BackColor = System.Drawing.Color.FloralWhite;
            this.returnToF.Font = new System.Drawing.Font("Knicknack", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.returnToF.Location = new System.Drawing.Point(22, 669);
            this.returnToF.Name = "returnToF";
            this.returnToF.Size = new System.Drawing.Size(84, 38);
            this.returnToF.TabIndex = 8;
            this.returnToF.Text = "<--";
            this.returnToF.UseVisualStyleBackColor = false;
            this.returnToF.Click += new System.EventHandler(this.returnToF_Click);
            // 
            // answer
            // 
            this.answer.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answer.ForeColor = System.Drawing.Color.FloralWhite;
            this.answer.Location = new System.Drawing.Point(238, 371);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(479, 55);
            this.answer.TabIndex = 9;
            this.answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // optionFalse
            // 
            this.optionFalse.BackColor = System.Drawing.Color.FloralWhite;
            this.optionFalse.Font = new System.Drawing.Font("Knicknack", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.optionFalse.Location = new System.Drawing.Point(524, 276);
            this.optionFalse.Name = "optionFalse";
            this.optionFalse.Size = new System.Drawing.Size(243, 74);
            this.optionFalse.TabIndex = 7;
            this.optionFalse.Text = "False";
            this.optionFalse.UseVisualStyleBackColor = false;
            this.optionFalse.Click += new System.EventHandler(this.optionFalse_Click);
            // 
            // optionTrue
            // 
            this.optionTrue.BackColor = System.Drawing.Color.FloralWhite;
            this.optionTrue.Font = new System.Drawing.Font("Knicknack", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.optionTrue.Location = new System.Drawing.Point(167, 276);
            this.optionTrue.Name = "optionTrue";
            this.optionTrue.Size = new System.Drawing.Size(243, 74);
            this.optionTrue.TabIndex = 5;
            this.optionTrue.Text = "True";
            this.optionTrue.UseVisualStyleBackColor = false;
            this.optionTrue.Click += new System.EventHandler(this.optionTrue_Click);
            // 
            // statement
            // 
            this.statement.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statement.ForeColor = System.Drawing.Color.FloralWhite;
            this.statement.Location = new System.Drawing.Point(211, 164);
            this.statement.Name = "statement";
            this.statement.Size = new System.Drawing.Size(521, 117);
            this.statement.TabIndex = 1;
            this.statement.Text = "If you lined up the plastic bottles tossed away each year, they would circle our " +
    "planet four times.";
            this.statement.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Knicknack", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FloralWhite;
            this.label6.Location = new System.Drawing.Point(326, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 61);
            this.label6.TabIndex = 0;
            this.label6.Text = "True or false";
            // 
            // startPanel
            // 
            this.startPanel.Controls.Add(this.pictureBox1);
            this.startPanel.Controls.Add(this.startBut);
            this.startPanel.Location = new System.Drawing.Point(121, 73);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(1006, 562);
            this.startPanel.TabIndex = 15;
            // 
            // startBut
            // 
            this.startBut.BackColor = System.Drawing.Color.FloralWhite;
            this.startBut.Font = new System.Drawing.Font("Knicknack", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startBut.Location = new System.Drawing.Point(181, 251);
            this.startBut.Name = "startBut";
            this.startBut.Size = new System.Drawing.Size(243, 74);
            this.startBut.TabIndex = 5;
            this.startBut.Text = "Start";
            this.startBut.UseVisualStyleBackColor = false;
            this.startBut.Click += new System.EventHandler(this.startBut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(550, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ToF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1194, 719);
            this.Controls.Add(this.startPanel);
            this.Controls.Add(this.quizPanel);
            this.Controls.Add(this.returnToF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ToF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.quizPanel.ResumeLayout(false);
            this.quizPanel.PerformLayout();
            this.startPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel quizPanel;
        private Label answer;
        private Button returnToF;
        private Button optionFalse;
        private Button optionTrue;
        private Label statement;
        private Label label6;
        private Panel startPanel;
        private Button startBut;
        private PictureBox pictureBox1;
    }
}