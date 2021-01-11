namespace CardGames{
class PlayCard:Card {
     string Suit;
     string Number;
     public PlayCard(string suit , string number){
         this.Suit = suit;
         this.Number = number;
     }
        public override string NameValue()
        {
           return this.Number + " of "+this.Suit;
        }

    

}
}