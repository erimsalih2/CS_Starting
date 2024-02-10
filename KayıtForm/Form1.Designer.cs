namespace KayıtForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PageRegister = new System.Windows.Forms.TabPage();
            this.PageLogin = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.TboxName = new System.Windows.Forms.TextBox();
            this.TboxSurname = new System.Windows.Forms.TextBox();
            this.TboxMail = new System.Windows.Forms.TextBox();
            this.TboxPassword = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.TboxLogUser = new System.Windows.Forms.TextBox();
            this.TboxLogpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.PageRegister.SuspendLayout();
            this.PageLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PageRegister);
            this.tabControl1.Controls.Add(this.PageLogin);
            this.tabControl1.Location = new System.Drawing.Point(31, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(758, 432);
            this.tabControl1.TabIndex = 0;
            // 
            // PageRegister
            // 
            this.PageRegister.Controls.Add(this.label5);
            this.PageRegister.Controls.Add(this.label4);
            this.PageRegister.Controls.Add(this.label3);
            this.PageRegister.Controls.Add(this.label2);
            this.PageRegister.Controls.Add(this.label1);
            this.PageRegister.Controls.Add(this.btnRegister);
            this.PageRegister.Controls.Add(this.TboxName);
            this.PageRegister.Controls.Add(this.TboxSurname);
            this.PageRegister.Controls.Add(this.TboxMail);
            this.PageRegister.Controls.Add(this.TboxPassword);
            this.PageRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.PageRegister.Location = new System.Drawing.Point(4, 22);
            this.PageRegister.Name = "PageRegister";
            this.PageRegister.Padding = new System.Windows.Forms.Padding(3);
            this.PageRegister.Size = new System.Drawing.Size(750, 406);
            this.PageRegister.TabIndex = 0;
            this.PageRegister.Text = "Register";
            this.PageRegister.UseVisualStyleBackColor = true;
            // 
            // PageLogin
            // 
            this.PageLogin.Controls.Add(this.label7);
            this.PageLogin.Controls.Add(this.label6);
            this.PageLogin.Controls.Add(this.TboxLogpass);
            this.PageLogin.Controls.Add(this.TboxLogUser);
            this.PageLogin.Controls.Add(this.btnLogin);
            this.PageLogin.Controls.Add(this.lblLogin);
            this.PageLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.PageLogin.Location = new System.Drawing.Point(4, 22);
            this.PageLogin.Name = "PageLogin";
            this.PageLogin.Padding = new System.Windows.Forms.Padding(3);
            this.PageLogin.Size = new System.Drawing.Size(750, 406);
            this.PageLogin.TabIndex = 1;
            this.PageLogin.Text = "Login";
            this.PageLogin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(317, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Register";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(320, 264);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(113, 54);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click_1);
            // 
            // TboxName
            // 
            this.TboxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TboxName.Location = new System.Drawing.Point(320, 143);
            this.TboxName.Name = "TboxName";
            this.TboxName.Size = new System.Drawing.Size(113, 23);
            this.TboxName.TabIndex = 9;
            // 
            // TboxSurname
            // 
            this.TboxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TboxSurname.Location = new System.Drawing.Point(320, 172);
            this.TboxSurname.Name = "TboxSurname";
            this.TboxSurname.Size = new System.Drawing.Size(113, 23);
            this.TboxSurname.TabIndex = 8;
            // 
            // TboxMail
            // 
            this.TboxMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TboxMail.Location = new System.Drawing.Point(320, 206);
            this.TboxMail.Name = "TboxMail";
            this.TboxMail.Size = new System.Drawing.Size(113, 23);
            this.TboxMail.TabIndex = 7;
            // 
            // TboxPassword
            // 
            this.TboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TboxPassword.Location = new System.Drawing.Point(320, 235);
            this.TboxPassword.Name = "TboxPassword";
            this.TboxPassword.PasswordChar = '*';
            this.TboxPassword.Size = new System.Drawing.Size(113, 23);
            this.TboxPassword.TabIndex = 6;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblLogin.Location = new System.Drawing.Point(298, 96);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(80, 31);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(289, 275);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(89, 51);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // TboxLogUser
            // 
            this.TboxLogUser.Location = new System.Drawing.Point(289, 155);
            this.TboxLogUser.Name = "TboxLogUser";
            this.TboxLogUser.Size = new System.Drawing.Size(100, 26);
            this.TboxLogUser.TabIndex = 2;
            // 
            // TboxLogpass
            // 
            this.TboxLogpass.Location = new System.Drawing.Point(289, 209);
            this.TboxLogpass.Name = "TboxLogpass";
            this.TboxLogpass.PasswordChar = '*';
            this.TboxLogpass.Size = new System.Drawing.Size(100, 26);
            this.TboxLogpass.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "İsim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Soyisim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "E-Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Şifre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "E-Mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Şifre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.PageRegister.ResumeLayout(false);
            this.PageRegister.PerformLayout();
            this.PageLogin.ResumeLayout(false);
            this.PageLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PageRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox TboxName;
        private System.Windows.Forms.TextBox TboxSurname;
        private System.Windows.Forms.TextBox TboxMail;
        private System.Windows.Forms.TextBox TboxPassword;
        private System.Windows.Forms.TabPage PageLogin;
        private System.Windows.Forms.TextBox TboxLogpass;
        private System.Windows.Forms.TextBox TboxLogUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

