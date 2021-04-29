using MarsRover.Contracts;

namespace MarsRover.Controllers.Commands
{
    public class MoveSouthCommand : IMoveCommand
    {
        private int[,] _grid;

        public MoveSouthCommand(int[,] grid)
        {
            _grid = grid;
        }

        public string MoveForwardDirection(char direction, int currentXCoordinate, int currentYCoordinate)
        {
            var newYCoordinate = _grid.GetLength(1) - 1;

            if (currentYCoordinate - 1 < 0)
            {
                return $"{direction}:{currentXCoordinate}:{newYCoordinate}";
            }
            else
            {
                newYCoordinate = currentYCoordinate - 1;
                return $"{direction}:{currentXCoordinate}:{newYCoordinate}";
            }
        }
    }
}