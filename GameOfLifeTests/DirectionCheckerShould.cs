using GameOfLife;
using Xunit;

namespace GameOfLifeTests
{
    public class DirectionCheckerShould
    {
        private readonly bool[][] deadBoard = new bool[][]
        {
            new bool[] { false, false, false },
            new bool[] { false, true, false },
            new bool[] { false, false, false },
        };

        [Fact]
        public void CheckUp()
        {
            // Arrange
            bool[][] board = new bool[][]
            {
                new bool[] { false, true, false },
                new bool[] { false, true, false },
                new bool[] { false, false, false },
            };
            DirectionChecker directionChecker = new(board);

            // Act
            int isAliveCount = directionChecker.CheckUp(1, 1);

            // Assert
            Assert.Equal(1, isAliveCount);
        }

        [Fact]
        public void CheckUpIsDead()
        {
            // Arrange
            DirectionChecker directionChecker = new(deadBoard);

            // Act
            int isAliveCount = directionChecker.CheckUp(1, 1);

            // Assert
            Assert.Equal(0, isAliveCount);
        }

        [Fact]
        public void CheckUpOutOfBounds()
        {
            // Arrange
            bool[][] board = new bool[][]
            {
                new bool[] { false, true, false },
                new bool[] { false, false, false },
                new bool[] { false, false, false },
            };
            DirectionChecker directionChecker = new(board);

            // Act
            int isAliveCount = directionChecker.CheckUp(1, 0);

            // Assert
            Assert.Equal(0, isAliveCount);
        }

        [Fact]
        public void CheckDown()
        {
            // Arrange
            bool[][] board = new bool[][]
            {
                new bool[] { false, false, false },
                new bool[] { false, true, false },
                new bool[] { false, true, false },
            };
            DirectionChecker directionChecker = new(board);

            // Act
            int isAliveCount = directionChecker.CheckDown(1, 1);

            // Assert
            Assert.Equal(1, isAliveCount);
        }

        [Fact]
        public void CheckDownIsDead()
        {
            // Arrange
            DirectionChecker directionChecker = new(deadBoard);

            // Act
            int isAliveCount = directionChecker.CheckDown(1, 1);

            // Assert
            Assert.Equal(0, isAliveCount);
        }

        [Fact]
        public void CheckDownOutOfBounds()
        {
            // Arrange
            bool[][] board = new bool[][]
            {
                new bool[] { false, false, false },
                new bool[] { false, false, false },
                new bool[] { false, true, false },
            };
            DirectionChecker directionChecker = new(board);

            // Act
            int isAliveCount = directionChecker.CheckDown(1, 2);

            // Assert
            Assert.Equal(0, isAliveCount);
        }

        [Fact]
        public void CheckLeft()
        {
            // Arrange
            bool[][] board = new bool[][]
            {
                new bool[] { false, false, false },
                new bool[] { true, true, false },
                new bool[] { false, false, false },
            };
            DirectionChecker directionChecker = new(board);

            // Act
            int isAliveCount = directionChecker.CheckLeft(1, 1);

            // Assert
            Assert.Equal(1, isAliveCount);
        }

        [Fact]
        public void CheckLeftIsDead()
        {
            // Arrange
            DirectionChecker directionChecker = new(deadBoard);

            // Act
            int isAliveCount = directionChecker.CheckLeft(1, 1);

            // Assert
            Assert.Equal(0, isAliveCount);
        }

        [Fact]
        public void CheckLeftOutOfBounds()
        {
            // Arrange
            bool[][] board = new bool[][]
            {
                new bool[] { false, false, false },
                new bool[] { true, false, false },
                new bool[] { false, false, false },
            };
            DirectionChecker directionChecker = new(board);

            // Act
            int isAliveCount = directionChecker.CheckLeft(0, 1);

            // Assert
            Assert.Equal(0, isAliveCount);
        }

        [Fact]
        public void CheckRight()
        {
            // Arrange
            bool[][] board = new bool[][]
            {
                new bool[] { false, false, false },
                new bool[] { false, true, true },
                new bool[] { false, false, false },
            };
            DirectionChecker directionChecker = new(board);

            // Act
            int isAliveCount = directionChecker.CheckRight(1, 1);

            // Assert
            Assert.Equal(1, isAliveCount);
        }

        [Fact]
        public void CheckRightIsDead()
        {
            // Arrange
            DirectionChecker directionChecker = new(deadBoard);

            // Act
            int isAliveCount = directionChecker.CheckRight(1, 1);

            // Assert
            Assert.Equal(0, isAliveCount);
        }

        [Fact]
        public void CheckRightOutOfBounds()
        {
            // Arrange
            bool[][] board = new bool[][]
            {
                new bool[] { false, false, false },
                new bool[] { false, false, true },
                new bool[] { false, false, false },
            };
            DirectionChecker directionChecker = new(board);

            // Act
            int isAliveCount = directionChecker.CheckRight(2, 1);

            // Assert
            Assert.Equal(0, isAliveCount);
        }

