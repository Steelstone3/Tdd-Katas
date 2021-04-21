using GameOfLife.Contracts;

namespace GameOfLife.Controllers.ConditionControllers
{
    public class CheckUnderPopulationController : ICheckConditionCommand
    {
        private GameState _gameState;

        public CheckUnderPopulationController(GameState gameState)
        {
            _gameState = gameState;
        }

        public void CheckCondition(int x, int y)
        {
            _gameState.NextState[x, y] = DeathFromUnderPopulation(x, y);
        }

        private bool DeathFromUnderPopulation(int x, int y)
        {
            if (new AliveCellFinderController(_gameState).AliveSurroundingCells(x, y) < 2)
            {
                return false;
            }

            return true;
        }
    }
}