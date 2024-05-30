using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using Accounting.ViewModels;
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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            rbUsers.Checked = true;
            using (UnitOfWork db = new UnitOfWork())
            {
                List<SettingsViewModel> usersLists = new List<SettingsViewModel>();
                usersLists.Add(new SettingsViewModel()
                {
                    UserID = 0,
                    Name = "Please select a user",
                });
                usersLists.AddRange(db.LoginRepository.GetAllUsersNames());
                cbUsers.DataSource = usersLists;
                cbUsers.DisplayMember = "Name";
                cbUsers.ValueMember = "UserID";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if ((int)cbUsers.SelectedValue != 0)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    Users user = db.LoginRepository.GetUserById((int)cbUsers.SelectedValue);
                    if (rbAdmins.Checked == true)
                    {
                        user.Role = 1;
                    }
                    else if (rbUsers.Checked == true)
                    {
                        user.Role = 2;
                    }
                    db.LoginRepository.UpdateUser(user);
                    db.Save();
                    MessageBox.Show("User role successfully saved", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a user at first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
