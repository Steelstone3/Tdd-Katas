namespace GameOfLife
{
    public interface IGameOfLife
    {
        bool[][] Board { get; }
        public void NextGeneration();
    }
}