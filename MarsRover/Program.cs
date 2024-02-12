using MarsRover.Controllers;
using MarsRover.Models;
using MarsRover.Presenters;

namespace MarsRover;

static class Program
{
    static void Main()
    {
        IPresenter presenter = new Presenter();
            IDirection direction = new Direction(Cardinal.North);
            IPosition position = new Position(0, 0);
            IRover rover = new Rover(direction, position);

            while (true)
            {
                string instructions = rover.EnterInstructions(presenter);
                rover.Execute(instructions);
                rover.PrintState(presenter);
            }
    }
}