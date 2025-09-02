using DelegateExercise.models;

namespace DelegateExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Car car1 = new("BestCar");
            Car car2 = new("WorseCar");
            List<Car> cars = new List<Car>() { car1, car2};

            CarWash myCarWash = new CarWash(cars);



            myCarWash.StartWash();
        }
    }
}
