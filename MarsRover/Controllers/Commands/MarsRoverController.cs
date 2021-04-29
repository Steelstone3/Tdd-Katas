using MarsRover.Contracts;
using MarsRover.States;

namespace MarsRover.Controllers.Commands
{
    public class MarsRoverCommands
    {
        private int[,] _grid;
        private readonly char[] directions = new char[] { 'N', 'E', 'S', 'W' };

        public MarsRoverCommands(int[,] grid)
        {
            _grid = grid;
        }

        public string ExecuteAllCommands(IState state)
        {
            string result = string.Empty;

            foreach(var command in state.Commands)
            {
                result = CommandMarsRover(command, state.CurrentDirection, state.CurrentXCoordinate, state.CurrentYCoordinate);
            }
            
            return result;
        }

        private string CommandMarsRover(char command, char direction, int currentXCoordinate, int currentYCoordinate)
        {
            switch (command)
            {
                case ('L'):
                    return new TurnLeftCommand(directions).ExecuteCommandString(direction, currentXCoordinate, currentYCoordinate);
                case ('R'):
                    return new TurnRightCommand(directions).ExecuteCommandString(direction, currentXCoordinate, currentYCoordinate);
                case('M'):
                    return new MoveCommand(_grid).ExecuteCommandString(direction, currentXCoordinate, currentYCoordinate);
                default:
                    return null;
            }
        }
    }
}