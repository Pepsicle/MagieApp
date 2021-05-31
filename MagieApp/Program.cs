using System;

namespace MagieApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int width = Int32.Parse(Console.ReadLine());
            Game game = new Game(4);

            game.StartGame();
        }
    }
}
