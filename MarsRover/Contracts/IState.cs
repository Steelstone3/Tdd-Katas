namespace MarsRover.Contracts
{
    public interface IState
    {
        char CurrentDirection { get; set; }
        int CurrentXCoordinate { get; set; }
        int CurrentYCoordinate { get; set; }
        string Commands { get; set; }
        void UpdateState();
        void NextState();
    }
}