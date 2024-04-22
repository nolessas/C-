using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 123;

            int y = 321;

            int z = x + y;

            int age = 21;
            double height = 300.1;
            bool alive = true;
            char symbol = '@';
            String name = "Joe";
            String userName = symbol + name;

            Console.WriteLine("Your name is " + name);
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your height is " + height + "cm");
            Console.WriteLine("Are you alive? " + alive);
            Console.WriteLine("Your simbol is " + symbol);
            Console.WriteLine("Your username is: " + userName);

            Console.ReadKey();

        }


    }
}
