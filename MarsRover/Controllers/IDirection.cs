using MarsRover.Models;

namespace MarsRover.Controllers;

public interface IDirection
{
    Cardinal CurrentDirection { get; }
    void Turn(char command);
}