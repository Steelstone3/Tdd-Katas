using System.Collections.Generic;
using System.Linq;

namespace GameOfLife.Controllers
{
    public class AliveCellFinderController
    {
        private GameState _gameState;

        public AliveCellFinderController(GameState gameState)
        {
            _gameState = gameState;
        }

        public List<bool> AliveSurroundingCells(int x, int y)
        {
            var surroundingCells = LocateSurroundingCells(x, y);

            return surroundingCells.Where(x => x == true).ToList();
        }

        //TODO AH This has bugs in it
        //TODO AH This doesn't anticipate +1 overflows :O
        //TODO AH Maybe all of this can be scrapped check the kata for there answer!
        //TODO AH Also uints to think about not ints...
        private List<bool> LocateSurroundingCells(int x, int y)
        {
            var surroundingCells = new List<bool>(8)
            {
                    //right, below
                    _gameState.State[x + 1, y],
                    _gameState.State[x, y + 1],

                    //right ↓
                    _gameState.State[x + 1, y + 1],
            };

            if (x > 0 && y > 0)
            {
                //left ↑
                surroundingCells.Add(_gameState.State[x - 1, y - 1]);
            }
            if (x > 0)
            {
                //left, left ↓
                surroundingCells.Add(_gameState.State[x - 1, y]);
                surroundingCells.Add(_gameState.State[x - 1, y + 1]);
            }
            if (y > 0)
            {
                //above, right ↑
                surroundingCells.Add(_gameState.State[x, y - 1]);
                surroundingCells.Add(_gameState.State[x + 1, y - 1]);
            }

            return surroundingCells;
        }     
    }
}

 