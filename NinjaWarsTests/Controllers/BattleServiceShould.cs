using Moq;
using Xunit;

public class BattleServiceShould
{
    private readonly IBattleService battleService = new BattleService();

    [Fact]
    public void Turn()
    {
        // Given
        int damage1 = 5;
        int damage2 = 15;

        Mock<INinja> ninja1 = new();
        ninja1.Setup(n => n.Attac()).Returns(damage1);
        ninja1.Setup(n => n.Protec(damage2));

        Mock<INinja> ninja2 = new();
        ninja2.Setup(n => n.Attac()).Returns(damage2);
        ninja2.Setup(n => n.Protec(damage1));

        // When
        battleService.Turn(ninja1.Object, ninja2.Object);

        // Then
        ninja1.VerifyAll();
        ninja1.VerifyNoOtherCalls();
        ninja2.VerifyAll();
        ninja2.VerifyNoOtherCalls();
    }
}