namespace recycling
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.label5 = new System.Windows.Forms.Label();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.sumbit = new System.Windows.Forms.Button();
            this.trashBox = new System.Windows.Forms.TextBox();
            this.colorBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.startBut = new System.Windows.Forms.Button();
            this.trashDisplay = new System.Windows.Forms.Panel();
            this.colorDisplay = new System.Windows.Forms.Label();
            this.itemDisplay = new System.Windows.Forms.Label();
            this.nameDisplay = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.returnStartM = new System.Windows.Forms.Button();
            this.inputPanel.SuspendLayout();
            this.trashDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Knicknack", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FloralWhite;
            this.label5.Location = new System.Drawing.Point(304, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(583, 61);
            this.label5.TabIndex = 1;
            this.label5.Text = "Create Your Own Trash Can!";
            // 
            // inputPanel
            // 
            this.inputPanel.Controls.Add(this.sumbit);
            this.inputPanel.Controls.Add(this.trashBox);
            this.inputPanel.Controls.Add(this.colorBox);
            this.inputPanel.Controls.Add(this.nameBox);
            this.inputPanel.Location = new System.Drawing.Point(384, 163);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(409, 464);
            this.inputPanel.TabIndex = 2;
            // 
            // sumbit
            // 
            this.sumbit.BackColor = System.Drawing.Color.FloralWhite;
            this.sumbit.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sumbit.Location = new System.Drawing.Point(137, 383);
            this.sumbit.Name = "sumbit";
            this.sumbit.Size = new System.Drawing.Size(131, 40);
            this.sumbit.TabIndex = 8;
            this.sumbit.Text = "Submit";
            this.sumbit.UseVisualStyleBackColor = false;
            this.sumbit.Click += new System.EventHandler(this.sumbit_Click);
            // 
            // trashBox
            // 
            this.trashBox.BackColor = System.Drawing.Color.FloralWhite;
            this.trashBox.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trashBox.Location = new System.Drawing.Point(75, 199);
            this.trashBox.Multiline = true;
            this.trashBox.Name = "trashBox";
            this.trashBox.Size = new System.Drawing.Size(257, 52);
            this.trashBox.TabIndex = 2;
            this.trashBox.Text = "An item that you can throw";
            this.trashBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.Color.FloralWhite;
            this.colorBox.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colorBox.Location = new System.Drawing.Point(75, 299);
            this.colorBox.Multiline = true;
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(257, 52);
            this.colorBox.TabIndex = 1;
            this.colorBox.Text = "Color";
            this.colorBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.FloralWhite;
            this.nameBox.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameBox.Location = new System.Drawing.Point(75, 92);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(257, 52);
            this.nameBox.TabIndex = 0;
            this.nameBox.Text = "Name";
            this.nameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startBut
            // 
            this.startBut.BackColor = System.Drawing.Color.FloralWhite;
            this.startBut.Font = new System.Drawing.Font("Knicknack", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startBut.Location = new System.Drawing.Point(476, 322);
            this.startBut.Name = "startBut";
            this.startBut.Size = new System.Drawing.Size(243, 74);
            this.startBut.TabIndex = 6;
            this.startBut.Text = "Start";
            this.startBut.UseVisualStyleBackColor = false;
            this.startBut.Click += new System.EventHandler(this.startBut_Click);
            // 
            // trashDisplay
            // 
            this.trashDisplay.Controls.Add(this.colorDisplay);
            this.trashDisplay.Controls.Add(this.itemDisplay);
            this.trashDisplay.Controls.Add(this.nameDisplay);
            this.trashDisplay.Controls.Add(this.pictureBox1);
            this.trashDisplay.Location = new System.Drawing.Point(202, 132);
            this.trashDisplay.Name = "trashDisplay";
            this.trashDisplay.Size = new System.Drawing.Size(869, 495);
            this.trashDisplay.TabIndex = 9;
            // 
            // colorDisplay
            // 
            this.colorDisplay.AutoSize = true;
            this.colorDisplay.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colorDisplay.ForeColor = System.Drawing.Color.FloralWhite;
            this.colorDisplay.Location = new System.Drawing.Point(102, 298);
            this.colorDisplay.Name = "colorDisplay";
            this.colorDisplay.Size = new System.Drawing.Size(97, 34);
            this.colorDisplay.TabIndex = 3;
            this.colorDisplay.Text = "Color";
            // 
            // itemDisplay
            // 
            this.itemDisplay.AutoSize = true;
            this.itemDisplay.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.itemDisplay.ForeColor = System.Drawing.Color.FloralWhite;
            this.itemDisplay.Location = new System.Drawing.Point(102, 229);
            this.itemDisplay.Name = "itemDisplay";
            this.itemDisplay.Size = new System.Drawing.Size(82, 34);
            this.itemDisplay.TabIndex = 2;
            this.itemDisplay.Text = "Item";
            // 
            // nameDisplay
            // 
            this.nameDisplay.AutoSize = true;
            this.nameDisplay.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameDisplay.ForeColor = System.Drawing.Color.FloralWhite;
            this.nameDisplay.Location = new System.Drawing.Point(102, 159);
            this.nameDisplay.Name = "nameDisplay";
            this.nameDisplay.Size = new System.Drawing.Size(99, 34);
            this.nameDisplay.TabIndex = 1;
            this.nameDisplay.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(515, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 312);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // returnStartM
            // 
            this.returnStartM.BackColor = System.Drawing.Color.FloralWhite;
            this.returnStartM.Font = new System.Drawing.Font("Knicknack", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.returnStartM.Location = new System.Drawing.Point(12, 672);
            this.returnStartM.Name = "returnStartM";
            this.returnStartM.Size = new System.Drawing.Size(74, 35);
            this.returnStartM.TabIndex = 6;
            this.returnStartM.Text = "<--";
            this.returnStartM.UseVisualStyleBackColor = false;
            this.returnStartM.Click += new System.EventHandler(this.returnStartM_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1194, 719);
            this.Controls.Add(this.returnStartM);
            this.Controls.Add(this.trashDisplay);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.startBut);
            this.Controls.Add(this.label5);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.trashDisplay.ResumeLayout(false);
            this.trashDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label5;
        private Panel inputPanel;
        private TextBox nameBox;
        private TextBox trashBox;
        private TextBox colorBox;
        private Button startBut;
        private Button sumbit;
        private Panel trashDisplay;
        private Button returnStartM;
        private PictureBox pictureBox1;
        private Label colorDisplay;
        private Label itemDisplay;
        private Label nameDisplay;
    }
}