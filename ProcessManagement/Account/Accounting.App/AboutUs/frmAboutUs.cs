using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.App.AboutUs
{
    public partial class frmAboutUs : Form
    {
        DateTime dateTime;
        public frmAboutUs()
        {
            InitializeComponent();
        }

        private void tmrDateAndTime_Tick(object sender, EventArgs e)
        {
            SetDateAndTime();
        }

        private void frmAboutUs_Load(object sender, EventArgs e)
        {
            SetDateAndTime();
        }

        public void SetDateAndTime()
        {
            dateTime = DateTime.Now;
            lblDay.Text = dateTime.DayOfWeek.ToString();
            lblTime.Text = dateTime.ToString("hh:mm tt");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
