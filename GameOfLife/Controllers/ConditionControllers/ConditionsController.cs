using System.Collections.Generic;
using GameOfLife.Contracts;

namespace GameOfLife.Controllers.ConditionControllers
{
    public class ConditionsController
    {
        private GameState _gameState;

        public ConditionsController(GameState gameState)
        {
            _gameState = gameState;
        }

        public List<ICheckConditionCommand> CreateCommands()
        {
            return new List<ICheckConditionCommand>()
            {
                new CheckUnderPopulationController(_gameState),
                new CheckCorrectPopulationController(_gameState),
                new CheckOverPopulationController(_gameState),
                new CheckReproductionController(_gameState),
            };
        }
    }
}