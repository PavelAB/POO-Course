using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO_Course.utils;

namespace POO_Course.models
{
    internal class Account
    {
        public string Number { get; set; }

		private double _Balance = 0d;

		public double Balance
		{
			get { return _Balance; }
		}

		private double _CreditLine;

		public double CreditLine
		{
			get { return _CreditLine; }
			set {
				if (value < 0)
					_CreditLine = 0d;
				else
					_CreditLine = value; 
			}
		}
		public Person Holder {  get; set; }

		public Account(string number, double creditLine, Person holder)
		{
			Number = number;
			CreditLine = creditLine;
			Holder = holder;
		}

		private void Withdrawal(double amount )
		{
			_Balance -= amount;
		}
		private void Deposit(double amount)
		{
			_Balance += amount;
		}
		public void DisplayAccount()
		{
			Console.WriteLine($"- {Number},\n- {Balance} $,\n- CreditLine: {CreditLine},\n- Holder : {Holder.FullPersonInformation()}\n");
        }
		private bool WithdrawalPossible(double amount) 
		{
			if (Balance - amount >= -CreditLine)
				return true;
			else
				return false;
		}
		public void NewWithdrawal(double amount)
		{
            double amountToWithdrawal = Utils.PositiveAmount(amount);

			if (WithdrawalPossible(amountToWithdrawal))
			{
                Withdrawal(amountToWithdrawal);
			}
		}
        public void NewDeposit(double amount)
        {
            double amountToWithdrawal = Utils.PositiveAmount(amount);

			Deposit(amountToWithdrawal);
        }

    }
}
