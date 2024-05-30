using Accounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.App
{
    public partial class frmChangePassword : Form
    {
        int CurrentPasswordCharCounter = 0;
        int NewPasswordCharCounter = 0;
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (db.LoginGenericRepository.Get(l => l.Username == txtCurrentUsername.Text && l.Password == txtCurrentPassword.Text).Any())
                {
                    var login = db.LoginGenericRepository.Get().First();
                    login.Username = txtNewUsername.Text;
                    login.Password = txtNewPassword.Text;
                    db.LoginGenericRepository.Update(login);
                    db.Save();
                    MessageBox.Show("Credentials Edited Successfuly!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Current Username or Password is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnShowCurrentPassword_Click_1(object sender, EventArgs e)
        {
            if (CurrentPasswordCharCounter % 2 == 0)
            {
                txtCurrentPassword.PasswordChar = '*';
            }
            else
            {
                txtCurrentPassword.PasswordChar = '\0';
            }
            CurrentPasswordCharCounter++;
        }

        private void btnShowNewPassword_Click_1(object sender, EventArgs e)
        {
            if (NewPasswordCharCounter % 2 == 0)
            {
                txtNewPassword.PasswordChar = '*';
            }
            else
            {
                txtNewPassword.PasswordChar = '\0';
            }
            NewPasswordCharCounter++;
        }

        private void btnShowCurrentPassword_MouseEnter(object sender, EventArgs e)
        {
            btnShowCurrentPassword.BackColor = SystemColors.AppWorkspace;
        }

        private void btnShowCurrentPassword_MouseLeave(object sender, EventArgs e)
        {
            btnShowCurrentPassword.BackColor = SystemColors.ScrollBar;
        }

        private void btnShowNewPassword_MouseEnter(object sender, EventArgs e)
        {
            btnShowNewPassword.BackColor = SystemColors.AppWorkspace;
        }

        private void btnShowNewPassword_MouseLeave(object sender, EventArgs e)
        {
            btnShowNewPassword.BackColor = SystemColors.ScrollBar;
        }
    }
}
