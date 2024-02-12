using System;
using MarsRover.Models;

namespace MarsRover.Controllers;

public class Position : IPosition
{
    public Position(int x, int y)
    {
        X = x;
        Y = y;

        ValidatePosition();
    }

    public int X { get; private set; }
    public int Y { get; private set; }

    public void Move(IDirection direction)
    {
        switch (direction.CurrentDirection)
        {
            case Cardinal.North:
                Y++;
                if (Y > 10)
                    Y = 0;
                break;
            case Cardinal.East:
                X++;
                if (X > 10)
                    X = 0;
                break;
            case Cardinal.South:
                Y--;
                if (Y < 0)
                    Y = 10;
                break;
            case Cardinal.West:
                X--;
                if (X < 0)
                    X = 10;
                break;
            default:
                throw new ArgumentException("Direction should only be N, E, S or W", nameof(direction));
        }
    }

    private void ValidatePosition()
    {
        if (X is > 10 or < 0)
            X = 0;
        if (Y is > 10 or < 0)
            Y = 0;
    }
}