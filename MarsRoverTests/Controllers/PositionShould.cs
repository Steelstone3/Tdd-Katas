using MarsRover.Controllers;
using MarsRover.Models;
using Moq;
using Xunit;

namespace MarsRoverTests.Controllers;

public class PositionShould
{
    [Theory]
    [InlineData(1, 1, 1, 1)]
    [InlineData(0, 0, 0, 0)]
    [InlineData(5, 5, 5, 5)]
    [InlineData(10, 10, 10, 10)]
    [InlineData(-1, -1, 0, 0)]
    [InlineData(11, 11, 0, 0)]
    public void CreateCoordinates(int x, int y, int expectedX, int expectedY)
    {
        // Given
        IPosition position = new Position(x, y);

        // Then
        Assert.Equal(expectedX, position.X);
        Assert.Equal(expectedY, position.Y);
    }

    [Theory]
    [InlineData(Cardinal.North, 1, 5, 1, 6)]
    [InlineData(Cardinal.East, 2, 2, 3, 2)]
    [InlineData(Cardinal.South, 5, 5, 5, 4)]
    [InlineData(Cardinal.West, 1, 1, 0, 1)]
    [InlineData(Cardinal.North, 0, 10, 0, 0)]
    [InlineData(Cardinal.East, 10, 0, 0, 0)]
    [InlineData(Cardinal.South, 0, 0, 0, 10)]
    [InlineData(Cardinal.West, 0, 0, 10, 0)]
    public void Move(Cardinal currentDirection, int x, int y, int expectedX, int expectedY)
    {
        Mock<IDirection> direction = new();
        direction.Setup(d => d.CurrentDirection).Returns(currentDirection);
        IPosition position = new Position(x, y);

        position.Move(direction.Object);

        Assert.Equal(expectedX, position.X);
        Assert.Equal(expectedY, position.Y);
    }
}