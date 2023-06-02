namespace recycling
{
    partial class ListMembers
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
            this.label2 = new System.Windows.Forms.Label();
            this.outputText = new System.Windows.Forms.Label();
            this.returnText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Knicknack", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FloralWhite;
            this.label2.Location = new System.Drawing.Point(358, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 49);
            this.label2.TabIndex = 14;
            this.label2.Text = "List all members";
            // 
            // outputText
            // 
            this.outputText.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputText.Location = new System.Drawing.Point(213, 110);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(619, 339);
            this.outputText.TabIndex = 15;
            this.outputText.Text = "Label";
            // 
            // returnText
            // 
            this.returnText.BackColor = System.Drawing.Color.FloralWhite;
            this.returnText.Font = new System.Drawing.Font("Knicknack", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.returnText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.returnText.Location = new System.Drawing.Point(34, 496);
            this.returnText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.returnText.Name = "returnText";
            this.returnText.Size = new System.Drawing.Size(53, 26);
            this.returnText.TabIndex = 16;
            this.returnText.Text = "<--";
            this.returnText.UseVisualStyleBackColor = false;
            this.returnText.Click += new System.EventHandler(this.returnText_Click);
            // 
            // ListMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1045, 539);
            this.Controls.Add(this.returnText);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListMembers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label outputText;
        private Button returnText;
    }
}