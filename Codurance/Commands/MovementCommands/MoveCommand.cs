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
                    if(positionX > 9)
                    {
                        return new Tuple<int, int>(0, positionY);
                    }
                    else
                    {
                        return new Tuple<int, int>(positionX + 1, positionY);
                    }
                case Direction.South:
                    if(positionY - 1 < 0)
                    {
                        return new Tuple<int, int>(positionX, 9);
                    }
                    else
                    {
                        return new Tuple<int, int>(positionX, positionY - 1);
                    }
                case Direction.West:
                    if(positionX - 1 < 0)
                    {
                        return new Tuple<int, int>(9, positionY);
                    }
                    else
                    {
                        return new Tuple<int, int>(positionX - 1, positionY);
                    }
                default:
                    throw new Exception();
            }
        }
    }
}