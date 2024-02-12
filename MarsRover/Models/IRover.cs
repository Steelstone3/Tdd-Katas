using MarsRover.Presenters;

namespace MarsRover;

public interface IRover
{
    string EnterInstructions(IPresenter presenter);
    void Execute(string commands);
    void PrintState(IPresenter presenter);
}

