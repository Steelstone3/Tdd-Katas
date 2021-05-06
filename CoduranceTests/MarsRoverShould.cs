using System;
using Codurance;
using Xunit;
using static Codurance.Directions.Directions;

namespace CoduranceTests
{
    public class MarsRoverShould
    {
        private int[,] _grid = new int[,]
        {
            {0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0},
            {1,0,0,0,0,0,0,0,0,0},
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
        [InlineData("MMMMMMMMMMM", 0, 0)]
        [InlineData("RMMMMMMMMMMM", 0, 0)]
        public void Move(string command, int expectedXPosition, int expectedYPosition)
        {
            _marsRover.RunCommand(command);
            Assert.Equal(expectedXPosition, _marsRover.PositionX);
            Assert.Equal(expectedYPosition, _marsRover.PositionY);
        }
    }
}
