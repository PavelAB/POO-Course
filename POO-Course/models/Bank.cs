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
                if (!AccountExists(number))
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


        private bool AccountExists(string accountNumber)
        {
            foreach (Account account in _accounts)
            {
                if (account.Number == accountNumber)
                    return true;
            }
            return false;
        }

        private bool AccountExists(Account newAccount)
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
            if (AccountExists(account))
                return;
            
            _accounts.Add(account);
            account.NegativeLimitPassed += PassedToNegativeAction;
        }
        public void RemoveAccount(string number)
        {
            if (!AccountExists(number))
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

        public void PassedToNegativeAction(Account account)
        {
            Console.WriteLine($"Le compte {account.Number} vient de passer en negatif");
        }

        public int NumberOfAccounts()
        {
            return _accounts.Count;
        }
        public double GetTotalBalance(Person person)
        {
            List<Account> accounts = new();            

            foreach (Account account in _accounts)
            {
                if(account.Holder == person)
                {
                    accounts.Add(account);
                }
            }

            return SumOfBalance(accounts);
            
        }
        private double SumOfBalance(List<Account> accounts)
        {
            double sumBalance = 0d;

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
