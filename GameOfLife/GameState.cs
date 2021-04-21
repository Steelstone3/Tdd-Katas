using System;

namespace GameOfLife
{
    public class GameState
    {
        public GameState(bool[,] startingState)
        {
            State = startingState;
        }

        public bool[,] State { get; private set; }
    }
}