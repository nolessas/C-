using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] cars = { "BMW", "Mustang", "Corvette" };

            //for (int i = 0; i <cars.Length; i++)
            //{
            //    Console.WriteLine(cars[i]);
            //}

            foreach (String car in cars)
            {
                Console.WriteLine(car);
            }

            Console.ReadKey();
        }
    }
}




