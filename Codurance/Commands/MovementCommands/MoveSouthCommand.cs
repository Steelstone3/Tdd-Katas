using System;
using Codurance.Contracts;

namespace Codurance.Commands.MovementCommands
{
    public class MoveSouthCommand : IMoveCommand
    {

        public Tuple<int, int> ExecuteMoveCommand(Directions.Directions.Direction orientation, int positionX, int positionY)
        {
            if (positionY - 1 < 0)
            {
                return new Tuple<int, int>(positionX, 9);
            }
            else
            {
                return new Tuple<int, int>(positionX, positionY - 1);
            }
        }
    }
}