using System;

namespace Battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            GameBoard gb = new GameBoard();
            Console.Read();
            CloseUp();
        }

        public static void CloseUp()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
        }
    }
}