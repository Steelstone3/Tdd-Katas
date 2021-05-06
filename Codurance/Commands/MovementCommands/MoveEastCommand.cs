using System;
using Codurance.Contracts;

namespace Codurance.Commands.MovementCommands
{
    public class MoveEastCommand : IMoveCommand
    {
        public Tuple<int, int> ExecuteMoveCommand(Directions.Directions.Direction orientation, int positionX, int positionY)
        {
            if (positionX >= 9)
            {
                return new Tuple<int, int>(0, positionY);
            }
            else
            {
                return new Tuple<int, int>(positionX + 1, positionY);
            }
        }
    }
}