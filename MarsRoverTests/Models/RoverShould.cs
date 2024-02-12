using MarsRover;
using MarsRover.Controllers;
using MarsRover.Models;
using Xunit;

namespace MarsRoverTests.Models;

public class RoverShould
{
    private IRover rover;

    public RoverShould()
    {
        Direction direction = new(Cardinal.North);
        Position position = new(0, 0);
        rover = new Rover(direction, position);
    }

    [Theory]
    [InlineData("", "X0:Y0:North")]
    [InlineData("DFEHCVhyd1245%^#!", "X0:Y0:North")]
    [InlineData("DFEHCMVhLRMyd1RMM245%^#!", "X2:Y2:East")]
    [InlineData("M", "X0:Y1:North")]
    [InlineData("MM", "X0:Y2:North")]
    [InlineData("MMM", "X0:Y3:North")]
    [InlineData("R", "X0:Y0:East")]
    [InlineData("RR", "X0:Y0:South")]
    [InlineData("RRR", "X0:Y0:West")]
    [InlineData("L", "X0:Y0:West")]
    [InlineData("LL", "X0:Y0:South")]
    [InlineData("LLL", "X0:Y0:East")]
    [InlineData("LMMRMRMLLM", "X9:Y1:West")]
    public void ExecuteCommands(string commandInput, string expectedOutput)
    {
        // When
        string output = rover.Execute(commandInput);

        // Then
        Assert.Equal(expectedOutput, output);
    }
}