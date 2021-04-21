using System;

namespace GameOfLife
{
    public class GameState
    {
        public GameState(bool[,] startingState)
        {
            State = startingState;
            NextState = startingState;
        }

        public bool[,] State { get; private set; }
        
        public bool[,] NextState { get; set; }

        public void UpdateCurrentState()
        {
            State = (bool[,])NextState.Clone();
        }
    }
}