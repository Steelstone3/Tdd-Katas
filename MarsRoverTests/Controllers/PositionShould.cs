using MarsRover.Controllers;
using MarsRover.Models;
using Xunit;

namespace MarsRoverTests.Controllers;

public class PositionShould
{
    [Theory]
    [InlineData(1, 5, Cardinal.North, 1, 6)]
    [InlineData(2, 2, Cardinal.East, 3, 2)]
    [InlineData(5, 5, Cardinal.South, 5, 4)]
    [InlineData(1, 1, Cardinal.West, 0, 1)]
    [InlineData(0, 10, Cardinal.North, 0, 0)]
    [InlineData(10, 0, Cardinal.East, 0, 0)]
    [InlineData(0, 0, Cardinal.South, 0, 10)]
    [InlineData(0, 0, Cardinal.West, 10, 0)]
    public void Move(int startingX, int startingY, Cardinal currentDirection, int expectedX, int expectedY)
    {
        IPosition position = new Position(startingX, startingY);

        position.Move(currentDirection);

        Assert.Equal(expectedX, position.X);
        Assert.Equal(expectedY, position.Y);
    }
}