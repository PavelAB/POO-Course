using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Course.models
{
    internal interface IBanker: ICustomer
    {
        string Number { get; }
        Person Holder { get; }
        void ApplyInterest(); 
    }
}
