using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 3.14;
            int b = Convert.ToInt32 (a);

            int c = 123;
            double d = Convert.ToDouble (c) + 0.1;

            int e = 321;
            string f = Convert.ToString (e);

            String g = "$";
            char h = Convert.ToChar (g);

            String i = "true";
            bool j = Convert.ToBoolean (i);

            Console.WriteLine(b.GetType());
            Console.WriteLine(b);
            Console.WriteLine(d.GetType());
            Console.WriteLine(d);
            Console.WriteLine(f.GetType());
            Console.WriteLine(f);
            Console.WriteLine(h.GetType());
            Console.WriteLine(h);
            Console.WriteLine(j.GetType());
            Console.WriteLine(j);

            Console.ReadKey();

        }


    }
}
