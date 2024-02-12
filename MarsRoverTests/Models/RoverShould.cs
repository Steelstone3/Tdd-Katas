using System;
using MarsRover;
using MarsRover.Controllers;
using MarsRover.Models;
using MarsRover.Presenters;
using Moq;
using Xunit;

namespace MarsRoverTests.Models;

public class RoverShould
{
    private readonly Mock<IPosition> position = new();
    private readonly Mock<IDirection> direction = new();
    private readonly Mock<IPresenter> presenter = new();
    private IRover rover;

    public RoverShould()
    {
        rover = new Rover(direction.Object, position.Object);
    }

    [Theory]
    [InlineData("LLMRz")]
    [InlineData("MRLN")]
    [InlineData("124")]
    [InlineData("12.de5!R")]
    [InlineData("  ML ")]
    public void ThrowExceptionToInvalidInstructions(string invalidInstructions)
    {
        Assert.Throws<ArgumentException>(() => rover.Execute(invalidInstructions));
    }

    [Fact]
    public void TurnLeft()
    {
        direction.Setup(d => d.Turn('L'));
        rover = new Rover(direction.Object, position.Object);

        rover.Execute("L");

        direction.VerifyAll();
    }

    [Fact]
    public void TurnRight()
    {
        direction.Setup(d => d.Turn('R'));
        rover = new Rover(direction.Object, position.Object);

        rover.Execute("R");

        direction.VerifyAll();
    }

    [Fact]
    public void Move()
    {
        position.Setup(p => p.Move(direction.Object));
        rover = new Rover(direction.Object, position.Object);

        rover.Execute("M");

        position.VerifyAll();
    }

    [Fact]
    public void SendInstructions()
    {
        presenter.Setup(p => p.EnterInstructions());

        rover.EnterInstructions(presenter.Object);

        presenter.VerifyAll();
    }

    [Fact]
    public void DisplayPositionAndDirection()
    {
        presenter.Setup(p => p.PrintState(position.Object, direction.Object));

        rover.PrintState(presenter.Object);

        presenter.VerifyAll();
    }
}