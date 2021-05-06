using System;
using Codurance.Contracts;

namespace Codurance.Commands.MovementCommands
{
    public class MoveWestCommand : IMoveCommand
    {
        public Tuple<int, int> ExecuteMoveCommand(Directions.Directions.Direction orientation, int positionX, int positionY)
        {
            if (positionX - 1 < 0)
            {
                return new Tuple<int, int>(9, positionY);
            }
            else
            {
                return new Tuple<int, int>(positionX - 1, positionY);
            }
        }
    }
}