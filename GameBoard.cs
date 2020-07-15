namespace Battleship
{
    public class GameBoard
    {
        public GameBoard()
        {
            ClearGameScreen();
            Sprites.DrawTitle(14, 14);
            ClearGameScreen();
            Sprites.DrawGameBoard(4, 4);
        }


    }
}