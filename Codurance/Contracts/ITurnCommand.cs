using static Codurance.Directions.Directions;

namespace Codurance.Contracts
{
    public interface ITurnCommand
    {
        Direction ExecuteTurnCommand(Direction orientation);
    }
}