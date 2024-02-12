namespace MarsRover.Controllers;

public interface IPosition
{
    int X { get; }
    int Y { get; }
    void Move(IDirection direction);
}