namespace hackathon
{
    
class Dealer : Person{
    private int handValue;
    public int HandValue{
        get;
        set;}
    
     public Dealer(){
         //new deck

        Reset();
     }

     public void Reset(){
         this.IsTurn = false;
        
     }

    public void Draw(Deck d){
       if(this.HandValue <= 16){
           Card c = d.Deal();
           this.HandValue += c.Val;
           System.Console.WriteLine(this.HandValue);
       }else{
           this.Hold();
       }
    }

    public void DrawTwo(Deck d){
        for(int i = 1; i<=2; i++){
            Card c = d.Deal();
            this.HandValue += c.Val;
        }
        System.Console.WriteLine(this.HandValue);
    }
    public void Hold(){
       this.IsTurn = false;
    }

}
}