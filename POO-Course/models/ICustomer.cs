using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Course.models
{
    internal interface ICustomer
    {
        double Balance { get; }

        void NewDeposit(double amount);

        void NewWithdrawal(double amount);

    }
}
