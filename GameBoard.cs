namespace Battleship
{
    public class GameBoard
    {
        public GameBoard()
        {
            Sprites.DrawBlankScreen();
            Sprites.DrawTitle(14, 14);
            System.Console.Read();
            Sprites.DrawBlankScreen();
            Sprites.DrawGameBoard(4, 4);
        }


    }
}