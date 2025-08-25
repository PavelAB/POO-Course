using POO_Course.models;
using System.Security.Cryptography.X509Certificates;

namespace POO_Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Person bestPerson = new Person(
                    "BestPerson",
                    "Smith",
                    new DateOnly(2000, 6, 11)
                );

            Account firstAccount = new Account(
                "BE 789", 
                600, 
                new Person(
                    "John", 
                    "Doe", 
                    new DateOnly(1991, 11, 11 )
                ));
            Account secondAccount = new Account(
                "BE 777",
                -900,
                bestPerson );

            bestPerson.DisplayPerson();

            firstAccount.DisplayAccount();
            firstAccount.NewWithdrawal(-500);
            secondAccount.DisplayAccount();
            secondAccount.NewDeposit(-1000);
            Console.WriteLine("---------------------");
            firstAccount.DisplayAccount();
            secondAccount.DisplayAccount();
        }    
    }
}
