using POO_Course.models;
using System.Security.Cryptography.X509Certificates;

namespace POO_Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Bank Exercise 1
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
                    new DateOnly(1991, 11, 11)
                ));
            Account secondAccount = new Account(
                "BE 777",
                -900,
                bestPerson);

            bestPerson.DisplayPerson();

            firstAccount.DisplayAccount();
            firstAccount.NewWithdrawal(-500);
            secondAccount.DisplayAccount();
            secondAccount.NewDeposit(-1000); 
            #endregion


            Console.WriteLine("---------------------");


            #region Bank Exercise 2
            //firstAccount.DisplayAccount();
            //secondAccount.DisplayAccount();



            //Console.Clear();
            //Console.WriteLine("Banque");

            Bank bank = new Bank();
            bank.Name = "Belfius";
            Console.WriteLine($"Name: {bank.Name}");


            bank.AddNewAccount(firstAccount);
            //Account test = bank["BE 789"];
            //Console.WriteLine($"Account: ");
            //test.DisplayAccount();
            //Console.WriteLine($"NumbersOfAccount: {bank.NumbersOfAccount()}");
            //bank.RemoveAccount("BE 789");
            //Console.WriteLine($"After - NumbersOfAccount: {bank.NumbersOfAccount()}");
            #endregion

            Account thirdAccount = new Account(
                "BE 890",
                600,
                bestPerson
                );
            Account fourthAccount = new Account(
                "BE 891",
                600,
                bestPerson
                );

            bank.AddNewAccount(secondAccount);
            bank.AddNewAccount(thirdAccount);
            bank.AddNewAccount(fourthAccount);

            Console.WriteLine($"NumbersOfAccount: {bank.NumbersOfAccount()}");

            thirdAccount.NewDeposit(500);
            fourthAccount.NewDeposit(1800);

            firstAccount.DisplayAccount();
            secondAccount.DisplayAccount();
            thirdAccount.DisplayAccount();
            fourthAccount.DisplayAccount();

            Console.WriteLine($"Summ 1 + 2: {firstAccount + secondAccount}");
            Console.WriteLine($"Summ 2 + 3: {secondAccount + thirdAccount}");

            Console.WriteLine($"BestPerson Balance: {bank.HavingAccounts(bestPerson)}");




        }
    }
}
