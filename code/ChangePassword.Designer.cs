namespace recycling
{
    partial class ChangePassword
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.returnText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Knicknack", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FloralWhite;
            this.label2.Location = new System.Drawing.Point(274, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(509, 49);
            this.label2.TabIndex = 15;
            this.label2.Text = "Change Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.FloralWhite;
            this.nameBox.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameBox.Location = new System.Drawing.Point(439, 212);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(158, 30);
            this.nameBox.TabIndex = 16;
            this.nameBox.Text = "Name";
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.FloralWhite;
            this.passwordBox.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordBox.Location = new System.Drawing.Point(439, 286);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(158, 30);
            this.passwordBox.TabIndex = 17;
            this.passwordBox.Text = "New Password";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.FloralWhite;
            this.submit.Font = new System.Drawing.Font("Knicknack", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submit.Location = new System.Drawing.Point(464, 353);
            this.submit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(94, 32);
            this.submit.TabIndex = 19;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.logInSubmit_Click);
            // 
            // returnText
            // 
            this.returnText.BackColor = System.Drawing.Color.FloralWhite;
            this.returnText.Font = new System.Drawing.Font("Knicknack", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.returnText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.returnText.Location = new System.Drawing.Point(52, 492);
            this.returnText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.returnText.Name = "returnText";
            this.returnText.Size = new System.Drawing.Size(53, 26);
            this.returnText.TabIndex = 20;
            this.returnText.Text = "<--";
            this.returnText.UseVisualStyleBackColor = false;
            this.returnText.Click += new System.EventHandler(this.returnText_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1045, 539);
            this.Controls.Add(this.returnText);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private TextBox nameBox;
        private TextBox passwordBox;
        private Button submit;
        private Button returnText;
    }
}