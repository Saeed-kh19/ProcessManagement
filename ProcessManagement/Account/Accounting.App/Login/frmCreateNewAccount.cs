using Accounting.DataLayer;
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
    public partial class frmCreateNewAccount : Form
    {
        public frmCreateNewAccount()
        {
            InitializeComponent();
        }

        private void frmCreateNewAccount_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (txtFullname.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && txtEmail.Text != "" && txtSecurityQuestion.Text != "")
                {
                    Users user = new Users()
                    {
                        Name = txtFullname.Text,
                        Username = txtUsername.Text,
                        Password = txtPassword.Text,
                        Email = txtEmail.Text,
                        SecurityQuestion = txtSecurityQuestion.Text,
                        BlockShow = 1,
                        Role = 2
                    };
                    db.LoginGenericRepository.Insert(user);
                    db.Save();
                    MessageBox.Show("You have been successfully signed up!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please enter important fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
