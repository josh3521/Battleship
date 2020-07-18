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

        public static void DrawTitle((int, int) pos)
        {
            ConsoleColor prevBgColor = Console.BackgroundColor;
            ConsoleColor prevFgColor = Console.ForegroundColor;
            Console.BackgroundColor = System.ConsoleColor.DarkBlue;
            Console.ForegroundColor = System.ConsoleColor.White;
            Console.SetCursorPosition(pos.Item1, pos.Item2);
            Console.WriteLine(".______        ___   .___________.___________. __       _______     _______. __    __   __  .______");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 1);
            Console.WriteLine("|   _  \\      /   \\  |           |           ||  |     |   ____|   /       ||  |  |  | |  | |   _  \\");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 2);
            Console.WriteLine("|  |_)  |    /  ^  \\ `---|  |----`---|  |----`|  |     |  |__     |   (----`|  |__|  | |  | |  |_)  |");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 3);
            Console.WriteLine("|   _  <    /  /_\\  \\    |  |        |  |     |  |     |   __|     \\   \\    |   __   | |  | |   ___/");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 4);
            Console.WriteLine("|  |_)  |  /  _____  \\   |  |        |  |     |  `----.|  |____.----)   |   |  |  |  | |  | |  |");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 5);
            Console.WriteLine("|______/  /__/     \\__\\  |__|        |__|     |_______||_______|_______/    |__|  |__| |__| | _|");
            Console.BackgroundColor = prevBgColor;
            Console.ForegroundColor = prevFgColor;
        }

        public static void DrawGameBoard((int, int) pos)
        {
            ConsoleColor prevBgColor = Console.BackgroundColor;
            ConsoleColor prevFgColor = Console.ForegroundColor;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(pos.Item1, pos.Item2);
            Console.Write("    |    A    |    B    |    C    |    D    |    E    |    F    |    G    |    H    |    I    |    J    |");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 1);
            Console.Write("---------------------------------------------------------------------------------------------------------");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 2);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 3);
            Console.Write("1   |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 4);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 5);
            Console.Write("---------------------------------------------------------------------------------------------------------");

            Console.SetCursorPosition(pos.Item1, pos.Item2 + 6);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 7);
            Console.Write("2   |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 8);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 9);
            Console.Write("---------------------------------------------------------------------------------------------------------");

            Console.SetCursorPosition(pos.Item1, pos.Item2 + 10);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 11);
            Console.Write("3   |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 12);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 13);
            Console.Write("---------------------------------------------------------------------------------------------------------");

            Console.SetCursorPosition(pos.Item1, pos.Item2 + 14);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 15);
            Console.Write("4   |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 16);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 17);
            Console.Write("---------------------------------------------------------------------------------------------------------");

            Console.SetCursorPosition(pos.Item1, pos.Item2 + 18);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 19);
            Console.Write("5   |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 20);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 21);
            Console.Write("---------------------------------------------------------------------------------------------------------");

            Console.SetCursorPosition(pos.Item1, pos.Item2 + 22);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 23);
            Console.Write("6   |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 24);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 25);
            Console.Write("---------------------------------------------------------------------------------------------------------");

            Console.SetCursorPosition(pos.Item1, pos.Item2 + 26);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 27);
            Console.Write("7   |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 28);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 29);
            Console.Write("---------------------------------------------------------------------------------------------------------");

            Console.SetCursorPosition(pos.Item1, pos.Item2 + 30);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 31);
            Console.Write("8   |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 32);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 33);
            Console.Write("---------------------------------------------------------------------------------------------------------");

            Console.SetCursorPosition(pos.Item1, pos.Item2 + 34);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 35);
            Console.Write("9   |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 36);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 37);
            Console.Write("---------------------------------------------------------------------------------------------------------");

            Console.SetCursorPosition(pos.Item1, pos.Item2 + 38);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 39);
            Console.Write("10  |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 40);
            Console.Write("    |         |         |         |         |         |         |         |         |         |         |");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 41);
            Console.Write("---------------------------------------------------------------------------------------------------------");

            Console.BackgroundColor = prevBgColor;
            Console.ForegroundColor = prevFgColor;
        }

        public static void DrawShipStern((int, int) pos, Directions dir)
        {
            ConsoleColor prevBgColor = Console.BackgroundColor;
            ConsoleColor prevFgColor = Console.ForegroundColor;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(pos.Item1, pos.Item2);
            switch (dir)
            {
                case Directions.Up:
                    Console.Write("    ^    ");
                    Console.SetCursorPosition(pos.Item1, pos.Item2 + 1);
                    Console.Write("  /   \\  ");
                    Console.SetCursorPosition(pos.Item1, pos.Item2 + 2);
                    Console.Write("  |   |  ");
                    break;
                case Directions.Down:
                    Console.Write("  |   |  ");
                    Console.SetCursorPosition(pos.Item1, pos.Item2 + 1);
                    Console.Write("  \\   /  ");
                    Console.SetCursorPosition(pos.Item1, pos.Item2 + 2);
                    Console.Write("    V    ");
                    break;
                case Directions.Left:
                    Console.Write("   _-----");
                    Console.SetCursorPosition(pos.Item1, pos.Item2 + 1);
                    Console.Write(" < _     ");
                    Console.SetCursorPosition(pos.Item1, pos.Item2 + 2);
                    Console.Write("    -----");
                    break;
                case Directions.Right:
                    Console.Write("-----_   ");
                    Console.SetCursorPosition(pos.Item1, pos.Item2 + 1);
                    Console.Write("     _ > ");
                    Console.SetCursorPosition(pos.Item1, pos.Item2 + 2);
                    Console.Write("-----    ");
                    break;
            }
            Console.BackgroundColor = prevBgColor;
            Console.ForegroundColor = prevFgColor;
        }

        public static void DrawShipMiddle((int, int) pos, Directions dir)
        {
            ConsoleColor prevBgColor = Console.BackgroundColor;
            ConsoleColor prevFgColor = Console.ForegroundColor;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(pos.Item1, pos.Item2);
            switch (dir)
            {
                case Directions.Up:
                    Console.Write("  |   |  ");
                    Console.SetCursorPosition(pos.Item1, pos.Item2 + 1);
                    Console.Write("  |   |  ");
                    Console.SetCursorPosition(pos.Item1, pos.Item2 + 2);
                    Console.Write("  |   |  ");
                    break;
                case Directions.Down:
                    Console.Write("  |   |  ");
                    Console.SetCursorPosition(pos.Item1, pos.Item2 + 1);
                    Console.Write("  |   |  ");
                    Console.SetCursorPosition(pos.Item1, pos.Item2 + 2);
                    Console.Write("  |   |  ");
                    break;
                case Directions.Left:
                    Console.Write("---------");
                    Console.SetCursorPosition(pos.Item1, pos.Item2 + 1);
                    Console.Write("         ");
                    Console.SetCursorPosition(pos.Item1, pos.Item2 + 2);
                    Console.Write("----------");
                    break;
                case Directions.Right:
                    Console.Write("---------");
                    Console.SetCursorPosition(pos.Item1, pos.Item2 + 1);
                    Console.Write("         ");
                    Console.SetCursorPosition(pos.Item1, pos.Item2 + 2);
                    Console.Write("----------");
                    break;
            }
            Console.BackgroundColor = prevBgColor;
            Console.ForegroundColor = prevFgColor;
        }

        public static void DrawShipBow((int, int) pos, Directions dir)
        {
            ConsoleColor prevBgColor = Console.BackgroundColor;
            ConsoleColor prevFgColor = Console.ForegroundColor;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(pos.Item1, pos.Item2);
            switch (dir)
            {
                case Directions.Up:
                    Console.Write("  |   |  ");
                    Console.SetCursorPosition(pos.Item1, pos.Item2 + 1);
                    Console.Write("  |   |  ");
                    Console.SetCursorPosition(pos.Item1, pos.Item2 + 2);
                    Console.Write("  \\___/  ");
                    break;
                case Directions.Down:
                    Console.Write("  /---\\  ");
                    Console.SetCursorPosition(pos.Item1, pos.Item2 + 1);
                    Console.Write("  |   |  ");
                    Console.SetCursorPosition(pos.Item1, pos.Item2 + 2);
                    Console.Write("  |   |  ");
                    break;
                case Directions.Left:
                    Console.Write("-------  ");
                    Console.SetCursorPosition(pos.Item1, pos.Item2 + 1);
                    Console.Write("       | ");
                    Console.SetCursorPosition(pos.Item1, pos.Item2 + 2);
                    Console.Write("-------  ");
                    break;
                case Directions.Right:
                    Console.Write("  -------");
                    Console.SetCursorPosition(pos.Item1, pos.Item2 + 1);
                    Console.Write(" |       ");
                    Console.SetCursorPosition(pos.Item1, pos.Item2 + 2);
                    Console.Write("  -------");
                    break;
            }
            Console.BackgroundColor = prevBgColor;
            Console.ForegroundColor = prevFgColor;
        }

        // Draw a blank tile.
        public static void DrawBlank((int, int) pos, ConsoleColor color)
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.BackgroundColor = color;
            Console.SetCursorPosition(pos.Item1, pos.Item2);
            Console.Write("         ");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 1);
            Console.Write("         ");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 2);
            Console.Write("         ");
            Console.BackgroundColor = prevColor; // Restore original console background color setting.
        }

        public static void DrawHit((int, int) pos)
        {
            ConsoleColor prevBgColor = Console.BackgroundColor;
            ConsoleColor prevFgColor = Console.ForegroundColor;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(pos.Item1, pos.Item2);
            Console.Write("   \\ /   ");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 1);
            Console.Write("    X    ");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 2);
            Console.Write("   / \\   ");
            Console.BackgroundColor = prevBgColor;
            Console.ForegroundColor = prevFgColor;
        }

        public static void DrawMiss((int, int) pos)
        {
            ConsoleColor prevBgColor = Console.BackgroundColor;
            ConsoleColor prevFgColor = Console.ForegroundColor;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(pos.Item1, pos.Item2);
            Console.Write("    _    ");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 1);
            Console.Write("  ( _ )  ");
            Console.SetCursorPosition(pos.Item1, pos.Item2 + 2);
            Console.Write("         ");
            Console.BackgroundColor = prevBgColor;
            Console.ForegroundColor = prevFgColor;
        }
    }
}