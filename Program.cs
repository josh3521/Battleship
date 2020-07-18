using System;

namespace Battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.CursorVisible = false;
            GameBoard gb = new GameBoard();
            Console.Read();
            CloseUp();
        }

        public static void CloseUp()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.CursorVisible = true;
        }
    }
}