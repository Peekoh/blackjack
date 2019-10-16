using System;
using System.Collections.Generic;

namespace deck 
{
    class Deck
    {
        public List<Card> Cards;
        public Deck()
        {
            Reset();
        }

        public Card Deal() 
        {
            Card dealt = Cards[0];
            Cards.RemoveAt(0);
            return dealt;
        }

        public void Reset()
        {
            Cards = GenerateCards();
        }

        public void Shuffle()
        {
            Random rand = new Random();
            for(int i = 0; i<this.Cards.Count; i++)
            {
                int s = rand.Next(this.Cards.Count-1);
                Card temp = this.Cards[i];
                this.Cards[i] = this.Cards[s];
                this.Cards[s] = temp;
            }
        }

        public List<Card> GenerateCards()
        {
            string suit = "";
            string special = "";
            List<Card> newDeck = new List<Card>();
            for(int i = 1; i<=13; i++) 
            {
                for(int j = 1; j<=4; j++)
                {
                    special = i.ToString();
                    if(j==1)
                    {
                        suit = "Clubs";
                    }
                    if(j==2)
                    {
                        suit = "Spades";
                    }
                    if(j==3)
                    {
                        suit = "Hearts";
                    }
                    if(j==4)
                    {
                        suit = "Diamonds";
                    }
                    if(i==1)
                    {
                        special = "Ace";
                        newDeck.Add(new Card(special, suit, i));
                    }
                    if(i==11)
                    {
                        special = "Jack";
                        newDeck.Add(new Card(special, suit, i));
                    }
                    if(i==12)
                    {
                        special = "Queen";
                        newDeck.Add(new Card(special, suit, i));
                    }
                    if(i==13)
                    {
                        special = "King";
                        newDeck.Add(new Card(special, suit, i));
                    }
                    if(special.Length < 3)
                    {
                        special = i.ToString();
                        newDeck.Add(new Card(special, suit, i));
                    }
                }
            }
            return newDeck;
        }
    }
}