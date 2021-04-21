namespace GameOfLife.Contracts
{
    public interface ICheckConditionCommand
    {
        void CheckCondition(int x, int y);
    }
}