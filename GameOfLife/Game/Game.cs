using System.Linq;
using GameOfLife.Controllers;
using GameOfLife.Controllers.ConditionControllers;

namespace GameOfLife
{
    public class Game
    {
        public GameState GameState { get; set; }

        //TODO AH need to refactor for loops to surround this once then test the whole?
        public void NextGeneration()
        {
            var conditionCommands = new ConditionsController(GameState).CreateCommands();

            for (int x = 0; x < GameState.State.GetLength(1) - 1; x++)
            {
                for (int y = 0; y < GameState.State.GetLength(0) - 1; y++)
                {
                    foreach(var condition in conditionCommands)
                    {
                        condition.CheckCondition(x,y);
                    }
                }
            }

            GameState.UpdateCurrentState();
        }
    }
}