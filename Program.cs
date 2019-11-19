using System;

namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            Card cardOne = new Card();
            Console.WriteLine("{0} of {1}", cardOne.CardValue, cardOne.CardSuit);
            Card cardTwo = new Card();
            Console.WriteLine("{0} of {1}", cardTwo.CardValue, cardTwo.CardSuit);
            Game game = new Game(cardOne, cardTwo);

        }
    }
}
