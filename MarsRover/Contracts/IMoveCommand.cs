namespace MarsRover.Contracts
{
    public interface IMoveCommand
    {
        string MoveForwardDirection(char direction, int currentXCoordinate, int currentYCoordinate);
    }
}