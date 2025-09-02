using POO_Course.models.Exeptions;
using POO_Course.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Course.models
{
    internal class Current: Account
    {
        const double INTEREST_RATE = 0.03d;
        const double INTEREST_NEGATIF_RATE = 0.0975d;
        private double _CreditLine;


        public double CreditLine
        {
            get { return _CreditLine; }
            set
            {
                if (value < 0)
                    _CreditLine = 0d;
                else
                    _CreditLine = value;
            }
        }

        public Current(string number, double creditLine, Person holder) : base(number, holder)
        {
            CreditLine = creditLine;
        }
        public Current(string number, double creditLine, Person holder, double amount) : this(number, creditLine, holder)
        {
            NewDeposit(amount);
        }
        protected override void EnsureWithdrawalPossible(double amount)
        {            
            if (Balance - amount < - CreditLine)
                throw new WithdrawalException("Le retrait ne doit pas dépasser le solde du compte.");
        }        
        protected override double InterestCalculation()
        {
            if(Balance > 0)
                return Balance * INTEREST_RATE;
            else
                return Balance * INTEREST_NEGATIF_RATE;
        }

        public override void NewWithdrawal(double amount)
        {
            EnsurePositiveAmount(amount);

            EnsureWithdrawalPossible(amount);

            Withdrawal(amount);

            if(Balance < 0)
                base.PassedToNegative(this);
        }
        public override string ToString()
        {
            return $"- {Number},\n- {Balance} $,\n- CreditLine: {CreditLine},\n- Holder : {Holder.ToString()}\n";
        }
    }
}
