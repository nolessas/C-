using System;
using System.Collections.Generic;


namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> food = new List<string>();

            food.Add("pizza");
            food.Add("hamburger");
            food.Add("hotdog");
            food.Add("fries");

            //food.Remove("fries");
            //food.Insert(0, "sushi");
            //Console.WriteLine(food.Count);
            //Console.WriteLine(food.IndexOf("pizza"));
            //Console.WriteLine(food.LastIndexOf("pizza"));
            //Console.WriteLine(food.Contains("pizza"));
            //food.Sort();
            //food.Reverse();
            //food.Clear();
            //String[] foodArray = food.ToArray();

            foreach (string item in food)
            {
                Console.WriteLine(item); //Food[0]
            }
            Console.ReadKey();
        }
    }
}
