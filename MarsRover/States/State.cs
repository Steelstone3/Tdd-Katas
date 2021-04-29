using MarsRover.Contracts;

namespace MarsRover.States
{
    public abstract class State : IState
    {
        public char CurrentDirection { get; set; }
        public int CurrentXCoordinate { get; set; }
        public int CurrentYCoordinate { get; set; }
        public string Commands { get; set; }

        public State(char direction, int currentXCoordinate, int currentYCoordinate, string commands)
        {
            CurrentDirection = direction;
            CurrentXCoordinate = currentXCoordinate;
            CurrentYCoordinate = currentYCoordinate;
            Commands = commands;
        }

        public State(IState state)
        {
            CurrentDirection = state.CurrentDirection;
            CurrentXCoordinate = state.CurrentXCoordinate;
            CurrentYCoordinate = state.CurrentYCoordinate;
            Commands = state.Commands;
        }

        public abstract void UpdateState();

        public abstract void NextState();
    }
}