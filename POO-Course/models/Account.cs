using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO_Course.utils;

namespace POO_Course.models
{
    internal abstract class Account
    {
		private double _Balance = 0d;
		
        public string Number { get; set; }
		public double Balance
		{
			get { return _Balance; }
		}
		public Person Holder { get; set; }
		protected void Withdrawal(double amount )
		{
			_Balance -= amount;
		}
        protected void Deposit(double amount)
		{
			_Balance += amount;
		}
        public override string ToString()
        {
			return $"- {Number},\n- {Balance} $,\n- Holder : {Holder.FullPersonInformation()}\n";
        }
        protected virtual bool WithdrawalPossible(double amount)
        {
            if (Balance - amount >= 0)
                return true;
            else
                return false;
        }
        public virtual void NewDeposit(double amount)
        {
            double amountToWithdrawal = Utils.PositiveAmount(amount);

			Deposit(amountToWithdrawal);
        }
		protected abstract double InterestCalculation();
		public void ApplyInterest()
		{
			_Balance += InterestCalculation();
		}
		public static double operator +(Account left, Account right)
		{
			double leftPart = left.Balance;
			double rightPart = right.Balance;
			if (leftPart < 0)
				leftPart = 0;
			if (rightPart < 0)
				rightPart = 0;


			return leftPart + rightPart;
		}
        public static double operator +(double left, Account right)
        {
            double rightPart = right.Balance;

            if (rightPart < 0)
                rightPart = 0;


            return left + rightPart;
        }

    }
}
