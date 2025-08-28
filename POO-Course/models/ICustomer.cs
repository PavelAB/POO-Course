using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Course.models
{
    internal interface ICustomer
    {
        public double Balance { get; }

        public void NewDeposit(double amount);

        public void NewWithdrawal(double amount);

    }
}
