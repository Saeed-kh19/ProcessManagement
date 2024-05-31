﻿using Accounting.DataLayer;
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
    public partial class frmAccessDenied : Form
    {
        public int userId = 0;
        public frmAccessDenied()
        {
            InitializeComponent();
        }

        private void frmAccessDenied_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var user = db.LoginRepository.GetUserById(userId);

                if (user.Role == 1)
                {
                    frmSettings frmSettings = new frmSettings();
                    this.Close();
                    frmSettings.Show();
                }
            }
        }
    }
}
