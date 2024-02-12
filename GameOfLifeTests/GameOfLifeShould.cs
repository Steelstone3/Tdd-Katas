using BankingKata;
using GameOfLife;
using Xunit;

namespace BankingKataTests
{
    public class GameOfLifeShould
    {
        // Rules
        // Any live cell with fewer than two live neighbours dies, as if caused by under-population.
        // Any live cell with two or three live neighbours lives on to the next generation.
        // Any live cell with more than three live neighbours dies, as if by overcrowding.
        // Any dead cell with exactly three live neighbours becomes a live cell

        // Split Arrays
        // bool[][] is a declaration of a split boolean array (array of arrays)
        // The first [] refers to the "Y Axis" or which of the bool arrays contained within the split array is being accessed
        // The second [] acts like the "X Axis" or which of the values from the selected array is being accessed
        // Split arrays require an index for both the "X" and "Y" of the array 
        // e.g game.Board[0][0] (accesses the top left corner)
        // e.g game.Board[5][6] (accesses the 5th array's 6th index)

        [Fact]
        public void DiesFromUnderpopulationLessThanTwoNeighbours1()
        {
            // Arrange
            bool[][] board = new bool[][]
            {
                new bool[] { false, false, false },
                new bool[] { false, true, false },
                new bool[] { false, false, false },
            };
            IGameOfLife game = new ConwaysGameOfLife(board);

            // Act
            game.NextGeneration();

            // Assert
            /*
                x-x-x
                x-x-x
                x-x-x
            */
            Assert.False(game.Board[1][1]);
        }

        [Fact]
        public void DiesFromUnderpopulationLessThanTwoNeighbours2()
        {
            // Arrange
            bool[][] board = new bool[][]
            {
                new bool[] { true, false, false },
                new bool[] { false, false, false },
                new bool[] { false, false, false },
            };
            IGameOfLife game = new ConwaysGameOfLife(board);

            // Act
            game.NextGeneration();

            // Assert
            /*
                x-x-x
                x-x-x
                x-x-x
            */
            Assert.False(game.Board[0][0]);
        }

        [Fact]
        public void SurviveToTheNextGenerationFromNeighbouringTwoOrThreeCells1()
        {
            // Arrange
            bool[][] board = new bool[][]
            {
            new bool[] { true, true, false },
            new bool[] { true, false, false },
            new bool[] { false, false, false },
            };
            IGameOfLife game = new ConwaysGameOfLife(board);

            // Act
            game.NextGeneration();

            // Assert
            /*
                o-o-x
                o-x-x
                x-x-x
            */
            Assert.True(game.Board[0][0]);
            Assert.True(game.Board[0][1]);
            Assert.True(game.Board[1][0]);
        }

        [Fact]
        public void SurviveToTheNextGenerationFromNeighbouringTwoOrThreeCells2()
        {
            // Arrange
            bool[][] board = new bool[][]
            {
            new bool[] { false, false, true },
            new bool[] { false, true, true },
            new bool[] { false, false, false },
            };
            IGameOfLife game = new ConwaysGameOfLife(board);

            // Act
            game.NextGeneration();

            // Assert
            /*
                x-x-o
                x-o-o
                x-x-x
            */
            Assert.True(game.Board[0][2]);
            Assert.True(game.Board[1][1]);
            Assert.True(game.Board[1][2]);
        }

        [Fact]
        public void DiesFromOvercrowdingWithMoreThanThreeNeighbours1()
        {
            // Arrange
            bool[][] board = new bool[][]
            {
            new bool[] { true, true, true },
            new bool[] { true, true, true },
            new bool[] { false, false, false },
            };
            IGameOfLife game = new ConwaysGameOfLife(board);

            // Act
            game.NextGeneration();

            // Assert
            /*
                o-x-o
                o-x-x
                x-x-x
            */
            Assert.True(game.Board[0][0]);
            Assert.False(game.Board[0][1]);
            Assert.True(game.Board[0][2]);
            Assert.True(game.Board[1][0]);
            Assert.False(game.Board[1][1]);
            Assert.False(game.Board[1][2]);
        }

        [Fact]
        public void DiesFromOvercrowdingWithMoreThanThreeNeighbours2()
        {
            // Arrange
            bool[][] board = new bool[][]
            {
            new bool[] { true, true, true },
            new bool[] { true, true, true },
            new bool[] { true, true, true },
            };
            IGameOfLife game = new ConwaysGameOfLife(board);

            // Act
            game.NextGeneration();

            // Assert
            /*
                o-x-o
                x-x-o
                x-o-o
            */
            Assert.True(game.Board[0][0]);
            Assert.False(game.Board[0][1]);
            Assert.True(game.Board[0][2]);
            Assert.False(game.Board[1][0]);
            Assert.False(game.Board[1][1]);
            Assert.True(game.Board[1][2]);
            Assert.False(game.Board[2][0]);
            Assert.True(game.Board[2][1]);
            Assert.True(game.Board[2][2]);
        }

        [Fact]
        public void ReproduceIfCorrectlyPopulatedOnTheNextGeneration1()
        {
            // Arrange
            bool[][] board = new bool[][]
            {
            new bool[] { false, false, false },
            new bool[] { false, true, true },
            new bool[] { false, true, false },
            };
            IGameOfLife game = new ConwaysGameOfLife(board);

            // Act
            game.NextGeneration();

            // Assert
            /*
                x-x-x
                x-o-o
                x-o-o
            */
            Assert.True(board[1][1]);
            Assert.True(board[1][2]);
            Assert.True(board[2][1]);
            Assert.True(board[2][2]);
        }

        [Fact]
        public void ReproduceIfCorrectlyPopulatedOnTheNextGeneration2()
        {
            // Arrange
            bool[][] board = new bool[][]
            {
            new bool[] { false, true, false },
            new bool[] { false, true, true },
            new bool[] { false, false, false },
            };
            IGameOfLife game = new ConwaysGameOfLife(board);

            // Act
            game.NextGeneration();

            // Assert
            /*
                x-o-o
                x-o-o
                x-x-x
            */
            Assert.True(board[0][1]);
            Assert.True(board[0][2]);
            Assert.True(board[1][1]);
            Assert.True(board[1][2]);
        }
    }
}