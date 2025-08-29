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
        const double INTEREST_RATE = 0.045d;
        public DateTime? LastWithdrawal { get; private set; }
        public DateTime? LastDeposit {  get; private set; }

        public Savings(string number, Person holder): base(number, holder)
        {
            LastWithdrawal = null;
            LastDeposit = null;
        }

        public override void NewWithdrawal(double amount)
        {
            double amountToWithdrawal = Utils.PositiveAmount(amount);

            if (WithdrawalPossible(amountToWithdrawal))
            {
                Withdrawal(amountToWithdrawal);
                LastWithdrawal = DateTime.Now;
            } 
        }
        protected override double InterestCalculation()
        {
            return Balance * INTEREST_RATE;
        }
        public override void NewDeposit(double amount)
        {
            double amountToWithdrawal = Utils.PositiveAmount(amount);

            Deposit(amountToWithdrawal);
            LastDeposit = DateTime.Now;
        }
        public override string ToString()
        {
            return $"- {Number},\n- {Balance} $,\n- Last withdrawal date: {LastWithdrawal},\n- Last deposit date: {LastDeposit},\n- Holder : {Holder.FullPersonInformation()}\n";
        }
        

    }
}
