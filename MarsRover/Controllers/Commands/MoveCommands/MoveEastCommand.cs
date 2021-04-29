using MarsRover.Contracts;

namespace MarsRover.Controllers.Commands
{
    public class MoveEastCommand : IMoveCommand
    {
        private int[,] _grid;

        public MoveEastCommand(int[,] grid)
        {
            _grid = grid;
        }

        public string MoveForwardDirection(char direction, int currentXCoordinate, int currentYCoordinate)
        {
            var newXCoordinate = 0;

            if (currentXCoordinate + 1 > _grid.GetLength(0) - 1)
            {
                return $"{direction}:{newXCoordinate}:{currentYCoordinate}";
            }
            else
            {
                newXCoordinate = currentXCoordinate + 1;
                return $"{direction}:{newXCoordinate}:{currentYCoordinate}";
            }
        }
    }
}