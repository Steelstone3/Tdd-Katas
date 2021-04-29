using MarsRover.Contracts;

namespace MarsRover.Controllers.Commands
{
    public class MoveWestCommand : IMoveCommand
    {
        private int[,] _grid;

        public MoveWestCommand(int[,] grid)
        {
            _grid = grid;
        }

        public string MoveForwardDirection(char direction, int currentXCoordinate, int currentYCoordinate)
        {
               var newXCoordinate = _grid.GetLength(0) - 1;

            if (currentXCoordinate - 1 < 0)
            {
                return $"{direction}:{newXCoordinate}:{currentYCoordinate}";
            }
            else
            {
                newXCoordinate = currentXCoordinate - 1;
                return $"{direction}:{newXCoordinate}:{currentYCoordinate}";
            }
        }
    }
}