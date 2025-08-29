using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Course.models.Exeptions
{
    internal class WithdrawalException: Exception
    {
        public WithdrawalException(string message):base(message) { }
    }
}
