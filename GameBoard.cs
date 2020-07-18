namespace Battleship
{
    public class GameBoard
    {

        private (int, int)[,] tilePositions;
        private (int, int) gameboardPosition;
        public GameBoard()
        {
            gameboardPosition = (4, 4);
            populateTilePositions();

            Sprites.DrawBlankScreen();
            Sprites.DrawTitle((14, 14));
            System.Console.Read();
            Sprites.DrawBlankScreen();
            Sprites.DrawGameBoard(gameboardPosition);



            Sprites.DrawHit(tilePositions[0, 0]);


            Sprites.DrawMiss(tilePositions[1, 0]);


            Sprites.DrawShipStern(tilePositions[0, 1], Directions.Up);
            Sprites.DrawShipMiddle(tilePositions[0, 2], Directions.Up);
            Sprites.DrawShipBow(tilePositions[0, 3], Directions.Up);

            Sprites.DrawBlank(tilePositions[1, 1], System.ConsoleColor.DarkCyan);

            Sprites.DrawShipStern(tilePositions[3, 3], Directions.Left);
            Sprites.DrawShipMiddle(tilePositions[4, 3], Directions.Left);
            Sprites.DrawShipBow(tilePositions[5, 3], Directions.Left);
        }

        private void populateTilePositions()
        {
            (int, int) firstSpace = (gameboardPosition.Item1 + 5, gameboardPosition.Item2 + 2);
            tilePositions = new (int, int)[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tilePositions[i, j] = (firstSpace.Item1 + 10 * i, firstSpace.Item2 + 4 * j);
                }
            }
        }


    }
}