namespace GameOfLifeTests
{
    public static class GameOfLifeTestHelper
    {
        public static bool[,] _uberStartingState1 = new bool[5, 5]
        {
            {false, false, false, true, true},
            {true, false, false, true, true},
            {false, false, false, true, false},
            {true, false, false, true, false},
            {false, true, false, true, false},
        };

        //Need to think about end state
        public static bool[,] _uberEndingState1 = new bool[5, 5]
        {
            {false, false, false, true, true},
            {true, false, false, true, true},
            {false, false, false, true, false},
            {true, false, false, true, false},
            {false, true, false, true, false},
        };

        //starting state
        public static bool[,] _underPopulationStartingState1 = new bool[3, 3]
        {
            {true, false, false},
            {false, false, false},
            {false, false, false},
        };

        //ending state
        public static bool[,] _underPopulationEndingState1 = new bool[3, 3]
        {
            {false, false, false},
            {false, false, false},
            {false, false, false},
        };

        //starting state
        public static bool[,] _correctPopulationStartingState1 = new bool[3, 3]
        {
            {true, true, false},
            {true, true, false},
            {false, false, false},
        };

        //ending state
        public static bool[,] _correctPopulationEndingState1 = new bool[3, 3]
        {
            {true, true, false},
            {true, true, false},
            {false, false, false},
        };

        //starting state
        public static bool[,] _overPopulationStartingState1 = new bool[3, 3]
        {
            {true, true, true},
            {true, true, true},
            {false, false, false},
        };

        //ending state
        public static bool[,] _overPopulationEndingState1 = new bool[3, 3]
        {
            {true, false, true},
            {true, false, true},
            {false, false, false},
        };

        //starting state
        public static bool[,] _repoductionStartingState1 = new bool[3, 3]
        {
            {false, true, false},
            {true, true, false},
            {false, false, false},
        };

        //ending state
        public static bool[,] _repoductionEndingState1 = new bool[3, 3]
        {
            {true, true, false},
            {true, true, false},
            {false, false, false},
        };    
    }
}