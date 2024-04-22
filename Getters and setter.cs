using System;
using System.Collections.Generic;


namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(400);

            car.Speed = 100000;

            Console.WriteLine(car.Speed);



            Console.ReadKey();
        }
    }
    class Car
    {
        public int speed;

        public Car(int speed)
        {
            Speed = speed;
        }
        public int Speed
        {
            get { return speed; }  //read
            set                    //writable
            {   
                if(value >500)
                {
                    speed = 500;
                }
                else
                {
                    speed = value;
                }
            }
        }
    }
}
