using System;
using Codurance.Commands;
using Codurance.Commands.MovementCommands;
using static Codurance.Directions.Directions;

namespace Codurance
{
    public class MarsRover
    {
        private int[,] _grid;

        public MarsRover(int[,] grid)
        {
            _grid = grid;
            PositionX = 0;
            PositionY = 0;
            Orientation = Direction.North;
        }

        public int PositionX { get; private set; }
        public int PositionY { get; private set; }
        public Direction Orientation { get; private set; }

        public string RunCommand(string commandString)
        {
            foreach (var command in commandString)
            {
                switch (command)
                {
                    case 'L':
                        Orientation = new TurnLeftCommand().ExecuteTurnCommand(Orientation);
                        break;
                    case 'R':
                        Orientation = new TurnRightCommand().ExecuteTurnCommand(Orientation);
                        break;
                    case 'M':
                        var coordinates = new MoveCommand().ExecuteMoveCommand(Orientation, PositionX, PositionY);
                        if(UpdateCoordinates(coordinates))
                        {
                            return OutputResult(true);
                        }
                        break;
                    default:
                        break;
                }
            }

            return OutputResult(false);
        }

        private bool UpdateCoordinates(Tuple<int, int> coordinates)
        {
            if (IsObstacleHit(coordinates))
            {
                _grid[PositionX, PositionY] = 0;

                UpdatePosition(coordinates);

                _grid[PositionX, PositionY] = (int)Orientation;

                return false;
            }

            return true;
        }

        private bool IsObstacleHit(Tuple<int, int> coordinates) => _grid[coordinates.Item1, coordinates.Item2] != 5;

        private void UpdatePosition(Tuple<int, int> coordinates)
        {
            PositionX = coordinates.Item1;
            PositionY = coordinates.Item2;
        }

        private string OutputResult(bool isObstacleHit)
        {
            if(isObstacleHit)
            {
                return $"0:{PositionX}:{PositionY}:{Orientation}";
            }
            
            return $"{PositionX}:{PositionY}:{Orientation}";
        }
    }
}