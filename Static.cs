using System;
using System.Xml.Linq;


namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car("Ford");
            Car car2 = new Car("Chevy");
            Car car3 = new Car("Lambo");

            Console.WriteLine(Car.numberOfCars);

            Car.StartRace();

            Console.ReadKey();
        }
    }
    class Car
    {
        String model;
        public static int numberOfCars;

        public Car(string model)
        {
            this.model = model;
            numberOfCars++;
        }
        public static void StartRace()
        {
            Console.WriteLine("The race has began");
        }
    }
}

