namespace Accounting.App
{
    partial class frmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCreateNewAccount = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnShowPasswords = new System.Windows.Forms.PictureBox();
            this.lblForgotPassword = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowPasswords)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(436, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtUsername.Location = new System.Drawing.Point(439, 114);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(296, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(99)))), ((int)(((byte)(237)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Location = new System.Drawing.Point(439, 248);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(296, 34);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.txtPassword.Location = new System.Drawing.Point(439, 174);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(296, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(484, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sign in to Accounting";
            // 
            // lblCreateNewAccount
            // 
            this.lblCreateNewAccount.ActiveLinkColor = System.Drawing.Color.Black;
            this.lblCreateNewAccount.AutoSize = true;
            this.lblCreateNewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateNewAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(99)))), ((int)(((byte)(237)))));
            this.lblCreateNewAccount.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblCreateNewAccount.LinkColor = System.Drawing.SystemColors.WindowFrame;
            this.lblCreateNewAccount.Location = new System.Drawing.Point(531, 293);
            this.lblCreateNewAccount.Name = "lblCreateNewAccount";
            this.lblCreateNewAccount.Size = new System.Drawing.Size(115, 16);
            this.lblCreateNewAccount.TabIndex = 5;
            this.lblCreateNewAccount.TabStop = true;
            this.lblCreateNewAccount.Text = "Create an account";
            this.lblCreateNewAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCreateNewAccount_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Accounting.App.Properties.Resources._33328;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 344);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnShowPasswords
            // 
            this.btnShowPasswords.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnShowPasswords.Image = global::Accounting.App.Properties.Resources.icons8_eye_48;
            this.btnShowPasswords.Location = new System.Drawing.Point(702, 174);
            this.btnShowPasswords.Name = "btnShowPasswords";
            this.btnShowPasswords.Size = new System.Drawing.Size(26, 27);
            this.btnShowPasswords.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnShowPasswords.TabIndex = 20;
            this.btnShowPasswords.TabStop = false;
            this.btnShowPasswords.Click += new System.EventHandler(this.btnShowPasswords_Click);
            this.btnShowPasswords.MouseEnter += new System.EventHandler(this.btnShowPasswords_MouseEnter);
            this.btnShowPasswords.MouseLeave += new System.EventHandler(this.btnShowPasswords_MouseLeave);
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(99)))), ((int)(((byte)(237)))));
            this.lblForgotPassword.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblForgotPassword.Location = new System.Drawing.Point(634, 208);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(106, 15);
            this.lblForgotPassword.TabIndex = 3;
            this.lblForgotPassword.TabStop = true;
            this.lblForgotPassword.Text = "Forgot Password?";
            this.lblForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblForgotPassword_LinkClicked);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(786, 341);
            this.Controls.Add(this.btnShowPasswords);
            this.Controls.Add(this.lblCreateNewAccount);
            this.Controls.Add(this.lblForgotPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login to your Account";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowPasswords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lblCreateNewAccount;
        private System.Windows.Forms.PictureBox btnShowPasswords;
        private System.Windows.Forms.LinkLabel lblForgotPassword;
    }
}