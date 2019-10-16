using System;

namespace hackathon
{
    class Program
    {
        static void Main(string[] args)
        {
           Deck d = new Deck();
           Player p = new Player();
           Dealer dean = new Dealer();
           d.Shuffle();
           p.StartGame(d);

           while(p.IsGame){
               if(p.IsTurn == true){
                  p.Action(d);
                //  p.IsTurn = false;
               }else{
                //dean.Draw(d);
               }
           }
           if(p.HandValue > dean.HandValue && p.HandValue <=21){
               System.Console.WriteLine($"You Won!Your Hand: {p.HandValue} \nDealers Hand: {dean.HandValue}");
           }else if (p.HandValue < dean.HandValue && p.HandValue <=21){
                 System.Console.WriteLine($"You Lost!Your Hand: {p.HandValue} \nDealers Hand: {dean.HandValue}");
           } else if(p.HandValue == dean.HandValue && p.HandValue <=21){
                 System.Console.WriteLine($"Draw!Your Hand: {p.HandValue} \nDealers Hand: {dean.HandValue}");

            }
           }

                 }
    }

