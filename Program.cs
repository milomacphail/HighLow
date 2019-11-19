using System;

namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            Card cardOne = new Card();
            Card cardTwo = new Card();
            Game game = new Game(cardOne, cardTwo);

        }
    }
}
