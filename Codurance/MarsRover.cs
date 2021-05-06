using System;
using System.Collections.Generic;
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

        public void RunCommand(string commandString)
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
                        UpdateCoordinates(coordinates);
                        break;
                    default:
                        break;
                }
            }
        }

        private void UpdateCoordinates(Tuple<int,int> coordinates)
        {
            PositionX = coordinates.Item1;
            PositionY = coordinates.Item2;
        }
    }
}