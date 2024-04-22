using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperature = 20;

            Console.WriteLine((temperature >= 15) ? "Its Warm outside!" : "It's cold outside!");

            Console.ReadKey();
        }
    }
}