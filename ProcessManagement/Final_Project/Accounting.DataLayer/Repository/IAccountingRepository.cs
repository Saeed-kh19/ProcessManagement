using Accounting.ViewModels;
using Accounting.ViewModels.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer
{
    public interface IAccountingRepository
    {
        List<Users> GetAllUsers();
        List<AccountPersons> GetAllPersons();
        List<ListPersonsViewModel> GetAllPersonsNames(string filter);
        List<Transactions> GetAllTransactions();
        List<int> GetAllTransactionIdsByPersonId(int personId);
        List<SettingsViewModel> GetAllUsersNames();
        List<Transactions> GetIncomeTransactions();
        List<Transactions> GetOutcomeTransactions();
        string GetPersonNameById(int id);
        bool UpdateCredentials(Users user);
        bool InsertPerson(AccountPersons person);
        bool UpdatePerson(AccountPersons person);
        bool DeletePerson(AccountPersons person);
        bool DeletePerson(int personId);
        bool InsertTransaction(Transactions transaction);
        bool UpdateTransaction(Transactions transaction);
        bool DeleteTransaction(Transactions transactions);
        bool DeleteTransaction(int transactionId);
        List<AccountPersons> PersonFilter(string filter);
        AccountPersons GetPersonById(int id);
        Transactions GetTransactionsById(int id);
        Users GetUserById(int id);
        bool UpdateUser(Users user);
    }
}
