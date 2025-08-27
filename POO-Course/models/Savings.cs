using POO_Course.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Course.models
{
    internal class Savings : Account
    {
        public DateTime LastWithdrawal { get; set; }
        public DateTime LastDeposit {  get; set; }

        public Savings(string number, Person holder)
        {
            Number = number;
            Holder = holder;
        }

        public void NewWithdrawal(double amount)
        {
            double amountToWithdrawal = Utils.PositiveAmount(amount);

            if (WithdrawalPossible(amountToWithdrawal))
            {
                Withdrawal(amountToWithdrawal);
                LastWithdrawal = DateTime.Now;
            }
        }
        public override void NewDeposit(double amount)
        {
            double amountToWithdrawal = Utils.PositiveAmount(amount);

            Deposit(amountToWithdrawal);
            LastDeposit = DateTime.Now;
        }
        public override void DisplayAccount()
        {
            Console.WriteLine($"- {Number},\n- {Balance} $,\n- Last withdrawal date: {LastWithdrawal},\n- Last deposit date: {LastDeposit},\n- Holder : {Holder.FullPersonInformation()}\n");
        }

    }
}
