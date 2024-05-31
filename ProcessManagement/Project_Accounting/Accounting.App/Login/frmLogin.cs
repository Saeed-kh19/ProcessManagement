using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.App
{
    public partial class frmLogin : Form
    {
        bool loginChecker = false;  //WHEN A USER MATCHES THE RESULT , IT WILL BE 'TRUE'!...
        int PasswordCharCounter = 0;
        public int userId;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.txtUsername.AutoSize = false;
            this.txtUsername.Size = new System.Drawing.Size(296, 27);
            this.txtPassword.AutoSize = false;
            this.txtPassword.Size = new System.Drawing.Size(296, 27);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<Users> users = db.LoginRepository.GetAllUsers();
                foreach (var user in users)
                {
                    if (user.Username == txtUsername.Text && user.Password == txtPassword.Text)
                    {
                        userId = user.UserID;
                        loginChecker = true;
                        DialogResult = DialogResult.OK;
                    }
                }
                if (loginChecker == false)
                {
                    MessageBox.Show("Username or Password is incorrect!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnShowPasswords_MouseEnter(object sender, EventArgs e)
        {
            btnShowPasswords.BackColor = SystemColors.AppWorkspace;
        }

        private void btnShowPasswords_MouseLeave(object sender, EventArgs e)
        {
            btnShowPasswords.BackColor = SystemColors.ScrollBar;
        }

        private void btnShowPasswords_Click(object sender, EventArgs e)
        {
            btnShowPasswords.BackColor = SystemColors.ScrollBar;
            if (PasswordCharCounter % 2 == 0)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
            PasswordCharCounter++;
            txtPassword.TabIndex = 1;
        }

        private void lblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            using (UnitOfWork db = new UnitOfWork())
            {
                if (txtUsername.Text != "")
                {
                    bool isExist = db.LoginGenericRepository.Get(t => t.Username == txtUsername.Text).Select(t => t.UserID).ToList().Any();
                    if (isExist == true)
                    {
                        int user = db.LoginGenericRepository.Get(t => t.Username == txtUsername.Text).Select(t => t.UserID).ToList().FirstOrDefault();
                        frmForgotPasswords frmForgotPasswords = new frmForgotPasswords();
                        frmForgotPasswords.userId = user;
                        frmForgotPasswords.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please enter your username correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter your username correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void lblCreateNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCreateNewAccount frmCreateNewAccount = new frmCreateNewAccount();
            frmCreateNewAccount.ShowDialog();
        }
    }
}
