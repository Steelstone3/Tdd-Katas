using MarsRover;
using MarsRover.Controllers;
using MarsRover.Presenters;

public class Rover : IRover
{
    private readonly IDirection direction;
    private readonly IPosition position;

    public Rover(IDirection direction, IPosition position)
    {
        this.direction = direction;
        this.position = position;
    }

    public string EnterInstructions(IPresenter presenter) => presenter.EnterInstructions();
    public void PrintState(IPresenter presenter) => presenter.PrintState(position, direction);

    public string Execute(string commands)
    {
        foreach (char command in commands)
        {
            switch (command)
            {
                case 'M':
                    {
                        position.Move(direction.CurrentDirection);
                        break;
                    }
                case 'L':
                    {
                        direction.Turn('L');
                        break;
                    }
                case 'R':
                    {
                        direction.Turn('R');
                        break;
                    }
                default:
                    break;
            }

        }

        return $"X{position.X}:Y{position.Y}:{direction.CurrentDirection}";
    }
}