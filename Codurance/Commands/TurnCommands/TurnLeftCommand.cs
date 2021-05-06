using Codurance.Contracts;
using static Codurance.Directions.Directions;

namespace Codurance.Commands
{
    public class TurnLeftCommand : ITurnCommand
    {
        public Direction ExecuteTurnCommand(Direction orientation)
        {
            if(orientation == Direction.North)
            {
                return Direction.West;
            }
            else
            {
                return orientation - 1;
            }
        }
    }
}