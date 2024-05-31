using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.App
{
    public partial class frmAddOrEditPersons : Form
    {
        UnitOfWork db1 = new UnitOfWork();
        public int personId = 0;
        public frmAddOrEditPersons()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            btnSubmit.Text = "Submit";
            using (UnitOfWork db = new UnitOfWork())
            {
                if (txtFullname.Text != "" && txtPhoneNumber.Text != "" && txtEmailAddress.Text != "")
                {
                    AccountPersons person = new AccountPersons()
                    {
                        FullName = txtFullname.Text,
                        PhoneNumber = txtPhoneNumber.Text,
                        Email = txtEmailAddress.Text,
                        Address = txtAddress.Text
                    };
                    if (personId == 0)
                    {
                        db.AccountingRepository.InsertPerson(person);
                        MessageBox.Show("Person Added Successfully!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        btnSubmit.Text = "Save";
                        person.PersonID = personId;
                        db.AccountingRepository.UpdatePerson(person);
                    }
                    db.Save();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Please complete important fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmAddOrEditPersons_Load(object sender, EventArgs e)
        {
            this.txtFullname.AutoSize = false;
            this.txtPhoneNumber.AutoSize = false;
            this.txtEmailAddress.AutoSize = false;
            this.txtAddress.AutoSize = false;

            //checks whether we are in edit mode or add mode
            if (personId == 0)
            {
                this.Text = "Add new person";
            }
            else
            {
                this.Text = "Edit person";
                var person = db1.AccountingRepository.GetPersonById(personId);
                txtFullname.Text = person.FullName;
                txtPhoneNumber.Text = person.PhoneNumber;
                txtEmailAddress.Text = person.Email;
                txtAddress.Text = person.Address;
            }
        }
    }
}