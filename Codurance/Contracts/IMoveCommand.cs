using System;
using static Codurance.Directions.Directions;

namespace Codurance.Contracts
{
    public interface IMoveCommand
    {
        Tuple<int, int> ExecuteMoveCommand(Direction orientation, int positionX, int positionY);
    }
}