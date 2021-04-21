using Xunit;
using GameOfLife;
using GameOfLife.Controllers;
using GameOfLife.Controllers.ConditionControllers;

namespace GameOfLifeTests
{
    //The universe of the Game of Life is an infinite two-dimensional orthogonal grid of square cells, each of which is in one of two possible states: alive or dead. Every cell interacts with its eight neighbours, which are the cells that are horizontally, vertically, or diagonally adjacent to it. At each step in time, the following transitions occur:

    public class GameOfLifeUnitTests
    {
        //Create initial state
        [Fact]
        public void TheGameOfLifeGeneration()
        {
            var startingState = GameOfLifeTestHelper._uberStartingState1;

            Assert.Equal(startingState, new GameState(startingState).State);
        }

        //Any live cell with fewer than two live neighbours dies, as if caused by under-population.
        [Fact]
        public void CellDeathUnderPopulationCondition1()
        {
            var game = new Game()
            {
                GameState = new GameState(GameOfLifeTestHelper._underPopulationStartingState1),
            };

            //TODO AH can probably tidy up this for loop
            for (int x = 0; x < game.GameState.State.GetLength(1) - 1; x++)
            {
                for (int y = 0; y < game.GameState.State.GetLength(0) - 1; y++)
                {
                    new CheckUnderPopulationController(game.GameState).CheckCondition(x, y);
                }
            }

            Assert.Equal(GameOfLifeTestHelper._underPopulationEndingState1, game.GameState.State);
        }

        //Any live cell with two or three live neighbours lives on to the next generation.
        [Fact]
        public void CellLivesCorrectPopulationCondition1()
        {
            var game = new Game()
            {
                GameState = new GameState(GameOfLifeTestHelper._correctPopulationStartingState1),
            };

            for (int x = 0; x < game.GameState.State.GetLength(1) - 1; x++)
            {
                for (int y = 0; y < game.GameState.State.GetLength(0) - 1; y++)
                {
                    new CheckCorrectPopulationController(game.GameState).CheckCondition(x, y);
                }
            }

            Assert.Equal(GameOfLifeTestHelper._correctPopulationEndingState1, game.GameState.State);
        }

        //Any live cell with more than three live neighbours dies, as if by overcrowding.
        [Fact]
        public void CellDeathOverPopulationCondition1()
        {
            var game = new Game()
            {
                GameState = new GameState(GameOfLifeTestHelper._overPopulationStartingState1),
            };

            for (int x = 0; x < game.GameState.State.GetLength(1) - 1; x++)
            {
                for (int y = 0; y < game.GameState.State.GetLength(0) - 1; y++)
                {
                    new CheckOverPopulationController(game.GameState).CheckCondition(x, y);
                }
            }

            Assert.Equal(GameOfLifeTestHelper._overPopulationEndingState1, game.GameState.State);
        }

        //Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.
        [Fact]
        public void CellReproductionCondition1()
        {
            var game = new Game()
            {
                GameState = new GameState(GameOfLifeTestHelper._repoductionStartingState1),
            };

            for (int x = 0; x < game.GameState.State.GetLength(1) - 1; x++)
            {
                for (int y = 0; y < game.GameState.State.GetLength(0) - 1; y++)
                {
                    new CheckReproductionController(game.GameState).CheckCondition(x, y);
                }
            }

            Assert.Equal(GameOfLifeTestHelper._repoductionEndingState1, game.GameState.State);
        }

        //Checks for all alive surround cells
        [Fact]
        public void SurroundingAliveCells()
        {
            var game = new Game()
            {
                GameState = new GameState(GameOfLifeTestHelper._uberStartingState1),
            };

            var result1 = new AliveCellFinderController(game.GameState).AliveSurroundingCells(1, 1);
            var result2 = new AliveCellFinderController(game.GameState).AliveSurroundingCells(4, 4);

            Assert.Equal(1, result1);
            Assert.Equal(2, result2);
        }

        //Intergration test
        /*[Fact]
        public void IntergrationTest()
        {
            var game = new Game()
            {
                GameState = new GameState(GameOfLifeTestHelper._uberStartingState1),
            };

            game.NextGeneration();

            Assert.Equal(GameOfLifeTestHelper._uberEndingState1, game.GameState.State);
        }*/
    }
}
