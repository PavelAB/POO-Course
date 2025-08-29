using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace POO_Course.models.Exeptions
{
    internal static class Guard
    {
        public static void NegativeNumberException(double number, string paramName)
        {
            if(number < 0)
            {
                throw new ArgumentOutOfRangeException(paramName, "Le nombre ne doit pas être négatif.");
            }
        }
    }
}
