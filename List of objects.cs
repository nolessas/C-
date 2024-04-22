using System;
using System.Collections.Generic;


namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();


            players.Add(new Player("Chad"));
            players.Add(new Player("Erick"));
            players.Add(new Player("Joe"));

            foreach(Player player in players)
            {
                Console.WriteLine(player);
            }


            Console.ReadKey();
        }
    }
    class Player
    {
        public String username;

        public Player(String username)
        {
            this.username = username;
        }
        public override string ToString()
        {
            return username;
        }
    }
}
