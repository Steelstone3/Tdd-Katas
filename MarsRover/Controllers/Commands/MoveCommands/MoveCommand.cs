using MarsRover.Contracts;
using MarsRover.Controllers.Commands;

namespace MarsRover.Controllers.Commands
{
    public class MoveCommand : IMarsRoverCommands
    {
        private int[,] _grid;

        public MoveCommand(int[,] grid)
        {
            _grid = grid;
        }

        public string ExecuteCommandString(char direction, int currentXCoordinate, int currentYCoordinate)
        {
            switch (direction)
            {
                case ('N'):
                    return new MoveNorthCommand(_grid).MoveForwardDirection(direction, currentXCoordinate, currentYCoordinate);
                case ('E'):
                    return new MoveEastCommand(_grid).MoveForwardDirection(direction, currentXCoordinate, currentYCoordinate);
                case ('S'):
                    return new MoveSouthCommand(_grid).MoveForwardDirection(direction, currentXCoordinate, currentYCoordinate);
                case ('W'):
                    return new MoveWestCommand(_grid).MoveForwardDirection(direction, currentXCoordinate, currentYCoordinate);
                default:
                    return null;
            }
        }
    }
}