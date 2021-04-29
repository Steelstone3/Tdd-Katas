namespace MarsRover.Contracts
{
    public interface IMarsRoverCommands
    {
        string ExecuteCommandString(char direction, int currentXCoordinate, int currentYCoordinate);
    }
}