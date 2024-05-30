using Accounting.App.AboutUs;
using Accounting.Business;
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
    public partial class Form1 : Form
    {
        DateTime dateTime = new DateTime();
        public int userId;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void btnSettings_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Login Authentication
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            if (frmLogin.DialogResult == DialogResult.OK)
            {
                this.Show();
                userId = frmLogin.userId;


                //Date & Time
                dateTime = DateTime.Now;
                lblDay.Text = dateTime.DayOfWeek.ToString();
                lblTime.Text = dateTime.ToString("hh:mm tt");


                //Transaction Analysis Field Actions
                Analysis();
            }
            else
            {
                Application.Exit();
            }

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void tmrDateAndTime_Tick(object sender, EventArgs e)
        {
            dateTime = DateTime.Now;
            lblDay.Text = dateTime.DayOfWeek.ToString();
            lblTime.Text = dateTime.ToString("hh:mm tt");
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            frmAboutUs frmAboutUs = new frmAboutUs();
            frmAboutUs.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePassword = new frmChangePassword();
            frmChangePassword.ShowDialog();
        }

        private void btnAccountSide_Click(object sender, EventArgs e)
        {
            frmAccountSide frmAccountSide = new frmAccountSide();
            frmAccountSide.userId = userId;
            frmAccountSide.ShowDialog();
        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            frmTransaction frmTransaction = new frmTransaction();
            frmTransaction.userId = userId;
            frmTransaction.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReports frmReports = new frmReports();
            frmReports.userId = userId;
            frmReports.ShowDialog();
        }

        private void btnApplicationUsers_Click(object sender, EventArgs e)
        {
            frmApplicationUsers frmApplicationUsers = new frmApplicationUsers();
            frmApplicationUsers.ShowDialog();
        }

        private void btnUserPrivacy_Click(object sender, EventArgs e)
        {
            frmUserPrivacy frmUserPrivacy = new frmUserPrivacy();
            frmUserPrivacy.userId = userId;
            frmUserPrivacy.ShowDialog();
        }

        public void Analysis()
        {
            AnalyzeViewModel analyzeView = TransactionAnalysis.GetAnalyzeView();
            lblTotalIncome.Text = analyzeView.TotalIncome.ToString("#,0");
            lblTodayIncome.Text = analyzeView.TodayIncome.ToString("#,0");
            lblAverageIncome.Text = analyzeView.AverageIncome.ToString("#,0");
            lblTotalOutcome.Text = analyzeView.TotalOutcome.ToString("#,0");
            lblTodayOutcome.Text = analyzeView.TodayOutcome.ToString("#,0");
            lblAverageOutcome.Text = analyzeView.AverageOutcome.ToString("#,0");
            if (analyzeView.TotalIncome > analyzeView.TotalOutcome)
            {
                lblFinalBalance.Text = (analyzeView.TotalIncome - analyzeView.TotalOutcome).ToString("#,0") + "  (Income)";
            }
            else
            {
                lblFinalBalance.Text = (analyzeView.TotalOutcome - analyzeView.TotalIncome).ToString("#,0") + "  (Outcome)";
            }
        }

        private void tmrTransactionAnalysisRefresh_Tick(object sender, EventArgs e)
        {
            Analysis();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmAccessDenied frmAccessDenied = new frmAccessDenied();
            frmAccessDenied.userId = userId;
            frmAccessDenied.Show();
        }
    }
}