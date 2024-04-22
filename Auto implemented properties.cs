using System;



namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car("Prosche");

            Console.WriteLine(car.Model);

            Console.ReadKey();
        }
        
    }
    class Car
    {
        public String Model { get; set; }
        public Car(String model)
        {
            this.Model = model;
        }
    }
}
