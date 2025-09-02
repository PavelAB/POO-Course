using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExercise.models
{
    internal class Car
    {
        public string RegNumber {  get; private set; }

        public Car(string regNumber)
        {
            RegNumber = regNumber;
        }
    }
}
