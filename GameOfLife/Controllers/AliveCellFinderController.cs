namespace GameOfLife.Controllers
{
    public class AliveCellFinderController
    {
        private GameState _gameState;

        public AliveCellFinderController(GameState gameState)
        {
            _gameState = gameState;
        }

        public int AliveSurroundingCells(int x, int y)
        {
            int aliveCells = 0;

            int[] xCellsToCheck = new int[]
            {
                //x - 1
                x - 1,
                x - 1,
                x - 1,
                
                //x
                x,
                x,
                
                //x + 1
                x + 1,
                x + 1,
                x + 1,
            };

            int[] yCellsToCheck = new int[]
            {
                //x - 1
                y + 1,
                y,
                y - 1,
                
                //x
                y + 1,
                y - 1,
                
                //x + 1
                y + 1,
                y,
                y - 1,
            };

            for (int i = 0; i < yCellsToCheck.Length - 1; i++)
            {
                if (IsInTheGrid(xCellsToCheck[i], yCellsToCheck[i]))
                {
                    var isAlive = _gameState.State[xCellsToCheck[i], yCellsToCheck[i]];
                    if (isAlive == true)
                    {
                        aliveCells++;
                    }
                }
            }

            return aliveCells;
        }

        private bool IsInTheGrid(int x, int y) => x >= 0 && y >= 0 && x < _gameState.State.GetLength(1) && y < _gameState.State.GetLength(0);
    }
}

