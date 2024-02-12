using System;
using MarsRover.Models;

namespace MarsRover.Controllers;

public class Direction : IDirection
{
    public Direction(Cardinal direction)
    {
        CurrentDirection = direction;
    }

    public Cardinal CurrentDirection { get; private set; }

    public void Turn(char command)
    {
        switch (command)
        {
            case 'L':
                TurnLeft();
                break;
            case 'R':
                TurnRight();
                break;
            default:
                throw new ArgumentException("Instruction may only contain character L or R", nameof(command));
        }
    }

    private void TurnLeft()
    {
        CurrentDirection = CurrentDirection switch
        {
            Cardinal.North => Cardinal.West,
            Cardinal.West => Cardinal.South,
            Cardinal.South => Cardinal.East,
            Cardinal.East => Cardinal.North,
            _ => throw new ArgumentException("Direction should only be N, E, S or W", nameof(CurrentDirection)),
        };
    }

    private void TurnRight()
    {
        CurrentDirection = CurrentDirection switch
        {
            Cardinal.North => Cardinal.East,
            Cardinal.East => Cardinal.South,
            Cardinal.South => Cardinal.West,
            Cardinal.West => Cardinal.North,
            _ => throw new ArgumentException("Direction should only be N, E, S or W", nameof(CurrentDirection)),
        };
    }
}