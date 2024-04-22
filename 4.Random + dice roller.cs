using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            while (true) 
            {
                Console.WriteLine("Do you want to roll the dice? (Y/N)");
                string userInput = Console.ReadLine().Trim().ToLower(); 
                if (userInput == "y")
                {
                    int num = random.Next(1, 7); //  1 to 6
                    Console.WriteLine("You rolled: " + num);
                }
                else if (userInput == "n")
                {
                    Console.WriteLine("Thank you for playing. Goodbye!");
                    break; 
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter 'yes' or 'no'.");
                }
            }

            Console.ReadKey();
        }
    }
}










//using System;

//namespace MyFirstProgram
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Random random = new Random();

//            int num = random.Next(1,7);

//            Console.WriteLine(num);

//            Console.ReadKey();

//        }


//    }
//}
