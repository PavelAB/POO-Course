using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExercise.models
{
    delegate void MyCarWash(Car car);

    internal class CarWash
    {
        MyCarWash myCarWash = null;

        public List<Car> Cars { get; set; } = new List<Car>();
        public List<bool> IsBetterWash { get; set; } = new();

        public CarWash(List<Car> cars)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                Car car = cars[i];
                Cars.Add(car);
                IsBetterWash.Add(yesOrNo($"Better wash {car.RegNumber}? y/n"));
            }
        }

        private void GetReady(Car car)
        {
            Console.WriteLine($"je prépare la voiture : {car.RegNumber}");
        }
        private void Wash(Car car)
        {
            Console.WriteLine($"je lave la voiture : {car.RegNumber}");
        }
        private void Dry(Car car)
        {
            Console.WriteLine($"je sèche la voiture : {car.RegNumber}");
        }
        private void SpecialWash(Car car)
        {
            Console.WriteLine($"lavage intérieur : {car.RegNumber}");
        }
        private void Finish(Car car)
        {
            Console.WriteLine($"je finalise la voiture : {car.RegNumber}");
        }
        public void NewWash(bool isBetterWash)
        {
            myCarWash += GetReady;
            myCarWash += Wash;
            myCarWash += Dry;
            if (isBetterWash)
                myCarWash += SpecialWash;
            myCarWash += Finish;
        }
        public void StartWash()
        {

            
            for(int i = 0; i < Cars.Count; i++)
            {
                Car car = Cars[i];
                bool isBetterWash = IsBetterWash[i];
                NewWash(isBetterWash);
                myCarWash?.Invoke(car);
                myCarWash = null;
            }


        }

        private bool yesOrNo(string message)
        {

            char choice;
            do
            {

                Console.WriteLine(message);
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();


            } while (choice != 'y' && choice != 'n');

            if (choice == 'y')
                return true;
            return false;
        }

    }
}
