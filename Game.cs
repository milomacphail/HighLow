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

            if (cardOneValue > cardTwoValue)
            {
                playerOneScore++;
                Console.WriteLine("Player One wins with {0} point.", playerOneScore);
            }
            else if (cardOneValue < cardTwoValue)
            {
                playerTwoScore++;
                Console.WriteLine("Player Two wins with {0} point.", playerTwoScore);
            }
            else
            {
                Console.WriteLine("No winners here.");
            }
        }
    }
}
