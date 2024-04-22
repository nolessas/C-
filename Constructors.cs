using System;
using System.Xml.Linq;


namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("Rick", 65);
            Human human2 = new Human("Morty", 14);


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
///Constuctor
        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
///
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
