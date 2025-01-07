using Moq;
using Xunit;

public class BattleServiceShould
{
    Mock<INinja> ninja1 = new();
    Mock<INinja> ninja2 = new();

    [Fact]
    public void Turn()
    {
        // Given
        int damage = 5;
        Mock<IWeapon> weapon1 = new();
        Mock<IWeapon> weapon2 = new();
        ninja1.Setup(n => n.Weapon).Returns(weapon1.Object);
        ninja1.Setup(n => n.DealSomeDamage()).Returns(damage);
        ninja1.Setup(n => n.ProtectYourself(ninja2.Object.Weapon));
        ninja2.Setup(n => n.Weapon).Returns(weapon2.Object);
        ninja2.Setup(n => n.DealSomeDamage()).Returns(damage);
        ninja2.Setup(n => n.ProtectYourself(ninja1.Object.Weapon));
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
    public void Turn(INinja ninja1, INinja ninja2)
    {
        
    }
}