using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //String[] cars = { "BMW", "Mustang", "Corvette" };
            //cars[1] = "Tesla"
            //Console.WriteLine(cars[0]);
            //Console.WriteLine(cars[1]);
            //Console.WriteLine(cars[2]);


            String[] cars = new string[3];
            cars[0] = "Tesla";
            cars[1] = "BMW";
            cars[2] = "Audi";



            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }


            Console.ReadKey();
        }
    }
}
