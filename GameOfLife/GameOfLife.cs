using GameOfLife;

namespace BankingKata
{
    public class ConwaysGameOfLife : IGameOfLife
    {
        private readonly DirectionChecker directionChecker;
        private readonly int numberOfRows;
        private readonly int numberOfColumns;

        public ConwaysGameOfLife(bool[][] board)
        {
            Board = board;
            directionChecker = new DirectionChecker(board);
            numberOfRows = board.Length;
            numberOfColumns = board[0].Length;
        }

        public bool[][] Board { get; private set; }

        public void NextGeneration()
        {
            bool[][] nextGenerationBoard = Board;

            for (int y = 0; y < numberOfColumns; y++)
            {
                for (int x = 0; x < numberOfRows; x++)
                {
                    int aliveNeighbourCellCount = CountAliveCells(y, x);
                    CreateNextGenerationBoard(nextGenerationBoard, y, x, aliveNeighbourCellCount);
                }
            }

            Board = nextGenerationBoard;
        }

        private int CountAliveCells(int y, int x)
        {
            int aliveNeighbourCellCount = 0;

            aliveNeighbourCellCount += directionChecker.CheckUp(x, y);
            aliveNeighbourCellCount += directionChecker.CheckTopRight(x, y);
            aliveNeighbourCellCount += directionChecker.CheckRight(x, y);
            aliveNeighbourCellCount += directionChecker.CheckBottomRight(x, y);
            aliveNeighbourCellCount += directionChecker.CheckDown(x, y);
            aliveNeighbourCellCount += directionChecker.CheckBottomLeft(x, y);
            aliveNeighbourCellCount += directionChecker.CheckLeft(x, y);
            aliveNeighbourCellCount += directionChecker.CheckTopLeft(x, y);

            return aliveNeighbourCellCount;
        }

        private void CreateNextGenerationBoard(bool[][] nextGenerationBoard, int y, int x, int aliveNeighbourCellCount)
        {
            if (Board[y][x])
            {
                nextGenerationBoard[y][x] = aliveNeighbourCellCount == 2 || aliveNeighbourCellCount == 3;
            }
            else
            {
                nextGenerationBoard[y][x] = aliveNeighbourCellCount == 3;
            }
        }
    }
}