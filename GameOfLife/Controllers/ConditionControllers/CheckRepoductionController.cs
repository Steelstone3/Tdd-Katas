using GameOfLife.Contracts;

namespace GameOfLife.Controllers.ConditionControllers
{
    public class CheckReproductionController : ICheckConditionCommand
    {
        private GameState _gameState;

        public CheckReproductionController(GameState gameState)
        {
            _gameState = gameState;
        }

        public void CheckCondition(int x, int y)
        {
            _gameState.NextState[x, y] = RepopulatePopulation(x, y);
        }

        private bool RepopulatePopulation(int x, int y)
        {
            if (new AliveCellFinderController(_gameState).AliveSurroundingCells(x, y) == 3)
            {
                return true;
            }

            return _gameState.State[x, y];
        }
    }
}