using BowlingGame;
using Xunit;

namespace BowlingGameTests
{
    public class BowlingGameUnitTests
    {
        private Game game = new Game();

        [Fact]
        public void TestRolls()
        {
            RollMany(20, 0);

            Assert.Equal(0, game.Score());
        }

        [Fact]
        public void TestRollsAllOnes()
        {
            RollMany(20, 1);

            Assert.Equal(20, game.Score());
        }

        [Fact]
        public void TestOneSpare()
        {
            RollSpare();
            game.Roll(3);

            RollMany(17, 0);

            Assert.Equal(16, game.Score());
        }

        [Fact]
        public void TestOneStrike()
        {
            RollStrike();
            game.Roll(3);
            game.Roll(4);

            RollMany(16, 0);

            Assert.Equal(24, game.Score());
        }

        [Fact]
        public void TestPerfectGame()
        {
            RollMany(12, 10);
            Assert.Equal(300, game.Score());
        }

        private void RollStrike()
        {
            game.Roll(10); //strike
        }

        private void RollSpare()
        {
            game.Roll(5);
            game.Roll(5); //spare
        }

        private void RollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
            {
                game.Roll(pins);
            }
        }
    }
}
