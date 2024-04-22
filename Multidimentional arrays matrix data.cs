using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] ford = { "Mustang", "F-150", "Explorer" };
            String[] chevy = { "Corvette", "Camaro", "Silverado" };
            String[] toyoya = { "Corolla", "Camry", "Rav4" };

            String[,] parkingLot = {{"Mustang", "F-150", "Explorer"},
                                    {"Corvette","Camaro","Silverado"},
                                    {"Corolla","Camry","Rav4"}
                                   };

            parkingLot[0, 2] = "Fusion";
            parkingLot[2, 0] = "Tacoma";

            /*
            foreach (string car in parkingLot)
            {
                Console.WriteLine(car);
            }
            */

            for(int i = 0; i < parkingLot.GetLength(0); i++)
            {
                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.Write(parkingLot[i, j] + " ");
                }
                Console.WriteLine();
            }   

            Console.ReadKey();
        }
    }
}