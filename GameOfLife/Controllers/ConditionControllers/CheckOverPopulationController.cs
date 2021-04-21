using GameOfLife.Contracts;

namespace GameOfLife.Controllers.ConditionControllers
{
    public class CheckOverPopulationController : ICheckConditionCommand
    {
        private GameState _gameState;

        public CheckOverPopulationController(GameState gameState)
        {
            _gameState = gameState;
        }

        public void CheckCondition(int x, int y)
        {
            _gameState.NextState[x, y] = DeathFromOverPopulation(x, y);
        }

        private bool DeathFromOverPopulation(int x, int y)
        {
            if (new AliveCellFinderController(_gameState).AliveSurroundingCells(x, y) > 3)
            {
                return false;
            }

            return true;
        }
    }
}