namespace hackathon
{
    class Player : Person
    {
        public Player()
        {
            this.IsTurn = true;
            this.IsGame = false;
            this.HandValue = 0;
        }
        public void StartGame(Deck d)
        {
            System.Console.WriteLine("Do you want to play?");
            string j = System.Console.ReadLine();
            if (j == "y")
            {
                this.HandValue = 0;
                this.IsGame = true;
                for (int i = 0; i < 2; i++)
                {
                    Card c = d.Deal();
                    this.HandValue += c.Val;
                }
                //this.getInfo();
            }
            else
            {
                System.Console.WriteLine("Goodbye!");
            }
        }
        public void getInfo()
        {
            System.Console.WriteLine($"You are at {this.HandValue}");
        }
        public void Action(Deck deck)
        {
            this.getInfo();
            System.Console.WriteLine("hit or hold?");
            string s = System.Console.ReadLine();
            if (s == "hit")
            {
                Card c = deck.Deal();
                this.HandValue += c.Val;
            }
            else if (s == "hold")
            {
                System.Console.WriteLine("You hold");
                this.IsTurn = false;
                this.IsGame = false;
            }
            if (this.HandValue == 21)
            {
                System.Console.WriteLine("You won!");
            }
            else if (this.HandValue > 21)
            {
                System.Console.WriteLine($"Bust at {this.HandValue} \nGAME OVER");
                this.IsGame = false;
            }
        }
    }
}