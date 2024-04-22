using System;
using System.Xml.Linq;


namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human(());
            Human human2 = new Human();

            human1.name = "Rick";
            human1.age = 65;

            human2.name = "Morty";
            human2.age = 14;

            human1.Eat();
            human1.Sleep();

            human2.Eat();
            human2.Sleep();

            Console.ReadKey();
        }
    }
    class Human
    { 
        public String name;
        public int age;

        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }
        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
    }    
}
