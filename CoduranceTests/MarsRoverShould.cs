using System;
using Codurance;
using Xunit;
using static Codurance.Directions.Directions;

namespace CoduranceTests
{
    public class MarsRoverShould
    {
        private int[,] _grid = new int[10,10]
        {
            {1,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0},
        };

        //Obstacles are represented as the number 5
        private int[,] _gridObstacle = new int[10,10]
        {
            {1,0,5,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0},
            {5,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0},
        };

        private MarsRover _marsRover;

        public MarsRoverShould()
        {
            _marsRover = new MarsRover(_grid);
        }

        [Fact]
        public void HaveAStartingPosition()
        {
            Assert.Equal(_grid[0,0], _grid[_marsRover.PositionX, _marsRover.PositionY]);
        }

        [Fact]
        public void HaveAStartingDirection()
        {            
            Assert.Equal(Direction.North, _marsRover.Orientation);
        }

        [Theory]
        [InlineData("L", Direction.West)]
        [InlineData("LL", Direction.South)]
        [InlineData("LLL", Direction.East)]
        [InlineData("LLLL", Direction.North)]
        [InlineData("R", Direction.East)]
        [InlineData("RR", Direction.South)]
        [InlineData("RRR", Direction.West)]
        [InlineData("RRRR", Direction.North)]
        public void Turn(string command, Direction expectedDirection)
        {
            _marsRover.RunCommand(command);
            Assert.Equal(expectedDirection, _marsRover.Orientation);
        }

        [Theory]
        [InlineData("M", 0, 1)]
        [InlineData("RM", 1, 0)]
        [InlineData("RRM", 0, 9)]
        [InlineData("LM", 9, 0)]
        [InlineData("MMMMMMMMMM", 0, 0)]
        [InlineData("RMMMMMMMMMM", 0, 0)]
        [InlineData("RRMMMMMMMMMM", 0, 0)]
        [InlineData("LMMMMMMMMMM", 0, 0)]
        public void Move(string command, int expectedXPosition, int expectedYPosition)
        {
            _marsRover.RunCommand(command);
            Assert.Equal(expectedXPosition, _marsRover.PositionX);
            Assert.Equal(expectedYPosition, _marsRover.PositionY);
        }

        [Theory]
        [InlineData("M", 0, 1)]
        [InlineData("RM", 1, 0)]
        [InlineData("RRM", 0, 9)]
        [InlineData("LM", 9, 0)]
        [InlineData("MMMMMMMMMM", 0, 0)]
        [InlineData("RMMMMMMMMMM", 0, 0)]
        public void UpdateGridPosition(string command, int expectedXPosition, int expectedYPosition)
        {
            _marsRover.RunCommand(command);
            Assert.Equal((int)_marsRover.Orientation, _grid[expectedXPosition,expectedYPosition]);
        }

        [Theory]
        [InlineData("M", "0:1:North")]
        [InlineData("R", "0:0:East")]
        [InlineData("L", "0:0:West")]
        [InlineData("MRMR", "1:1:South")]
        [InlineData("MLMR", "9:1:North")]
        [InlineData("MMMM", "0:4:North")]
        public void ProvideAFinalLocationOutput(string command, string expectedOutput)
        {
            var output = _marsRover.RunCommand(command);
            Assert.Equal(expectedOutput, output);
        }

        [Theory]
        [InlineData("MM", "0:0:1:North")]
        [InlineData("RMM", "0:1:0:East")]
        public void ReportAnEncounteredObstacle(string command, string expectedOutput)
        {
            _marsRover = new MarsRover(_gridObstacle);
            var output = _marsRover.RunCommand(command);
            Assert.Equal(expectedOutput, output);
        }
    }
}
