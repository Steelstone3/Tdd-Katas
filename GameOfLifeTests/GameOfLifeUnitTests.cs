using Xunit;
using GameOfLife;

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
        public void CellDeathUnderPopulationCondition()
        {
            var game = new Game()
            {
                GameState = new GameState(GameOfLifeTestHelper._underPopulationStartingState1),
            };

            game.CheckUnderPopulationCondition();

            Assert.Equal(GameOfLifeTestHelper._underPopulationEndingState1, game.GameState.State);
        }

        //Any live cell with two or three live neighbours lives on to the next generation.
        [Fact]
        public void CellLivesCorrectPopulationCondition()
        {
            var game = new Game()
            {
                GameState = new GameState(GameOfLifeTestHelper._correctPopulationStartingState1),
            };

            game.CheckCorrectPopulationConditions();

            Assert.Equal(GameOfLifeTestHelper._correctPopulationEndingState1, game.GameState.State);
        }

        //Any live cell with more than three live neighbours dies, as if by overcrowding.
        [Fact]
        public void CellDeathOverPopulationCondition()
        {
            var game = new Game()
            {
                GameState = new GameState(GameOfLifeTestHelper._overPopulationStartingState1),
            };

            game.CheckOverPopulationCondition();

            Assert.Equal(GameOfLifeTestHelper._overPopulationEndingState1, game.GameState.State);
        }

        //Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.
        [Fact]
        public void CellReproductionCondition()
        {
            var game = new Game()
            {
                GameState = new GameState(GameOfLifeTestHelper._repoductionStartingState1),
            };

            game.CheckReproductionCondition();

            Assert.Equal(GameOfLifeTestHelper._repoductionEndingState1, game.GameState.State);
        }

        //Intergration test
        /*[Fact]
        public void IntergrationTest()
        {
            var game = new Game()
            {
                GameState = new GameState(GameOfLifeTestHelper._uberStartingState1),
            };

            game.CheckRepoductionCondition();

            Assert.Equal(GameOfLifeTestHelper._uberEndingState1, game.GameState.State);
        }*/
    }
}
