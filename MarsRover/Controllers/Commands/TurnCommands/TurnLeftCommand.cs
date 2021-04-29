using System.Linq;
using MarsRover.Contracts;

namespace MarsRover.Controllers.Commands
{
    public class TurnLeftCommand : IMarsRoverCommands
    {
        private char[] _directions;

        public TurnLeftCommand(char[] directions)
        {
            _directions = directions;
        }

        public string ExecuteCommandString(char direction, int currentXCoordinate, int currentYCoordinate)
        {
            int indexOfDirection = _directions.ToList().IndexOf(direction) - 1;
            if (indexOfDirection < 0)
            {
                return $"{_directions[_directions.Length - 1].ToString()}:{currentXCoordinate}:{currentYCoordinate}";
            }
            else
            {
                return $"{_directions[indexOfDirection].ToString()}:{currentXCoordinate}:{currentYCoordinate}";
            }
        }
    }
}
