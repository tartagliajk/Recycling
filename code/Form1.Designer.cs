﻿namespace recycling
{
    partial class startSite
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startSite));
            this.label1 = new System.Windows.Forms.Label();
            this.logIn = new System.Windows.Forms.Button();
            this.startMenu = new System.Windows.Forms.Panel();
            this.signUp = new System.Windows.Forms.Button();
            this.logInPage = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.returnStartM = new System.Windows.Forms.Button();
            this.passBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.logInSubmit = new System.Windows.Forms.Button();
            this.signUpPage = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.returnSign = new System.Windows.Forms.Button();
            this.passSign = new System.Windows.Forms.TextBox();
            this.nameSign = new System.Windows.Forms.TextBox();
            this.sumbitSign = new System.Windows.Forms.Button();
            this.truckPic = new System.Windows.Forms.PictureBox();
            this.planetPic = new System.Windows.Forms.PictureBox();
            this.startMenu.SuspendLayout();
            this.logInPage.SuspendLayout();
            this.signUpPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.truckPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planetPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Knicknack", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recycling!";
            // 
            // logIn
            // 
            this.logIn.BackColor = System.Drawing.Color.FloralWhite;
            this.logIn.Font = new System.Drawing.Font("Knicknack", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logIn.Location = new System.Drawing.Point(71, 117);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(107, 53);
            this.logIn.TabIndex = 1;
            this.logIn.Text = "Log In";
            this.logIn.UseVisualStyleBackColor = false;
            this.logIn.Click += new System.EventHandler(this.logIn_Click);
            // 
            // startMenu
            // 
            this.startMenu.Controls.Add(this.signUp);
            this.startMenu.Controls.Add(this.logIn);
            this.startMenu.Controls.Add(this.label1);
            this.startMenu.Location = new System.Drawing.Point(451, 140);
            this.startMenu.Name = "startMenu";
            this.startMenu.Size = new System.Drawing.Size(261, 285);
            this.startMenu.TabIndex = 2;
            // 
            // signUp
            // 
            this.signUp.BackColor = System.Drawing.Color.FloralWhite;
            this.signUp.Font = new System.Drawing.Font("Knicknack", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signUp.Location = new System.Drawing.Point(71, 201);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(107, 55);
            this.signUp.TabIndex = 2;
            this.signUp.Text = "Sign up";
            this.signUp.UseVisualStyleBackColor = false;
            this.signUp.Click += new System.EventHandler(this.signUp_Click);
            // 
            // logInPage
            // 
            this.logInPage.Controls.Add(this.label2);
            this.logInPage.Controls.Add(this.returnStartM);
            this.logInPage.Controls.Add(this.passBox);
            this.logInPage.Controls.Add(this.nameBox);
            this.logInPage.Controls.Add(this.logInSubmit);
            this.logInPage.Location = new System.Drawing.Point(396, 79);
            this.logInPage.Name = "logInPage";
            this.logInPage.Size = new System.Drawing.Size(367, 472);
            this.logInPage.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Knicknack", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FloralWhite;
            this.label2.Location = new System.Drawing.Point(121, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 62);
            this.label2.TabIndex = 6;
            this.label2.Text = "Log in";
            // 
            // returnStartM
            // 
            this.returnStartM.BackColor = System.Drawing.Color.FloralWhite;
            this.returnStartM.Font = new System.Drawing.Font("Knicknack", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.returnStartM.Location = new System.Drawing.Point(3, 415);
            this.returnStartM.Name = "returnStartM";
            this.returnStartM.Size = new System.Drawing.Size(74, 44);
            this.returnStartM.TabIndex = 5;
            this.returnStartM.Text = "<--";
            this.returnStartM.UseVisualStyleBackColor = false;
            this.returnStartM.Click += new System.EventHandler(this.returnStartM_Click);
            // 
            // passBox
            // 
            this.passBox.BackColor = System.Drawing.Color.FloralWhite;
            this.passBox.Font = new System.Drawing.Font("Knicknack", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passBox.Location = new System.Drawing.Point(101, 251);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(172, 40);
            this.passBox.TabIndex = 4;
            this.passBox.Text = "P a s s w o r d";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.FloralWhite;
            this.nameBox.Font = new System.Drawing.Font("Knicknack", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameBox.Location = new System.Drawing.Point(101, 165);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(172, 40);
            this.nameBox.TabIndex = 3;
            this.nameBox.Text = "N a m e";
            // 
            // logInSubmit
            // 
            this.logInSubmit.BackColor = System.Drawing.Color.FloralWhite;
            this.logInSubmit.Font = new System.Drawing.Font("Knicknack", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logInSubmit.Location = new System.Drawing.Point(121, 348);
            this.logInSubmit.Name = "logInSubmit";
            this.logInSubmit.Size = new System.Drawing.Size(107, 43);
            this.logInSubmit.TabIndex = 2;
            this.logInSubmit.Text = "Submit";
            this.logInSubmit.UseVisualStyleBackColor = false;
            this.logInSubmit.Click += new System.EventHandler(this.logInSubmit_Click);
            // 
            // signUpPage
            // 
            this.signUpPage.Controls.Add(this.label3);
            this.signUpPage.Controls.Add(this.returnSign);
            this.signUpPage.Controls.Add(this.passSign);
            this.signUpPage.Controls.Add(this.nameSign);
            this.signUpPage.Controls.Add(this.sumbitSign);
            this.signUpPage.Location = new System.Drawing.Point(405, 76);
            this.signUpPage.Name = "signUpPage";
            this.signUpPage.Size = new System.Drawing.Size(361, 488);
            this.signUpPage.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Knicknack", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FloralWhite;
            this.label3.Location = new System.Drawing.Point(99, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 62);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sign Up";
            // 
            // returnSign
            // 
            this.returnSign.BackColor = System.Drawing.Color.FloralWhite;
            this.returnSign.Font = new System.Drawing.Font("Knicknack", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.returnSign.Location = new System.Drawing.Point(3, 443);
            this.returnSign.Name = "returnSign";
            this.returnSign.Size = new System.Drawing.Size(77, 43);
            this.returnSign.TabIndex = 5;
            this.returnSign.Text = "<--";
            this.returnSign.UseVisualStyleBackColor = false;
            this.returnSign.Click += new System.EventHandler(this.returnSign_Click);
            // 
            // passSign
            // 
            this.passSign.BackColor = System.Drawing.Color.FloralWhite;
            this.passSign.Font = new System.Drawing.Font("Knicknack", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passSign.Location = new System.Drawing.Point(91, 273);
            this.passSign.Name = "passSign";
            this.passSign.Size = new System.Drawing.Size(172, 40);
            this.passSign.TabIndex = 4;
            this.passSign.Text = "P a s s w o r d";
            // 
            // nameSign
            // 
            this.nameSign.BackColor = System.Drawing.Color.FloralWhite;
            this.nameSign.Font = new System.Drawing.Font("Knicknack", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameSign.Location = new System.Drawing.Point(91, 184);
            this.nameSign.Name = "nameSign";
            this.nameSign.Size = new System.Drawing.Size(172, 40);
            this.nameSign.TabIndex = 3;
            this.nameSign.Text = "N a m e ";
            // 
            // sumbitSign
            // 
            this.sumbitSign.BackColor = System.Drawing.Color.FloralWhite;
            this.sumbitSign.Font = new System.Drawing.Font("Knicknack", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sumbitSign.Location = new System.Drawing.Point(118, 361);
            this.sumbitSign.Name = "sumbitSign";
            this.sumbitSign.Size = new System.Drawing.Size(107, 43);
            this.sumbitSign.TabIndex = 2;
            this.sumbitSign.Text = "Submit";
            this.sumbitSign.UseVisualStyleBackColor = false;
            this.sumbitSign.Click += new System.EventHandler(this.sumbitSign_Click);
            // 
            // truckPic
            // 
            this.truckPic.Image = ((System.Drawing.Image)(resources.GetObject("truckPic.Image")));
            this.truckPic.Location = new System.Drawing.Point(12, 477);
            this.truckPic.Name = "truckPic";
            this.truckPic.Size = new System.Drawing.Size(306, 238);
            this.truckPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.truckPic.TabIndex = 9;
            this.truckPic.TabStop = false;
            // 
            // planetPic
            // 
            this.planetPic.Image = ((System.Drawing.Image)(resources.GetObject("planetPic.Image")));
            this.planetPic.Location = new System.Drawing.Point(893, 16);
            this.planetPic.Name = "planetPic";
            this.planetPic.Size = new System.Drawing.Size(291, 263);
            this.planetPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.planetPic.TabIndex = 10;
            this.planetPic.TabStop = false;
            // 
            // startSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1194, 719);
            this.Controls.Add(this.truckPic);
            this.Controls.Add(this.planetPic);
            this.Controls.Add(this.logInPage);
            this.Controls.Add(this.signUpPage);
            this.Controls.Add(this.startMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "startSite";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.startMenu.ResumeLayout(false);
            this.startMenu.PerformLayout();
            this.logInPage.ResumeLayout(false);
            this.logInPage.PerformLayout();
            this.signUpPage.ResumeLayout(false);
            this.signUpPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.truckPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planetPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Button logIn;
        private Panel startMenu;
        private Button signUp;
        private Panel logInPage;
        private Button returnStartM;
        private TextBox passBox;
        internal TextBox nameBox;
        private Button logInSubmit;
        private Label label2;
        private Panel signUpPage;
        private Label label3;
        private Button returnSign;
        private TextBox passSign;
        internal TextBox nameSign;
        private Button sumbitSign;
        private PictureBox truckPic;
        private PictureBox planetPic;
    }
}