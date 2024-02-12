using System;

namespace GameOfLife
{
    public class DirectionChecker
    {
        private readonly bool[][] board;

        public DirectionChecker(bool[][] board)
        {
            this.board = board;
        }

        public int CheckUp(int x, int y) => CheckCell(x, y - 1);
        public int CheckDown(int x, int y) => CheckCell(x, y + 1);
        public int CheckLeft(int x, int y) => CheckCell(x - 1, y);
        public int CheckRight(int x, int y) => CheckCell(x + 1, y);
        public int CheckTopLeft(int x, int y) => CheckCell(x - 1, y - 1);
        public int CheckTopRight(int x, int y) => CheckCell(x + 1, y - 1);
        public int CheckBottomLeft(int x, int y) => CheckCell(x - 1, y + 1);
        public int CheckBottomRight(int x, int y) => CheckCell(x + 1, y + 1);

        private int CheckCell(int x, int y)
        {
            try
            {
                return board[y][x] ? 1 : 0;
            }
            catch (IndexOutOfRangeException)
            {
                return 0;
            }
        }
    }
}