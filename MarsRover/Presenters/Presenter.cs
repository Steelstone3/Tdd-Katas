using MarsRover.Controllers;
using MarsRover.Models;
using Spectre.Console;

namespace MarsRover.Presenters;

public class Presenter : IPresenter
{
    public string EnterInstructions()
    {
        return AnsiConsole.Ask<string>("Enter mars rover instructions:");
    }

    public void PrintState(IPosition position, IDirection direction)
    {
        AnsiConsole.WriteLine($"X{position.X}:Y{position.Y}:{direction.CurrentDirection}");
    }
}