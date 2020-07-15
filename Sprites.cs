using System;

namespace Battleship
{
    public static class Sprites
    {
        // Container for static methods that draw the game's sprites to the screen.

        public static void DrawBlankScreen(int x, int y)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            for (int i = 0; i < 48; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write("                                                \n");
            }
        }

        public static void DrawTitle(int x, int y)
        {
            Console.BackgroundColor = System.ConsoleColor.DarkBlue;
            Console.ForegroundColor = System.ConsoleColor.White;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(".______        ___   .___________.___________. __       _______     _______. __    __   __  .______");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("|   _  \\      /   \\  |           |           ||  |     |   ____|   /       ||  |  |  | |  | |   _  \\");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("|  |_)  |    /  ^  \\ `---|  |----`---|  |----`|  |     |  |__     |   (----`|  |__|  | |  | |  |_)  |");
            Console.SetCursorPosition(x, y + 3);
            Console.WriteLine("|   _  <    /  /_\\  \\    |  |        |  |     |  |     |   __|     \\   \\    |   __   | |  | |   ___/");
            Console.SetCursorPosition(x, y + 4);
            Console.WriteLine("|  |_)  |  /  _____  \\   |  |        |  |     |  `----.|  |____.----)   |   |  |  |  | |  | |  |");
            Console.SetCursorPosition(x, y + 5);
            Console.WriteLine("|______/  /__/     \\__\\  |__|        |__|     |_______||_______|_______/    |__|  |__| |__| | _|");
        }

        public static void DrawGameBoard(int x, int y)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(x, y);
            Console.Write("    | A | B | C | D | E | F | G | H | I | J |");
            Console.SetCursorPosition(x, y + 1);
            Console.Write("----------------------------------------------");
            Console.SetCursorPosition(x, y + 2);
            Console.Write("1   |   |   |   |   |   |   |   |   |   |   |");
            Console.SetCursorPosition(x, y + 3);
            Console.Write("----------------------------------------------");
            Console.SetCursorPosition(x, y + 4);
            Console.Write("2   |   |   |   |   |   |   |   |   |   |   |");
            Console.SetCursorPosition(x, y + 5);
            Console.Write("----------------------------------------------");
            Console.SetCursorPosition(x, y + 6);
            Console.Write("3   |   |   |   |   |   |   |   |   |   |   |");
            Console.SetCursorPosition(x, y + 7);
            Console.Write("----------------------------------------------");
            Console.SetCursorPosition(x, y + 8);
            Console.Write("4   |   |   |   |   |   |   |   |   |   |   |");
            Console.SetCursorPosition(x, y + 9);
            Console.Write("----------------------------------------------");
            Console.SetCursorPosition(x, y + 10);
            Console.Write("5   |   |   |   |   |   |   |   |   |   |   |");
            Console.SetCursorPosition(x, y + 11);
            Console.Write("----------------------------------------------");
            Console.SetCursorPosition(x, y + 12);
            Console.Write("6   |   |   |   |   |   |   |   |   |   |   |");
            Console.SetCursorPosition(x, y + 13);
            Console.Write("----------------------------------------------");
            Console.SetCursorPosition(x, y + 14);
            Console.Write("7   |   |   |   |   |   |   |   |   |   |   |");
            Console.SetCursorPosition(x, y + 15);
            Console.Write("----------------------------------------------");
            Console.SetCursorPosition(x, y + 16);
            Console.Write("8   |   |   |   |   |   |   |   |   |   |   |");
            Console.SetCursorPosition(x, y + 17);
            Console.Write("----------------------------------------------");
            Console.SetCursorPosition(x, y + 18);
            Console.Write("9   |   |   |   |   |   |   |   |   |   |   |");
            Console.SetCursorPosition(x, y + 19);
            Console.Write("----------------------------------------------");
            Console.SetCursorPosition(x, y + 20);
            Console.Write("10  |   |   |   |   |   |   |   |   |   |   |");
        }
    }
}