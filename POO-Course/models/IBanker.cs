using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Course.models
{
    internal interface IBanker
    {
        public string Number { get; }
        public Person Holder { get; }

        public void ApplyInterest(); 
    }
}
