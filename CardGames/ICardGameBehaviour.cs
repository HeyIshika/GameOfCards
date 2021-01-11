namespace CardGames
{
    interface ICardGameBehaviour
    {
        Card Play();
        void Shuffle();
        void Restart();
    }

}