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
    public partial class frmApplicationUsers : Form
    {
        public frmApplicationUsers()
        {
            InitializeComponent();
        }

        private void frmApplicationUsers_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                //for generating only our target columns!
                dgUsers.AutoGenerateColumns = false;


                List<Users> users = db.UsersRepository.GetAllUsers();
                List<Users> usersList = new List<Users>();
                foreach (Users user in users)
                {
                    if (user.BlockShow == 1)
                    {
                        usersList.Add(user);
                    }
                }
                dgUsers.DataSource = usersList;
            }
        }
    }
}
