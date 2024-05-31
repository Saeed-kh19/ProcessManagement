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
    public partial class frmForgotPasswords : Form
    {
        public int userId = 0;
        public frmForgotPasswords()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                Users user = db.LoginRepository.GetUserById(userId);
                if (user.SecurityQuestion.ToLower() != txtSecurityQuestions.Text.ToLower())
                {
                    MessageBox.Show("Incorrect answer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Your password is : {user.Password}", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
