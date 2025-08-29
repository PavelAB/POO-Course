using POO_Course.models.Exeptions;
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
        public Savings(string number, Person holder, double amount) : this(number, holder)
        {
            NewDeposit(amount);
        }
        public override void NewWithdrawal(double amount)
        {
            EnsurePositiveAmount(amount);

            EnsureWithdrawalPossible(amount);

            Withdrawal(amount);

            LastWithdrawal = DateTime.Now;
        }
        protected override double InterestCalculation()
        {
            return Balance * INTEREST_RATE;
        }
        public override void NewDeposit(double amount)
        {
            EnsurePositiveAmount(amount);

            Deposit(amount);

            LastDeposit = DateTime.Now;
        }
        public override string ToString()
        {
            return $"- {Number},\n- {Balance} $,\n- Last withdrawal date: {LastWithdrawal},\n- Last deposit date: {LastDeposit},\n- Holder : {Holder.ToString()}\n";
        }
        

    }
}
