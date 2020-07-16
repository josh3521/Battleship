using System;

namespace Battleship
{
    public static class Sprites
    {
        // Container for static methods that draw the game's sprites to the screen.

        public static void DrawBlankScreen()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
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
            Console.Write("    |    A    |    B    |    C    |    D    |    E    |    F    |    G    |    H    |    I    |    J    |");
            Console.SetCursorPosition(x, y + 1);
            Console.Write("---------------------------------------------------------------------------------------------------------");
            Console.SetCursorPosition(x, y + 2);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(x, y + 3);
            Console.Write("1   |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(x, y + 4);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(x, y + 5);
            Console.Write("---------------------------------------------------------------------------------------------------------");

            Console.SetCursorPosition(x, y + 6);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(x, y + 7);
            Console.Write("2   |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(x, y + 8);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(x, y + 9);
            Console.Write("---------------------------------------------------------------------------------------------------------");

            Console.SetCursorPosition(x, y + 10);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(x, y + 11);
            Console.Write("3   |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(x, y + 12);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(x, y + 13);
            Console.Write("---------------------------------------------------------------------------------------------------------");

            Console.SetCursorPosition(x, y + 14);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(x, y + 15);
            Console.Write("4   |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(x, y + 16);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(x, y + 17);
            Console.Write("---------------------------------------------------------------------------------------------------------");

            Console.SetCursorPosition(x, y + 18);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(x, y + 19);
            Console.Write("5   |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(x, y + 20);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(x, y + 21);
            Console.Write("---------------------------------------------------------------------------------------------------------");

            Console.SetCursorPosition(x, y + 22);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(x, y + 23);
            Console.Write("6   |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(x, y + 24);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(x, y + 25);
            Console.Write("---------------------------------------------------------------------------------------------------------");

            Console.SetCursorPosition(x, y + 26);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(x, y + 27);
            Console.Write("7   |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(x, y + 28);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(x, y + 29);
            Console.Write("---------------------------------------------------------------------------------------------------------");

            Console.SetCursorPosition(x, y + 30);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(x, y + 31);
            Console.Write("8   |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(x, y + 32);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(x, y + 33);
            Console.Write("---------------------------------------------------------------------------------------------------------");

            Console.SetCursorPosition(x, y + 34);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(x, y + 35);
            Console.Write("9   |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(x, y + 36);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(x, y + 37);
            Console.Write("---------------------------------------------------------------------------------------------------------");

            Console.SetCursorPosition(x, y + 38);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(x, y + 39);
            Console.Write("10  |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(x, y + 40);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(x, y + 41);
            Console.Write("---------------------------------------------------------------------------------------------------------");
        }

        public static void DrawShipStern(int x, int y, Directions dir)
        {
            Console.SetCursorPosition(x, y);
            switch (dir)
            {
                case Directions.Up:
                    Console.Write("    ^    ");
                    Console.SetCursorPosition(x, y + 1);
                    Console.Write("  /   \\  ");
                    Console.SetCursorPosition(x, y + 2);
                    Console.Write("  |   |  ");
                    break;
                case Directions.Down:
                    Console.Write("  |   |  ");
                    Console.SetCursorPosition(x, y + 1);
                    Console.Write("  \\   /  ");
                    Console.SetCursorPosition(x, y + 2);
                    Console.Write("    V    ");
                    break;
                case Directions.Left:
                    Console.Write("   _-----");
                    Console.SetCursorPosition(x, y + 1);
                    Console.Write(" < _     ");
                    Console.SetCursorPosition(x, y + 2);
                    Console.Write("    -----");
                    break;
                case Directions.Right:
                    Console.Write("-----_   ");
                    Console.SetCursorPosition(x, y + 1);
                    Console.Write("     _ > ");
                    Console.SetCursorPosition(x, y + 2);
                    Console.Write("-----    ");
                    break;
            }
        }

        public static void DrawShipMiddle(int x, int y, Directions dir)
        {
            switch (dir)
            {
                case Directions.Up:
                    Console.Write("  |   |  ");
                    Console.SetCursorPosition(x, y + 1);
                    Console.Write("  |   |  ");
                    Console.SetCursorPosition(x, y + 2);
                    Console.Write("  |   |  ");
                    break;
                case Directions.Down:
                    Console.Write("  |   |  ");
                    Console.SetCursorPosition(x, y + 1);
                    Console.Write("  |   |  ");
                    Console.SetCursorPosition(x, y + 2);
                    Console.Write("  |   |  ");
                    break;
                case Directions.Left:
                    Console.Write("---------");
                    Console.SetCursorPosition(x, y + 1);
                    Console.Write("         ");
                    Console.SetCursorPosition(x, y + 2);
                    Console.Write("----------");
                    break;
                case Directions.Right:
                    Console.Write("---------");
                    Console.SetCursorPosition(x, y + 1);
                    Console.Write("         ");
                    Console.SetCursorPosition(x, y + 2);
                    Console.Write("----------");
                    break;
            }
        }

        public static void DrawShipBow(int x, int y, Directions dir)
        {
            switch (dir)
            {
                case Directions.Up:
                    Console.Write("  |   |  ");
                    Console.SetCursorPosition(x, y + 1);
                    Console.Write("  |   |  ");
                    Console.SetCursorPosition(x, y + 2);
                    Console.Write("  \\___/  ");
                    break;
                case Directions.Down:
                    Console.Write("  /---\\  ");
                    Console.SetCursorPosition(x, y + 1);
                    Console.Write("  |   |  ");
                    Console.SetCursorPosition(x, y + 2);
                    Console.Write("  |   |  ");
                    break;
                case Directions.Left:
                    Console.Write("-------  ");
                    Console.SetCursorPosition(x, y + 1);
                    Console.Write("       | ");
                    Console.SetCursorPosition(x, y + 2);
                    Console.Write("-------  ");
                    break;
                case Directions.Right:
                    Console.Write("  -------");
                    Console.SetCursorPosition(x, y + 1);
                    Console.Write(" |       ");
                    Console.SetCursorPosition(x, y + 2);
                    Console.Write("  -------");
                    break;
            }
        }

        // Draw a blank tile.
        public static void DrawBlank(int x, int y, ConsoleColor color)
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.BackgroundColor = color;
            Console.SetCursorPosition(x, y);
            Console.Write("         ");
            Console.SetCursorPosition(x, y + 1);
            Console.Write("         ");
            Console.SetCursorPosition(x, y + 2);
            Console.Write("         ");
            Console.BackgroundColor = prevColor; // Restore original console background color setting.
        }

        public static void DrawHit(int x, int y)
        {
            ConsoleColor prevFgColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(x, y);
            Console.Write("   \\ /   ");
            Console.SetCursorPosition(x, y + 1);
            Console.Write("    X    ");
            Console.SetCursorPosition(x, y + 2);
            Console.Write("   / \\   ");
            Console.ForegroundColor = prevFgColor;
        }

        public static void DrawMiss(int x, int y)
        {
            ConsoleColor prevFgColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(x, y);
            Console.Write("    _    ");
            Console.SetCursorPosition(x, y + 1);
            Console.Write("  ( _ )  ");
            Console.SetCursorPosition(x, y + 2);
            Console.Write("         ");
            Console.ForegroundColor = prevFgColor;
        }
    }
}