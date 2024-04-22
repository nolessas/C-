using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            String[] stringArray = { "1", "2", "3" };

            
            DisplayElement(intArray);
            DisplayElement(doubleArray);
            DisplayElement(stringArray);

            Console.ReadKey();
        }

        
        //public static void DisplayElement(int[] array)
        //{
        //    foreach (int item in array)
        //    {
        //        Console.Write(item + " ");
        //    }
        //    Console.WriteLine();
        //}
        //public static void DisplayElement(double[] array)
        //{
        //    foreach (double item in array)
        //    {
        //        Console.Write(item + " ");
        //    }
        //    Console.WriteLine();
        //}
        public static void DisplayElement<Thing>(Thing[] array)
        {
            foreach (Thing item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
