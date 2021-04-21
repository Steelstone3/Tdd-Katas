using System.Linq;
using GameOfLife.Controllers;

namespace GameOfLife
{
    public class Game
    {
        public GameState GameState { get; set; }

        //TODO AH need to refactor for loops to surround this once then test the whole?
        public void NextGeneration()
        {
            CheckUnderPopulationCondition();
            CheckCorrectPopulationConditions();
            CheckOverPopulationCondition();
            CheckReproductionCondition();
        }

        public void CheckUnderPopulationCondition()
        {
            for (int x = 0; x < GameState.State.GetLength(1) - 1; x++)
            {
                for (int y = 0; y < GameState.State.GetLength(0) - 1; y++)
                {
                    GameState.State[x, y] = DeathFromUnderPopulation(x, y);
                }
            }
        }

        public void CheckCorrectPopulationConditions()
        {
            for (int x = 0; x < GameState.State.GetLength(1) - 1; x++)
            {
                for (int y = 0; y < GameState.State.GetLength(0) - 1; y++)
                {
                    GameState.State[x, y] = AliveFromCorrectPopulation(x, y);
                }
            }
        }

        public void CheckOverPopulationCondition()
        {
            for (int x = 0; x < GameState.State.GetLength(1) - 1; x++)
            {
                for (int y = 0; y < GameState.State.GetLength(0) - 1; y++)
                {
                    GameState.State[x, y] = DeathFromOverPopulation(x, y);
                }
            }
        }

        public void CheckReproductionCondition()
        {
             for (int x = 0; x < GameState.State.GetLength(1) - 1; x++)
            {
                for (int y = 0; y < GameState.State.GetLength(0) - 1; y++)
                {
                    GameState.State[x, y] = RepopulatePopulation(x, y);
                }
            }
        }

        private bool DeathFromUnderPopulation(int x, int y)
        {
            if (new AliveCellFinderController(GameState).AliveSurroundingCells(x, y).Count < 2)
            {
                return false;
            }

            return true;
        }

        private bool AliveFromCorrectPopulation(int x, int y)
        {
            var isAlive = GameState.State[x,y];

            if (isAlive && (new AliveCellFinderController(GameState).AliveSurroundingCells(x, y).Count == 2
                         || new AliveCellFinderController(GameState).AliveSurroundingCells(x, y).Count == 3))
            {
                return true;
            }

            return false;
        }

        private bool DeathFromOverPopulation(int x, int y)
        {
            if (new AliveCellFinderController(GameState).AliveSurroundingCells(x, y).ToList().Count > 3)
            {
                return false;
            }

            return true;
        }

        private bool RepopulatePopulation(int x, int y)
        {
            if (new AliveCellFinderController(GameState).AliveSurroundingCells(x, y).Count == 3)
            {
                return true;
            }

            return GameState.State[x,y];;
        }
    }
}