using deck;

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
            this.IsGame = true;
            for (int i = 0; i < 2; i++)
            {
                Card c = d.Deal();
                this.HandValue += c.Val;
                this.getInfo();
            }
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
    public void Action(string s, Deck d)
    {
        if (s == "hit")
        {
            Card c = d.Deal();
            this.HandValue += c.Val;
        }
        else if (s == "hold")
        {
            this.IsTurn = false;
            this.IsGame = false;
        }
        if (this.HandValue > 21)
        {
            System.Console.WriteLine("Bust! \n GAME OVER");
            this.HandValue = 0;
            this.IsGame = false;
        }
    }


}