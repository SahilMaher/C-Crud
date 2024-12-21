namespace WindowsFormsApplication6
{
    partial class SignUP
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
            this.txtunm = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.unameTxtSignUp = new System.Windows.Forms.Label();
            this.emailTxtSignUP = new System.Windows.Forms.Label();
            this.numberTxtSignUP = new System.Windows.Forms.Label();
            this.passTxtSignUP = new System.Windows.Forms.Label();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtunm
            // 
            this.txtunm.Location = new System.Drawing.Point(208, 28);
            this.txtunm.Name = "txtunm";
            this.txtunm.Size = new System.Drawing.Size(132, 22);
            this.txtunm.TabIndex = 0;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(208, 112);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(132, 22);
            this.txtmail.TabIndex = 1;
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(208, 84);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(132, 22);
            this.txtnum.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(208, 56);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(132, 22);
            this.txtPass.TabIndex = 3;
            // 
            // unameTxtSignUp
            // 
            this.unameTxtSignUp.AutoSize = true;
            this.unameTxtSignUp.Location = new System.Drawing.Point(106, 28);
            this.unameTxtSignUp.Name = "unameTxtSignUp";
            this.unameTxtSignUp.Size = new System.Drawing.Size(75, 17);
            this.unameTxtSignUp.TabIndex = 4;
            this.unameTxtSignUp.Text = "UserName";
            // 
            // emailTxtSignUP
            // 
            this.emailTxtSignUP.AutoSize = true;
            this.emailTxtSignUP.Location = new System.Drawing.Point(106, 112);
            this.emailTxtSignUP.Name = "emailTxtSignUP";
            this.emailTxtSignUP.Size = new System.Drawing.Size(47, 17);
            this.emailTxtSignUP.TabIndex = 5;
            this.emailTxtSignUP.Text = "E-Mail";
            // 
            // numberTxtSignUP
            // 
            this.numberTxtSignUP.AutoSize = true;
            this.numberTxtSignUP.Location = new System.Drawing.Point(106, 84);
            this.numberTxtSignUP.Name = "numberTxtSignUP";
            this.numberTxtSignUP.Size = new System.Drawing.Size(58, 17);
            this.numberTxtSignUP.TabIndex = 6;
            this.numberTxtSignUP.Text = "Number";
            // 
            // passTxtSignUP
            // 
            this.passTxtSignUP.AutoSize = true;
            this.passTxtSignUP.Location = new System.Drawing.Point(106, 56);
            this.passTxtSignUP.Name = "passTxtSignUP";
            this.passTxtSignUP.Size = new System.Drawing.Size(69, 17);
            this.passTxtSignUP.TabIndex = 7;
            this.passTxtSignUP.Text = "Password";
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.Location = new System.Drawing.Point(208, 273);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(75, 23);
            this.BtnSignUp.TabIndex = 8;
            this.BtnSignUp.Text = "SignUp";
            this.BtnSignUp.UseVisualStyleBackColor = true;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(205, 299);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(70, 17);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "LoginNow";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(208, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 110);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // SignUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 341);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.BtnSignUp);
            this.Controls.Add(this.passTxtSignUP);
            this.Controls.Add(this.numberTxtSignUP);
            this.Controls.Add(this.emailTxtSignUP);
            this.Controls.Add(this.unameTxtSignUp);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txtunm);
            this.Name = "SignUP";
            this.Text = "SignUP";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtunm;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label unameTxtSignUp;
        private System.Windows.Forms.Label emailTxtSignUP;
        private System.Windows.Forms.Label numberTxtSignUP;
        private System.Windows.Forms.Label passTxtSignUP;
        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}