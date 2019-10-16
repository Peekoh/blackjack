using System;
using System.Collections.Generic;

namespace deck
{
    class Card
    {
        private string stringVal;
        private string suit;
        private int val;
        public Card(string stringVal, string suit, int val)
        {
            this.stringVal = stringVal;
            this.suit = suit;
            this.val = val;
        }

        public string StringVal
        {
            get
            {
                return this.stringVal;
            }
        }

        public string Suit
        {
            get
            {
                return this.suit;
            }
        }

        public int Val
        {
            get
            {
                return this.val;
            }
        }
    }
}