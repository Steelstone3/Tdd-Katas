using MarsRover.Controllers;
using MarsRover.Models;
using Xunit;

namespace MarsRoverTests.Controllers;

public class DirectionShould
{
    private IDirection direction = new Direction(Cardinal.North);

    [Theory]
    [InlineData(Cardinal.North, 'D', Cardinal.North)]
    [InlineData(Cardinal.North, 'd', Cardinal.North)]
    [InlineData(Cardinal.North, '5', Cardinal.North)]
    [InlineData(Cardinal.North, '#', Cardinal.North)]
    [InlineData(Cardinal.East, 'H', Cardinal.East)]
    [InlineData(Cardinal.East, 'h', Cardinal.East)]
    [InlineData(Cardinal.East, '9', Cardinal.East)]
    [InlineData(Cardinal.East, '%', Cardinal.East)]
    [InlineData(Cardinal.South, 'T', Cardinal.South)]
    [InlineData(Cardinal.South, 't', Cardinal.South)]
    [InlineData(Cardinal.South, '6', Cardinal.South)]
    [InlineData(Cardinal.South, '#', Cardinal.South)]
    [InlineData(Cardinal.West, 'U', Cardinal.West)]
    [InlineData(Cardinal.West, 'u', Cardinal.West)]
    [InlineData(Cardinal.West, '3', Cardinal.West)]
    [InlineData(Cardinal.West, '^', Cardinal.West)]
    public void InvalidTurn(Cardinal startingDirection, char command, Cardinal expectedDirection)
    {
        direction = new Direction(startingDirection);

        direction.Turn(command);

        Assert.Equal(expectedDirection, direction.CurrentDirection);
    }

    [Theory]
    [InlineData(Cardinal.North, 'R', Cardinal.East)]
    [InlineData(Cardinal.East, 'R', Cardinal.South)]
    [InlineData(Cardinal.South, 'R', Cardinal.West)]
    [InlineData(Cardinal.West, 'R', Cardinal.North)]
    [InlineData(Cardinal.North, 'L', Cardinal.West)]
    [InlineData(Cardinal.West, 'L', Cardinal.South)]
    [InlineData(Cardinal.South, 'L', Cardinal.East)]
    [InlineData(Cardinal.East, 'L', Cardinal.North)]
    public void Turn(Cardinal startingDirection, char command, Cardinal expectedDirection)
    {
        direction = new Direction(startingDirection);

        direction.Turn(command);

        Assert.Equal(expectedDirection, direction.CurrentDirection);
    }
}