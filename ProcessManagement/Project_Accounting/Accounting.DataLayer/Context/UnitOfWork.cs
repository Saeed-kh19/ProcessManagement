using Accounting.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        //IDisposable imports dispose
        //unit of work is a model for dependecy injection

        //creating context
        Accounting_DBEntities db = new Accounting_DBEntities();

        //for encapsulation we make our variable private and then set value for it in a get method from a public Functions!
        private IAccountingRepository _usersRepository;

        //Creating a property as repository for Users
        public IAccountingRepository UsersRepository
        {
            get
            {
                //if repository not created , create and if its not created create a new one!
                if (_usersRepository == null)
                {
                    _usersRepository = new AccountingRepository(db);
                }
                return _usersRepository;
            }
        }

        private IAccountingRepository _accountingRepository;

        //Creating a property as repository for Accounting
        public IAccountingRepository AccountingRepository
        {
            get
            {
                if (_accountingRepository == null)
                {
                    _accountingRepository = new AccountingRepository(db);
                }
                return _accountingRepository;
            }
        }

        private IAccountingRepository _transactionRepository;

        //Creating a property as repository for Transactions!
        public IAccountingRepository TransactionRepository
        {
            get
            {
                if (_transactionRepository == null)
                {
                    _transactionRepository = new AccountingRepository(db);
                }
                return _transactionRepository;
            }
        }

        public IAccountingRepository _loginRepository;

        //Creating a property as repository for Logins!
        public IAccountingRepository LoginRepository
        {
            get
            {
                if (_loginRepository == null)
                {
                    _loginRepository = new AccountingRepository(db);
                }
                return _loginRepository;
            }
        }

        private GenericRepository<Users> _loginGenericRepository;

        //Creating a GenericRepository for Logins ( it acts like LoginRepository but with generics! :)))) )
        public GenericRepository<Users> LoginGenericRepository
        {
            get
            {
                if (_loginRepository == null)
                {
                    _loginGenericRepository = new GenericRepository<Users>(db);
                }
                return _loginGenericRepository;
            }
        }

        private GenericRepository<Transactions> _transactionsGenericRepository;

        //Creating a GenericRepository for Transactions ( it acts like TransactionsRepository but with generics! :)))) )
        public GenericRepository<Transactions> TransactionsGenericRepository
        {
            get
            {
                if (_transactionsGenericRepository == null)
                {
                    _transactionsGenericRepository = new GenericRepository<Transactions>(db);
                }
                return _transactionsGenericRepository;
            }
        }

        //clear memory dedicated to context
        public void Dispose()
        {
            db.Dispose();
        }

        //Save changes in database! :)
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
