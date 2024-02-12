using MarsRover.Presenters;

namespace MarsRover;

public interface IRover
{
    string EnterInstructions(IPresenter presenter);
    string Execute(string commands);
    void PrintState(IPresenter presenter);
}

