class Dealer : IPlayable{
    private Deck deck;
    private int handValue;
    public Deck Deck{get; set;}
    public int HandValue{get; set;}
     public Dealer(){
         //new deck
         this.ha
     }

    void Draw(){
       if(this.HandValue <= 16){

       }else{
           this.Hold();
       }
    }
    void Hold(){
       
    }

}