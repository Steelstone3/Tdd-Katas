using MarsRover.Controllers;
using MarsRover.Controllers.Commands;
using MarsRover.Models;

using MarsRover.States;
using Xunit;

namespace MarsRoverTests
{


    public class MarsRoverUnitTests
    {
        //1 north, 2 east, 3 south, 4 west
        private int[,] grid = new int[10, 10]
        {
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        };

        //Generate a grid for the mars rover
        [Fact]
        public void SetupMarsRoverWorld()
        {
            var world = new WorldModel(grid);

            Assert.Equal(grid, world.Grid);
        }

        [Fact]
        public void SetupMarsRoverDefaultState()
        {
            var initialState = new MarsRoverDefaultState('N', 1, 1, string.Empty);

            var marsRoverState = new MarsRoverDefaultState(initialState);

            Assert.Equal('N', initialState.CurrentDirection );
            Assert.Equal(1, initialState.CurrentXCoordinate);
            Assert.Equal(1, initialState.CurrentYCoordinate );
            Assert.Equal(string.Empty, initialState.Commands );

            Assert.Equal(initialState.CurrentDirection, marsRoverState.CurrentDirection);
            Assert.Equal(initialState.CurrentXCoordinate, marsRoverState.CurrentXCoordinate);
            Assert.Equal(initialState.CurrentYCoordinate, marsRoverState.CurrentYCoordinate);
            Assert.Equal(initialState.Commands, marsRoverState.Commands);
        }

        [Theory]
        [InlineData('N', "L", 0, 0, "W:0:0")]
        [InlineData('W', "L", 0, 0, "S:0:0")]
        [InlineData('S', "L", 0, 0, "E:0:0")]
        [InlineData('E', "L", 0, 0, "N:0:0")]
        [InlineData('N', "LLLLL", 0, 0, "W:0:0")]
        [InlineData('N', "R", 0, 0, "E:0:0")]
        [InlineData('E', "R", 0, 0, "S:0:0")]
        [InlineData('S', "R", 0, 0, "W:0:0")]
        [InlineData('W', "R", 0, 0, "N:0:0")]
        [InlineData('N', "RRRRR", 0, 0, "E:0:0")]
        [InlineData('N', "LLLRRRR", 0, 0, "E:0:0")]
        [InlineData('N', "RRRLLLL", 0, 0, "W:0:0")]
        [InlineData('W', "RLL", 0, 0, "S:0:0")]
        [InlineData('S', "LLR", 0, 0, "W:0:0")]
        public void UpdateMarsRoverDirection(char direction, string commands, int currentXCoordinate, int currentYCoordinate, string expectedResult)
        {
            var marsRoverCommands = new MarsRoverCommands(grid);

            var state = new MarsRoverDefaultState(direction, currentXCoordinate, currentYCoordinate, commands);

            Assert.Equal(expectedResult, marsRoverCommands.ExecuteAllCommands(state));
        }

        [Theory]
        [InlineData('N', "M", 1, 1, "N:1:2")]
        [InlineData('N', "M", 0, 9, "N:0:0")]
        [InlineData('E', "M", 1, 1, "E:2:1")]
        [InlineData('E', "M", 9, 0, "E:0:0")]
        [InlineData('S', "M", 1, 1, "S:1:0")]
        [InlineData('S', "M", 0, 0, "S:0:9")]
        [InlineData('W', "M", 1, 1, "W:0:1")]
        [InlineData('W', "M", 0, 0, "W:9:0")]
        public void UpdateMarsRoverPosition(char direction, string commands, int currentXCoordinate, int currentYCoordinate, string expectedResult)
        {
            var marsRoverCommands = new MarsRoverCommands(grid);

            var state = new MarsRoverDefaultState(direction, currentXCoordinate, currentYCoordinate, commands);

            Assert.Equal(expectedResult, marsRoverCommands.ExecuteAllCommands(state));
        }


        [Theory]
        //Foreach initial direction
        [InlineData('N', "LM", 1, 1, "W:0:1")]
        [InlineData('N', "ML", 1, 1, "W:1:2")]
        [InlineData('N', "RM", 1, 1, "E:2:1")]
        [InlineData('N', "MR", 1, 1, "E:1:2")]
        
        [InlineData('E', "LM", 1, 1, "N:1:2")]
        [InlineData('E', "ML", 1, 1, "N:2:1")]
        [InlineData('E', "RM", 1, 1, "S:1:0")]
        [InlineData('E', "MR", 1, 1, "S:2:1")]
        
        //Check bounds
        [InlineData('N', "LM", 0, 0, "W:9:0")]
        [InlineData('N', "RM", 9, 0, "E:1:0")]

        [InlineData('E', "LM", 0, 0, "N:0:0")]
        [InlineData('E', "RM", 0, 0, "S:0:9")]
        


        //[InlineData('S', "LM", 1, 1, "W:1:1")]
        //[InlineData('S', "RM", 1, 1, "W:1:1")]
        //[InlineData('W', "LM", 1, 1, "W:1:1")]
        //[InlineData('W', "RM", 1, 1, "W:1:1")]
        public void ExecuteStringOfCommands(char direction, string commands, int currentXCoordinate, int currentYCoordinate, string expectedResult)
        {
            var marsRoverCommands = new MarsRoverCommands(grid);

            var state = new MarsRoverDefaultState(direction, currentXCoordinate, currentYCoordinate, commands);

            Assert.Equal(expectedResult, marsRoverCommands.ExecuteAllCommands(state));
        }

    }
}
