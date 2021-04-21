using GameOfLife.Contracts;

namespace GameOfLife.Controllers.ConditionControllers
{
    public class CheckCorrectPopulationController : ICheckConditionCommand
    {
        private GameState _gameState;

        public CheckCorrectPopulationController(GameState gameState)
        {
            _gameState = gameState;
        }

        public void CheckCondition(int x, int y)
        {
            _gameState.NextState[x, y] = AliveFromCorrectPopulation(x, y);
        }

        private bool AliveFromCorrectPopulation(int x, int y)
        {
            var isAlive = _gameState.State[x, y];

            if (isAlive && (new AliveCellFinderController(_gameState).AliveSurroundingCells(x, y) == 2
                         || new AliveCellFinderController(_gameState).AliveSurroundingCells(x, y) == 3))
            {
                return true;
            }

            return false;
        }
    }
}