        [Fact]
        public void CheckTopRight()
        {
            // Arrange
            bool[][] board = new bool[][]
            {
                new bool[] { false, false, true },
                new bool[] { false, true, false },
                new bool[] { false, false, false },
            };
            DirectionChecker directionChecker = new(board);

            // Act
            int isAliveCount = directionChecker.CheckTopRight(1, 1);

            // Assert
            Assert.Equal(1, isAliveCount);
        }

        [Fact]
        public void CheckTopRightIsDead()
        {
            // Arrange
            DirectionChecker directionChecker = new(deadBoard);

            // Act
            int isAliveCount = directionChecker.CheckTopRight(1, 1);

            // Assert
            Assert.Equal(0, isAliveCount);
        }

        [Fact]
        public void CheckTopRightOutOfBounds()
        {
            // Arrange
            bool[][] board = new bool[][]
            {
                new bool[] { false, false, true },
                new bool[] { false, false, false },
                new bool[] { false, false, false },
            };
            DirectionChecker directionChecker = new(board);

            // Act
            int isAliveCount = directionChecker.CheckTopRight(2, 0);

            // Assert
            Assert.Equal(0, isAliveCount);
        }

        [Fact]
        public void CheckTopLeft()
        {
            // Arrange
            bool[][] board = new bool[][]
            {
                new bool[] { true, false, false },
                new bool[] { false, true, false },
                new bool[] { false, false, false },
            };
            DirectionChecker directionChecker = new(board);

            // Act
            int isAliveCount = directionChecker.CheckTopLeft(1, 1);

            // Assert
            Assert.Equal(1, isAliveCount);
        }

        [Fact]
        public void CheckTopLeftIsDead()
        {
            // Arrange
            DirectionChecker directionChecker = new(deadBoard);

            // Act
            int isAliveCount = directionChecker.CheckTopLeft(1, 1);

            // Assert
            Assert.Equal(0, isAliveCount);
        }

        [Fact]
        public void CheckTopLeftOutOfBounds()
        {
            // Arrange
            bool[][] board = new bool[][]
            {
                new bool[] { true, false, false },
                new bool[] { false, false, false },
                new bool[] { false, false, false },
            };
            DirectionChecker directionChecker = new(board);

            // Act
            int isAliveCount = directionChecker.CheckTopLeft(0, 0);

            // Assert
            Assert.Equal(0, isAliveCount);
        }

        [Fact]
        public void CheckBottomLeft()
        {
            // Arrange
            bool[][] board = new bool[][]
            {
                new bool[] { false, false, false },
                new bool[] { false, true, false },
                new bool[] { true, false, false },
            };
            DirectionChecker directionChecker = new(board);

            // Act
            int isAliveCount = directionChecker.CheckBottomLeft(1, 1);

            // Assert
            Assert.Equal(1, isAliveCount);
        }

        [Fact]
        public void CheckBottomLeftIsDead()
        {
            // Arrange
            DirectionChecker directionChecker = new(deadBoard);

            // Act
            int isAliveCount = directionChecker.CheckBottomLeft(1, 1);

            // Assert
            Assert.Equal(0, isAliveCount);
        }

        [Fact]
        public void CheckBottomLeftOutOfBounds()
        {
            // Arrange
            bool[][] board = new bool[][]
            {
                new bool[] { false, false, false },
                new bool[] { false, false, false },
                new bool[] { true, false, false },
            };
            DirectionChecker directionChecker = new(board);

            // Act
            int isAliveCount = directionChecker.CheckBottomLeft(0, 2);

            // Assert
            Assert.Equal(0, isAliveCount);
        }

        [Fact]
        public void CheckBottomRight()
        {
            // Arrange
            bool[][] board = new bool[][]
            {
                new bool[] { false, false, false },
                new bool[] { false, true, false },
                new bool[] { false, false, true },
            };
            DirectionChecker directionChecker = new(board);

            // Act
            int isAliveCount = directionChecker.CheckBottomRight(1, 1);

            // Assert
            Assert.Equal(1, isAliveCount);
        }

        [Fact]
        public void CheckBottomRightIsDead()
        {
            // Arrange
            DirectionChecker directionChecker = new(deadBoard);

            // Act
            int isAliveCount = directionChecker.CheckBottomRight(1, 1);

            // Assert
            Assert.Equal(0, isAliveCount);
        }

        [Fact]
        public void CheckBottomRightOutOfBounds()
        {
            // Arrange
            bool[][] board = new bool[][]
            {
                new bool[] { false, false, false },
                new bool[] { false, false, false },
                new bool[] { false, false, true },
            };
            DirectionChecker directionChecker = new(board);

            // Act
            int isAliveCount = directionChecker.CheckBottomRight(2, 2);

            // Assert
            Assert.Equal(0, isAliveCount);
        }
    }
}