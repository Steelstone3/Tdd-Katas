using Codurance.Contracts;
using static Codurance.Directions.Directions;

namespace Codurance.Commands
{
    public class TurnRightCommand : ITurnCommand
    {
        public Direction ExecuteTurnCommand(Direction orientation)
        {
           if(orientation == Direction.West)
            {
                return Direction.North;
            }
            else
            {
                return orientation + 1;
            }
        }
    }
}