using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Course.models
{
    internal class Bank
    {
        private List<Account> _accounts = new();
        public string Name { get; set; }

        public Account? this[string number]
        {
            get
            {
                if (!IsAccount(number))
                    return null;
                Account accountToReturn = null;
                foreach(Account account in _accounts)
                {
                    if (account.Number == number)
                        accountToReturn = account;
                }
                return accountToReturn;
            }
        }


        private bool IsAccount(string accountNumber)
        {
            foreach (Account account in _accounts)
            {
                if (account.Number == accountNumber)
                    return true;
            }
            return false;
        }

        private bool IsAccount(Account newAccount)
        { 
            foreach(Account account in _accounts)
            {
                if (account.Number == newAccount.Number)
                    return true;
            }
            return false;
        }


        public void AddNewAccount(Account account)
        {
            if (IsAccount(account))
                return;
            
            _accounts.Add(account);
        }
        public void RemoveAccount(string number)
        {
            if (!IsAccount(number))
                return;

            Account? accountToDelete = null;
            foreach (Account account in _accounts)
            {
                if (account.Number == number)
                    accountToDelete = account;
            }

            if(accountToDelete != null)
                _accounts.Remove(accountToDelete);
                
        }

        public int NumbersOfAccount()
        {
            return _accounts.Count;
        }
        public double HavingAccounts(Person person)
        {
            List<Account> accounts = new();
            double sumBalance = 0d;

            foreach (Account account in _accounts)
            {
                if(account.Holder == person)
                {
                    accounts.Add(account);
                }
            }

            if (accounts.Count == 0)
                return 0d;

            foreach (Account account in accounts)
            {
                sumBalance = sumBalance + account;
            }

            return sumBalance;
        }
    }
}
