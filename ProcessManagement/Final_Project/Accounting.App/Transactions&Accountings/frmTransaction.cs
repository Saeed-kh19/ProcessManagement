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
    public partial class frmTransaction : Form
    {
        public int userId = 0;
        public int transactionId = 0;
        public frmTransaction()
        {
            InitializeComponent();
        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db1 = new UnitOfWork())
            {
                if (db1.LoginRepository.GetUserById(userId).Role == 1)
                {
                    if (transactionId == 0)
                    {
                        btnAdd.Text = "Add";
                    }
                    else
                    {
                        btnAdd.Text = "Save";
                    }
                    this.dgPersons.DefaultCellStyle.Font = new Font("MicrosoftSansSerif", 8);
                    this.dgPersons.RowHeadersDefaultCellStyle.Font = new Font("MicrosoftSansSerif", 8);
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        dgPersons.AutoGenerateColumns = false;
                        dgPersons.DataSource = db.AccountingRepository.GetAllPersons();
                    }
                    if (transactionId == 0)
                    {
                        this.Text = "Create new transaction";
                    }
                    else
                    {
                        this.Text = "Edit transaction";
                        using (UnitOfWork db = new UnitOfWork())
                        {
                            List<AccountPersons> listOfPersons = new List<AccountPersons>();
                            Transactions newTransaction = db.TransactionRepository.GetTransactionsById(transactionId);
                            txtAccountSide.Text = db.AccountingRepository.GetPersonNameById(newTransaction.PersonID);
                            txtAmount.Value = newTransaction.Amount;
                            txtDescription.Text = newTransaction.Description;
                            if (newTransaction.TypeID == 1)
                            {
                                rbRecieve.Checked = true;
                            }
                            else if (newTransaction.TypeID == 2)
                            {
                                rbPay.Checked = true;
                                rbPay.Checked = true;
                            }
                            dgPersons.Enabled = false;
                            listOfPersons.Add(db.TransactionRepository.GetPersonById(newTransaction.PersonID));
                            dgPersons.DataSource = listOfPersons;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Access Denied!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAccountSide.Text != "" && txtAmount.Value != 0 && (rbPay.Checked || rbRecieve.Checked))
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    Transactions transaction = new Transactions()
                    {
                        Amount = int.Parse(txtAmount.Value.ToString()),
                        PersonID = int.Parse(dgPersons.CurrentRow.Cells[0].Value.ToString()),
                        TypeID = (rbRecieve.Checked) ? 1 : 2,
                        DateTime = DateTime.Now,
                        Description = txtDescription.Text
                    };
                    if (transactionId == 0)
                    {
                        db.TransactionRepository.InsertTransaction(transaction);
                    }
                    else
                    {
                        transaction.TransactionID = transactionId;
                        db.TransactionRepository.UpdateTransaction(transaction);
                    }
                    db.Save();
                    MessageBox.Show("Transaction Saved!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                lblValidation.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgPersons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAccountSide.ForeColor = Color.Black;
            txtAccountSide.Text = dgPersons.CurrentRow.Cells[1].Value.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgPersons.DataSource = db.TransactionRepository.PersonFilter(txtSearch.Text);
            }
        }
    }
}
