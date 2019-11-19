using System;
using System.Collections.Generic;
using System.Text;

namespace HighLow
{
    class Game
    {
        public Game(Card cardOne, Card cardTwo)
        {
            int cardOneValue = cardOne.CardValue;
            int cardTwoValue = cardTwo.CardValue;
            int playerOneScore = 0;
            int playerTwoScore = 0;

            Console.WriteLine("{0} of {1}", cardOne.CardValue, cardOne.CardSuit);
            Console.WriteLine("Guess high or low: ");
            string input = Console.ReadLine();

            if (input.ToLower() != "high" || input.ToLower() != "low")
            {
                Console.WriteLine("Please guess high or low: ");
            }

            if (cardOneValue > cardTwoValue && input == "high" || cardOneValue < cardTwoValue && input == "low")
            {
                Console.WriteLine("{0} of {1}", cardTwo.CardValue, cardTwo.CardSuit);
                playerOneScore++;
                Console.WriteLine("Player One wins with {0} point.", playerOneScore);
            }
            else if (cardOneValue < cardTwoValue && input == "high" || cardOneValue > cardTwoValue && input == "low")
            {
                Console.WriteLine("{0} of {1}", cardTwo.CardValue, cardTwo.CardSuit);
                playerTwoScore++;
                Console.WriteLine("Player Two wins with {0} point.", playerTwoScore);
            }
            else
            {
                Console.WriteLine("No winners here. Redrawing.");
                Card newCard = new Card();
                cardTwo = newCard;
            }
        }
    }
}
