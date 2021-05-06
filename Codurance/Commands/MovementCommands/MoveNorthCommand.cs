using System;
using Codurance.Contracts;
using static Codurance.Directions.Directions;

namespace Codurance.Commands.MovementCommands
{
    public class MoveNorthCommand : IMoveCommand
    {
        public Tuple<int, int> ExecuteMoveCommand(Direction orientation, int positionX, int positionY)
        {
            if (positionY > 9)
            {
                return new Tuple<int, int>(positionX, 0);
            }
            else
            {
                return new Tuple<int, int>(positionX, positionY + 1);
            }
        }
    }
}