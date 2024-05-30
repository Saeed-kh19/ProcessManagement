using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.ViewModels;
using Accounting.ViewModels.Persons;

namespace Accounting.DataLayer.Services
{
    public class AccountingRepository : IAccountingRepository
    {
        //for dependency injection
        private Accounting_DBEntities db;
        
        public AccountingRepository(Accounting_DBEntities context)
        {
            db = context;
        }

        public List<AccountPersons> GetAllPersons()
        {
            return db.AccountPersons.ToList();
        }

        public AccountPersons GetPersonById(int id)
        {
            return db.AccountPersons.Find(id);
        }

        public bool DeletePerson(AccountPersons person)
        {
            try
            {
                db.Entry(person).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeletePerson(int personId)
        {
            try
            {
                AccountPersons person = GetPersonById(personId);
                DeletePerson(person);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateCredentials(Users user)
        {
            var local = db.Set<Users>().Local.FirstOrDefault(f => f.UserID == user.UserID);
            if (local != null)
            {
                db.Entry(user).State = EntityState.Detached;
            }
            db.Entry(user).State = EntityState.Modified;
            return true;
        }

        public string GetPersonNameById(int id)
        {
            return db.AccountPersons.Find(id).FullName;
        }

        public bool InsertPerson(AccountPersons person)
        {
            try
            {
                db.AccountPersons.Add(person);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdatePerson(AccountPersons person)
        {
            try
            {
                db.Entry(person).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<AccountPersons> PersonFilter(string filter)
        {
            return db.AccountPersons.Where(l => l.FullName.Contains(filter) || l.PhoneNumber.Contains(filter) || l.Email.Contains(filter)).ToList();
        }

        public List<ListPersonsViewModel> GetAllPersonsNames(string filter)
        {
            if (filter == "")
            {
                return db.AccountPersons.Select(p => new ListPersonsViewModel()
                {
                    PersonID = p.PersonID,
                    PersonFullName = p.FullName
                }).ToList();
            }
            else
            {
                return db.AccountPersons.Where(p => p.FullName.Contains(filter)).Select(p => new ListPersonsViewModel()
                {
                    PersonID = p.PersonID,
                    PersonFullName = p.FullName
                }).ToList();
            }
        }

        public bool InsertTransaction(Transactions transaction)
        {
            try
            {
                db.Transactions.Add(transaction);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Transactions> GetAllTransactions()
        {
            return db.Transactions.ToList();
        }

        public bool DeleteTransaction(Transactions transactions)
        {
            try
            {
                db.Entry(transactions).State = EntityState.Detached;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteTransaction(int transactionId)
        {
            try
            {
                Transactions transaction = GetTransactionsById(transactionId);
                DeleteTransaction(transaction);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Transactions GetTransactionsById(int id)
        {
            return db.Transactions.Find(id);
        }

        public AccountPersons GetPersonId(int id)
        {
            return db.AccountPersons.Find(id);
        }

        public bool UpdateTransaction(Transactions transaction)
        {
            try
            {
                db.Entry(transaction).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Transactions> GetIncomeTransactions()
        {
            return db.Transactions.Where(t => t.TypeID == 1).ToList();
        }

        public List<Transactions> GetOutcomeTransactions()
        {
            return db.Transactions.Where(t => t.TypeID == 2).ToList();
        }

        public List<Users> GetAllUsers()
        {
            return db.Users.ToList();
        }

        public Users GetUserById(int id)
        {
            return db.Users.Find(id);
        }

        public List<SettingsViewModel> GetAllUsersNames()
        {
            return db.Users.Select(p => new SettingsViewModel()
            {
                UserID = p.UserID,
                Name = p.Name
            }).ToList();
        }

        public bool UpdateUser(Users user)
        {
            try
            {
                db.Entry(user).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<int> GetAllTransactionIdsByPersonId(int personId)
        {
            return db.Transactions.Where(t => t.PersonID == personId).Select(t => t.TransactionID).ToList();
        }
    }
}