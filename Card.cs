using System;
using System.Collections.Generic;
using System.Text;

namespace HighLow
{
    public class Card
    {
        public enum SuitValues { Clubs = 0, Diamonds = 1, Hearts = 2, Spades = 3 };
        public enum CardValues { Ace = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10, Jack = 11, Queen = 12, King = 13 };

        Array cardValues = Enum.GetValues(typeof(CardValues));
        Array suits = Enum.GetValues(typeof(SuitValues));
        CardValues randomCardValues = (CardValues)new Random().Next(1, 13);
        SuitValues randomSuitValue = (SuitValues)new Random().Next(0, 3);

        public int CardValue;
        public string CardSuit;

        public Card()
        {
            Random randomCardValue = new Random();
            this.CardValue = (int)randomCardValues;
            this.CardSuit = randomSuitValue.ToString();
        }

       /* public Card(int CardValue, int CardSuit)
        {
            this.CardValue = CardValue;
            this.CardSuit = randomSuitValue.ToString();
        }

        public Card(int CardValue)
        {
            this.CardValue = CardValue;
        }*/
    }
}
