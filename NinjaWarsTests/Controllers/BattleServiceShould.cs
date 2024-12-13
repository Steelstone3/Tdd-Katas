using Moq;
using NinjaWars.Controllers;
using NinjaWars.Models;
using NinjaWars.Presenters;
using Xunit;

namespace NinjaWarsTests.Controllers
{
    public class BattleServiceShould
    {
        [Fact]
        public void RunTurn()
        {
            // Given
            int damage = 5;
            Mock<INinja> attackingNinja = new();
            attackingNinja.Setup(n => n.Attack()).Returns(damage);

            Mock<INinja> defendingNinja = new();
            defendingNinja.Setup(n => n.TakeDamage(damage));

            Mock<IPresenter> presenter = new();
            presenter.Setup(p => p.PrintTurn(attackingNinja.Object, defendingNinja.Object));

            BattleService battleService = new(presenter.Object);

            // When
            battleService.Turn(attackingNinja.Object, defendingNinja.Object);

            // Then
            attackingNinja.VerifyAll();
            attackingNinja.VerifyNoOtherCalls();

            defendingNinja.VerifyAll();
            defendingNinja.VerifyNoOtherCalls();

            presenter.VerifyAll();
            presenter.VerifyNoOtherCalls();
        }

        [Fact(Skip = "Implement")]
        public void RunTurnPlayerWins()
        {
            // Given
        
            // When
        
            // Then
        }
    }
}