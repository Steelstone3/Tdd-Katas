using MarsRover.Contracts;

namespace MarsRover.States
{
    public class MarsRoverDefaultState : State
    {
        public MarsRoverDefaultState(char direction, int currentXCoordinate, int currentYCoordinate, string commands) : base(direction, currentXCoordinate, currentYCoordinate, commands)
        {
            CurrentDirection = direction;
            CurrentXCoordinate = currentXCoordinate;
            CurrentYCoordinate = currentYCoordinate;
            Commands = commands;

            UpdateState();
        }

        public MarsRoverDefaultState(IState state) : base(state)
        {
            CurrentDirection = state.CurrentDirection;
            CurrentXCoordinate = state.CurrentXCoordinate;
            CurrentYCoordinate = state.CurrentYCoordinate;
            Commands = state.Commands;

            UpdateState();
        }

        public override void UpdateState()
        {
            if(!string.IsNullOrWhiteSpace(Commands))
            {
                NextState();
            }
        }

        public override void NextState()
        {
            
        }

    }
}