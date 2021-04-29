using MarsRover.Contracts;

namespace MarsRover.Controllers.Commands
{
    public class MoveNorthCommand : IMoveCommand
    {
         private int[,] _grid;

        public MoveNorthCommand(int[,] grid)
        {
            _grid = grid;
        }

        public string MoveForwardDirection(char direction, int currentXCoordinate, int currentYCoordinate)
        {
             var newYCoordinate = 0;

            if (currentYCoordinate + 1 > _grid.GetLength(1) - 1)
            {
                return $"{direction}:{currentXCoordinate}:{newYCoordinate}";
            }
            else
            {
                newYCoordinate = currentYCoordinate + 1;
                return $"{direction}:{currentXCoordinate}:{newYCoordinate}";
            }
        }
    }
}