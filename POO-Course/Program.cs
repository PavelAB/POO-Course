using POO_Course.models;
using POO_Course.utils;
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

            Current firstAccount = new(
                "BE 789",
                600,
                new Person(
                    "John",
                    "Doe",
                    new DateOnly(1991, 11, 11)
                ));
            Current secondAccount = new(
                "BE 777",
                -900,
                bestPerson);

            bestPerson.DisplayPerson();

            Console.WriteLine(firstAccount.ToString());
            Console.WriteLine(secondAccount.ToString());
            firstAccount.NewWithdrawal(-500);
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

            Console.WriteLine("---------------------");

            #region Exercise 3
            Current thirdAccount = new(
                    "BE 890",
                    600,
                    bestPerson
                    );
            Current fourthAccount = new(
                "BE 891",
                600,
                bestPerson
                );

            bank.AddNewAccount(secondAccount);
            bank.AddNewAccount(thirdAccount);
            bank.AddNewAccount(fourthAccount);



            thirdAccount.NewDeposit(500);
            fourthAccount.NewDeposit(1800);

            Console.WriteLine(firstAccount.ToString());
            Console.WriteLine(secondAccount.ToString());
            Console.WriteLine(thirdAccount.ToString());
            Console.WriteLine(fourthAccount.ToString());


            Console.WriteLine($"Summ 1 + 2: {firstAccount + secondAccount}");
            Console.WriteLine($"Summ 2 + 3: {secondAccount + thirdAccount}");
            Console.WriteLine($"Summ 1 + 2 + 3: {firstAccount + secondAccount + thirdAccount}");

            Console.WriteLine($"BestPerson Balance: {bank.HavingAccounts(bestPerson)}");
            #endregion

            Console.WriteLine("-------------------");
            #region Exercise 4 

            Console.WriteLine($"NumbersOfAccount: {bank.NumbersOfAccount()}");

            Savings fifthAccount = new Savings(
                "BE 999",
                bestPerson
                );

            bank.AddNewAccount(fifthAccount);
            fifthAccount.NewDeposit(500);
            fifthAccount.NewWithdrawal(250);
            Console.WriteLine(fifthAccount.ToString());

            Console.WriteLine($"After = NumbersOfAccount: {bank.NumbersOfAccount()}");
            #endregion


            firstAccount.ApplyInterest();
            secondAccount.ApplyInterest();
            fifthAccount.ApplyInterest();

            Console.WriteLine(firstAccount.ToString());
            Console.WriteLine(secondAccount.ToString());
            Console.WriteLine(fifthAccount.ToString());


            Dice.Minimum = 5;
            Dice.Maximum = 15;

            Console.WriteLine($"Roll: {Dice.Roll()}");
            Console.WriteLine($"Roll: {Dice.ToString(8)}");


        }
    }
}
