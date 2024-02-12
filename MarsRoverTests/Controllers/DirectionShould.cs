using System;
using MarsRover.Controllers;
using MarsRover.Models;
using Xunit;

namespace MarsRoverTests.Controllers;

public class DirectionShould
{
    private IDirection direction = new Direction(Cardinal.North);

    [Theory]
    [InlineData('1')]
    [InlineData('!')]
    [InlineData('k')]
    [InlineData('J')]
    public void ThrowExceptionToInvalidInstructions(char invalidInstruction)
    {
        Assert.Throws<ArgumentException>(() => direction.Turn(invalidInstruction));
    }

    [Theory]
    [InlineData(Cardinal.North, Cardinal.East)]
    [InlineData(Cardinal.East, Cardinal.South)]
    [InlineData(Cardinal.South, Cardinal.West)]
    [InlineData(Cardinal.West, Cardinal.North)]
    public void TurnRight(Cardinal startingDirection, Cardinal expectedDirection)
    {
        direction = new Direction(startingDirection);

        direction.Turn('R');

        Assert.Equal(expectedDirection, direction.CurrentDirection);
    }

    [Theory]
    [InlineData(Cardinal.North, Cardinal.West)]
    [InlineData(Cardinal.West, Cardinal.South)]
    [InlineData(Cardinal.South, Cardinal.East)]
    [InlineData(Cardinal.East, Cardinal.North)]
    public void TurnLeft(Cardinal startingDirection, Cardinal expectedDirection)
    {
        direction = new Direction(startingDirection);

        direction.Turn('L');

        Assert.Equal(expectedDirection, direction.CurrentDirection);
    }
}