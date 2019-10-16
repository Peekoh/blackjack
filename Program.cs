using System;

namespace hackathon
{
    class Program
    {
        static void Main(string[] args)
        {
           Deck d = new Deck();
           Player p = new Player();
           p.StartGame(d);

                 }
    }
}
