using MarsRover.Controllers;

namespace MarsRover.Presenters;

public interface IPresenter
{
    string EnterInstructions();
    void PrintState(IPosition roverPosition, IDirection roverDirection);
}