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


        //context
        Accounting_DBEntities db = new Accounting_DBEntities();

        private IAccountingRepository _usersRepository;

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

        //clear memroy dedicated to context
        public void Dispose()
        {
            db.Dispose();
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
