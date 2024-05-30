using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using Accounting.ViewModels.Persons;
using Accounting.DataLayer.Services;
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
    public partial class frmReports : Form
    {
        public int userId = 0;
        public int typeId = 0;
        public bool isIncome = false;
        public bool isOutcome = false;
        int incomeCounter = 0;
        int outcomeCounter = 0;
        public frmReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            dgTransactions.AutoGenerateColumns = false;
            using (UnitOfWork db = new UnitOfWork())
            {
                List<ListPersonsViewModel> list = new List<ListPersonsViewModel>();
                list.Add(new ListPersonsViewModel()
                {
                    PersonID = 0,
                    PersonFullName = "Select a person"
                });
                list.AddRange(db.TransactionRepository.GetAllPersonsNames(""));
                cbPersons.DataSource = list;
                cbPersons.DisplayMember = "PersonFullName";
                cbPersons.ValueMember = "PersonID";
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Filter(false);
        }

        public void Filter(bool isRefresh)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                int currentRowIndex = 0;

                List<Transactions> transactionResults = new List<Transactions>();

                dgTransactions.AutoGenerateColumns = false;

                DateTime? startDate;
                DateTime? endDate;

                if (isRefresh == true)
                {
                    if (isIncome == true)
                    {
                        transactionResults.AddRange(db.TransactionRepository.GetIncomeTransactions());
                    }
                    else if (isOutcome == true)
                    {
                        transactionResults.AddRange(db.TransactionRepository.GetOutcomeTransactions());
                    }
                    else
                    {
                        transactionResults.AddRange(db.TransactionsGenericRepository.Get());
                    }
                }
                else
                {
                    if ((int)cbPersons.SelectedValue != 0)
                    {
                        int PersonId = int.Parse(cbPersons.SelectedValue.ToString());
                        if (isIncome == true)
                        {
                            transactionResults.AddRange(db.TransactionsGenericRepository.Get(p => p.TypeID == 1));
                        }
                        else if (isOutcome == true)
                        {
                            transactionResults.AddRange(db.TransactionsGenericRepository.Get(p => p.TypeID == 2));
                        }
                        else
                        {
                            transactionResults.AddRange(db.TransactionsGenericRepository.Get(p => p.PersonID == PersonId));
                        }
                    }
                    else
                    {
                        transactionResults.AddRange(db.TransactionsGenericRepository.Get());
                    }

                    if (txtFromDate.Text != "  /  /")
                    {
                        startDate = Convert.ToDateTime(txtFromDate.Text);
                        transactionResults = transactionResults.Where(r => r.DateTime >= startDate.Value).ToList();
                    }

                    if (txtToDate.Text != "  /  /")
                    {
                        endDate = Convert.ToDateTime(txtToDate.Text);
                        transactionResults = transactionResults.Where(r => r.DateTime <= endDate.Value).ToList();
                    }
                }
                dgTransactions.Rows.Clear();
                foreach (var transaction in transactionResults)
                {
                    string personName = db.TransactionRepository.GetPersonNameById(transaction.PersonID);
                    dgTransactions.Rows.Add(transaction.TransactionID, personName, transaction.Amount, transaction.DateTime, transaction.Description);
                    if (transaction.TypeID == 1)
                    {
                        dgTransactions.Rows[currentRowIndex].DefaultCellStyle.BackColor = Color.LightCyan;
                    }
                    else if (transaction.TypeID == 2)
                    {
                        dgTransactions.Rows[currentRowIndex].DefaultCellStyle.BackColor = Color.Pink;
                    }
                    currentRowIndex++;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnIncomeTransactions.BackColor = Color.Transparent;
            btnOutcomeTransactions.BackColor = Color.Transparent;
            isIncome = false;
            isOutcome = false;

            Filter(true);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db1 = new UnitOfWork())
            {
                if (db1.LoginRepository.GetUserById(userId).Role == 1)
                {
                    if (dgTransactions.CurrentRow != null)
                    {
                        int id = int.Parse(dgTransactions.CurrentRow.Cells[0].Value.ToString());
                        if (MessageBox.Show("Are you sure to delete this transaction?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            using (UnitOfWork db = new UnitOfWork())
                            {
                                Transactions transaction = new Transactions();
                                transaction = db.TransactionRepository.GetTransactionsById(id);
                                db.TransactionsGenericRepository.Delete(transaction);
                                db.Save();
                                Filter(false);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Access Denied!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db1 = new UnitOfWork())
            {
                if (db1.LoginRepository.GetUserById(userId).Role == 1)
                {
                    frmTransaction frmTransaction = new frmTransaction();
                    frmTransaction.userId = userId;
                    if (dgTransactions.CurrentRow != null)
                    {

                        frmTransaction.transactionId = int.Parse(dgTransactions.CurrentRow.Cells[0].Value.ToString());
                        if (frmTransaction.ShowDialog() == DialogResult.OK)
                        {
                            Filter(false);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Access Denied!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIncomeTransactions_Click(object sender, EventArgs e)
        {
            if (incomeCounter % 2 == 0)
            {
                if (isOutcome == true)
                {
                    isOutcome = false;
                }
                btnIncomeTransactions.BackColor = Color.Lavender;
                btnOutcomeTransactions.BackColor = Color.Transparent;
                isIncome = true;
                isOutcome = false;
                Filter(true);
            }
            else
            {
                btnIncomeTransactions.BackColor = Color.Transparent;
                btnOutcomeTransactions.BackColor = Color.Transparent;
                isIncome = false;
                Filter(false);
            }
            incomeCounter++;
        }

        private void btnOutcomeTransactions_Click(object sender, EventArgs e)
        {
            if (outcomeCounter % 2 == 0)
            {
                if (isIncome == true)
                {
                    isIncome = false;
                }
                btnOutcomeTransactions.BackColor = Color.Pink;
                btnIncomeTransactions.BackColor = Color.Transparent;
                isOutcome = true;
                isIncome = false;
                Filter(true);
            }
            else
            {
                btnOutcomeTransactions.BackColor = Color.Transparent;
                btnIncomeTransactions.BackColor = Color.Transparent;
                isOutcome = false;
                Filter(false);
            }
            outcomeCounter++;
        }
    }
}