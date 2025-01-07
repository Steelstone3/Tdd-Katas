using Moq;
using Xunit;

public class BattleServiceShould
{
    [Fact]
    public void Turn()
    {
        // Given
        Mock<INinja> ninja1 = new();
        Mock<INinja> ninja2 = new();
        IBattleService battleService = new BattleService();

        // When
        battleService.Turn(ninja1.Object, ninja2.Object);

        // Then
        ninja1.VerifyAll();
        ninja1.VerifyNoOtherCalls();
        ninja2.VerifyAll();
        ninja2.VerifyNoOtherCalls();
    }
}

public class BattleService : IBattleService
{
    public void Turn(INinja object1, INinja object2)
    {
        throw new System.NotImplementedException();
    }
}