using System;
using Codurance.Contracts;
using static Codurance.Directions.Directions;

namespace Codurance.Commands.MovementCommands
{
    public class MoveCommand : IMoveCommand
    {
        public Tuple<int, int> ExecuteMoveCommand(Direction orientation, int positionX, int positionY)
        {
            switch (orientation)
            {
                case Direction.North:
                   return new MoveNorthCommand().ExecuteMoveCommand(orientation, positionX, positionY);
                case Direction.East:
                    return new MoveEastCommand().ExecuteMoveCommand(orientation, positionX, positionY);
                case Direction.South:
                    return new MoveSouthCommand().ExecuteMoveCommand(orientation, positionX, positionY);
                case Direction.West:
                    return new MoveWestCommand().ExecuteMoveCommand(orientation, positionX, positionY);
                default:
                    throw new Exception();
            }
        }
    }
}