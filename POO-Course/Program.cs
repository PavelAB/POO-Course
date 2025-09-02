using POO_Course.models;
using POO_Course.models.Exeptions;
using POO_Course.utils;
using System.Security.Cryptography.X509Certificates;

namespace POO_Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    #region Bank Exercise 1
        //    Console.WriteLine("Hello, World!");
        //    Person bestPerson = new Person(
        //            "BestPerson",
        //            "Smith",
        //            new DateOnly(2000, 6, 11)
        //        );

        //    Current firstAccount = new(
        //        "BE 789",
        //        600,
        //        new Person(
        //            "John",
        //            "Doe",
        //            new DateOnly(1991, 11, 11)
        //        ));
        //    Current secondAccount = new(
        //        "BE 777",
        //        -900,
        //        bestPerson);

        //    bestPerson.DisplayPerson();

        //    Console.WriteLine(firstAccount.ToString());
        //    Console.WriteLine(secondAccount.ToString());
        //    firstAccount.NewWithdrawal(-500);
        //    secondAccount.NewDeposit(-1000);
        //    #endregion


        //    Console.WriteLine("---------------------");


        //    #region Bank Exercise 2
        //    //firstAccount.DisplayAccount();
        //    //secondAccount.DisplayAccount();



        //    //Console.Clear();
        //    //Console.WriteLine("Banque");

        //    Bank bank = new Bank();
        //    bank.Name = "Belfius";
        //    Console.WriteLine($"Name: {bank.Name}");


        //    bank.AddNewAccount(firstAccount);
        //    //Account test = bank["BE 789"];
        //    //Console.WriteLine($"Account: ");
        //    //test.DisplayAccount();
        //    //Console.WriteLine($"NumbersOfAccount: {bank.NumbersOfAccount()}");
        //    //bank.RemoveAccount("BE 789");
        //    //Console.WriteLine($"After - NumbersOfAccount: {bank.NumbersOfAccount()}");
        //    #endregion

        //    Console.WriteLine("---------------------");

        //    #region Exercise 3
        //    Current thirdAccount = new(
        //            "BE 890",
        //            600,
        //            bestPerson
        //            );
        //    Current fourthAccount = new(
        //        "BE 891",
        //        600,
        //        bestPerson
        //        );

        //    bank.AddNewAccount(secondAccount);
        //    bank.AddNewAccount(thirdAccount);
        //    bank.AddNewAccount(fourthAccount);



        //    thirdAccount.NewDeposit(500);
        //    fourthAccount.NewDeposit(1800);

        //    Console.WriteLine(firstAccount.ToString());
        //    Console.WriteLine(secondAccount.ToString());
        //    Console.WriteLine(thirdAccount.ToString());
        //    Console.WriteLine(fourthAccount.ToString());


        //    Console.WriteLine($"Summ 1 + 2: {firstAccount + secondAccount}");
        //    Console.WriteLine($"Summ 2 + 3: {secondAccount + thirdAccount}");
        //    Console.WriteLine($"Summ 1 + 2 + 3: {firstAccount + secondAccount + thirdAccount}");

        //    Console.WriteLine($"BestPerson Balance: {bank.HavingAccounts(bestPerson)}");
        //    #endregion

        //    Console.WriteLine("-------------------");
        //    #region Exercise 4 

        //    Console.WriteLine($"NumbersOfAccount: {bank.NumbersOfAccount()}");

        //    Savings fifthAccount = new Savings(
        //        "BE 999",
        //        bestPerson
        //        );

        //    bank.AddNewAccount(fifthAccount);
        //    fifthAccount.NewDeposit(500);
        //    fifthAccount.NewWithdrawal(250);
        //    Console.WriteLine(fifthAccount.ToString());

        //    Console.WriteLine($"After = NumbersOfAccount: {bank.NumbersOfAccount()}");
        //    #endregion
        //    Console.WriteLine("-------------------");

        //    #region Exercise 5
        //    firstAccount.ApplyInterest();
        //    secondAccount.ApplyInterest();
        //    fifthAccount.ApplyInterest();

        //    Console.WriteLine(firstAccount.ToString());
        //    Console.WriteLine(secondAccount.ToString());
        //    Console.WriteLine(fifthAccount.ToString()); 
        //    #endregion

        //    Console.WriteLine("-------------------");


        //    //Dice.Minimum = 5;
        //    //Dice.Maximum = 15;

        //    //Console.WriteLine($"Roll: {Dice.Roll()}");
        //    //Console.WriteLine($"Roll: {Dice.ToString(8)}");



        //    #region Exercise 6: Interfaces
        //    Console.WriteLine(firstAccount.ToString());
        //    firstAccount.NewWithdrawal(100);
        //    Console.WriteLine(firstAccount.ToString());
        //    #endregion

            Console.WriteLine("-------------------");

            #region Exercise 7: Constructors
            try
            {
                Person bestPerson = new Person(
                            "BestPerson",
                            "Smith",
                            new DateOnly(2000, 6, 11)
                        );
                Person worsePerson = new Person(
                            "WorstPerson",
                            "Evil",
                            new DateOnly(1990, 6, 6)
                        );

                Bank bank = new Bank();
                bank.Name = "Belfius";
                Console.WriteLine($"Name: {bank.Name}");

                Savings account1 = new Savings("BE 111", bestPerson, 10_000);
                Current account2 = new Current("BE 112", 1_000, bestPerson);
                Current account3 = new Current("BE 113", 10_000, worsePerson);

                bank.AddNewAccount(account1);
                bank.AddNewAccount(account2);
                bank.AddNewAccount(account3);


                Console.WriteLine($"Acconut 1: {account1}");
                Console.WriteLine($"Acconut 2: {account2}");
                //account2.NewWithdrawal(10_000);
                account3.NewWithdrawal(3_000);
                Console.WriteLine($"Acconut 3: {account3}");

            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"{e.Message}");
                
            }
            catch (WithdrawalException e)
            {
                Console.WriteLine($"{e.Message}");
            }
            #endregion



        }
    }
}
