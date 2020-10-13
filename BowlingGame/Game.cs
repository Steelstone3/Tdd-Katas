namespace BowlingGame
{
    public class Game
    {
        private int[] rolls = new int[21];
        private int currentRoll = 0;

        public Game()
        {
        }

        public void Roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        public int Score()
        {
            int score = 0;
            int frameIndex = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (IsStrike(frameIndex)) //strike
                {
                    score += AddStrikeRule(frameIndex);
                    frameIndex++;
                }
                else if (IsSpare(frameIndex)) //spare
                {
                    score += AddSpareRule(frameIndex);
                    frameIndex += 2;
                }
                else
                {
                    score += AddStandardRoleRule(frameIndex);
                    frameIndex += 2;
                }
            }
            return score;
        }

        //First roll is 10
        private bool IsStrike(int frameIndex) => rolls[frameIndex] == 10;

        //Both rolls add up to 10
        private bool IsSpare(int frameIndex) => rolls[frameIndex] + rolls[frameIndex + 1] == 10;

        //Adds 10 to the next two rolls
        private int AddStrikeRule(int frameIndex) => 10 + rolls[frameIndex + 1] + rolls[frameIndex + 2];
        
        //Adds previous roll to the next roll
        private int AddSpareRule(int frameIndex) => 10 + rolls[frameIndex + 2];

        //Adds the roll to the total score
        private int AddStandardRoleRule(int frameIndex) => rolls[frameIndex] + rolls[frameIndex + 1];
    }
}