using System.Linq;
using MarsRover.Contracts;

namespace MarsRover.Controllers.Commands
{
    public class TurnRightCommand : IMarsRoverCommands
    {
        private char[] _directions;

        public TurnRightCommand(char[] directions)
        {
            _directions = directions;
        }

        public string ExecuteCommandString(char direction, int currentXCoordinate, int currentYCoordinate)
        {
             int indexOfDirection = _directions.ToList().IndexOf(direction) + 1;
            if (indexOfDirection > _directions.Length - 1)
            {
                return $"{_directions[0].ToString()}:{currentXCoordinate}:{currentYCoordinate}";
            }
            else
            {
                return $"{_directions[indexOfDirection].ToString()}:{currentXCoordinate}:{currentYCoordinate}";
            }
        }
    }
}