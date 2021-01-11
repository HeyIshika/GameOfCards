using System;
using System.Collections.Generic;

namespace CardGames
{
    class Deck : ICardGameBehaviour
    {
        List<PlayCard> DeckOfCards { get; set; }
        private readonly string[] Suits = new string[]
        {

            "Clubs",
            "Hearts",
            "Spades",
            "Diamond"

        };



        public int Count()

        {

            return DeckOfCards.Count;

        }

        public Deck()

        {

            DeckOfCards = FillTheDeck();

        }



        private List<PlayCard> FillTheDeck()

        {

            List<PlayCard> deckOfCards = new List<PlayCard>();

            foreach (string suit in Suits)

            {

                for (int i = 1; i <= 13; i++)

                {

                    string tempValue = CreateCardValue(i);

                    PlayCard card = new PlayCard(suit, tempValue);

                    deckOfCards.Add(card);

                }

            }

            return deckOfCards;

        }

        private string CreateCardValue(int number)

        {

            return number switch

            {

                11 => "Jack",

                12 => "Queen",

                13 => "King",

                1 => "Ace",

                _ => number.ToString(),

            };

        }



        public Card Play()

        {

            Shuffle();

            PlayCard card = DeckOfCards[0];

            DeckOfCards.Remove(card);



            return card;

        }



        public void Shuffle()

        {

            Random rng = new Random();

            int n = DeckOfCards.Count - 1;

            while (n > 0)

            {

                int k = rng.Next(n + 1);

                PlayCard value = DeckOfCards[k];

                DeckOfCards[k] = DeckOfCards[n];

                DeckOfCards[n] = value;

                n--;

            }

        }



        public void Restart()

        {

            DeckOfCards = FillTheDeck();

            Shuffle();

        }

        public void PrintTheDeck()

        {

            foreach (Card card in DeckOfCards)

            {

                Console.WriteLine(card.NameValue());

            }

        }

    }

}

