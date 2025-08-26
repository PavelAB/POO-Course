using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Course.models
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly BirthDate { get; set; }

        public Person(string firstName, string lastName, DateOnly birthDate) {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public string FullPersonInformation()
        {
            return $"{FirstName} {LastName} : {BirthDate}";
        }

        public void DisplayPerson()
        {
            Console.WriteLine($"{FirstName} {LastName} {BirthDate.ToString("dd/MM/yyyy")}");
        }
        public static bool operator ==(Person left, Person right)
        {
            if(left.FirstName == right.FirstName && left.LastName == right.LastName)
                return true;
            else 
                return false;
        }
        public static bool operator !=(Person left, Person right)
        {
            if (left.FirstName == right.FirstName && left.LastName == right.LastName)
                return false;
            else
                return true;
        }


    }
}
