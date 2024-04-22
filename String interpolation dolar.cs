using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "John";
            string lastName = "Potter";
            int age = 21;

            //Console.WriteLine("Hello " + firstName + " " + lastName + ".");
            //Console.WriteLine("You are " + age + " years old.");

            Console.WriteLine($"Hello {firstName} {lastName}");
            Console.WriteLine($"You are {age,2} old.");
            
            Console.ReadKey();
        }
    }
}