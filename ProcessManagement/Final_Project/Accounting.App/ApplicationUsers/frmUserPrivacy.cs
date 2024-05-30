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
    public partial class frmUserPrivacy : Form
    {
        public int userId;

        //IF BLOCKSHOW IS 1 -> THEN ALLOW / ELSE IF BLOCKSHOW IS 2 -> THEN BLOCK

        public frmUserPrivacy()
        {
            InitializeComponent();
        }

        private void frmUserPrivacy_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                Users user = db.UsersRepository.GetUserById(userId);
                lblName.Text = user.Name;
                if (user.BlockShow == 1)
                {
                    rbAllow.Checked = true;
                }
                else if (user.BlockShow == 2)
                {
                    rbBlock.Checked = true;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                Users user = db.UsersRepository.GetUserById(userId);
                if (rbAllow.Checked == true)
                {
                    user.BlockShow = 1;
                }
                else if (rbBlock.Checked == true)
                {
                    user.BlockShow = 2;
                }
                db.LoginGenericRepository.Update(user);
                db.Save();
            }
            MessageBox.Show("Privacy edited successfully!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
