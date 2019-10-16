using deck;

class Player : Person
{
    public Player()
    {
        //new deck
        this.HandValue = 0;
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

        }
        if(this.HandValue )
    }


}