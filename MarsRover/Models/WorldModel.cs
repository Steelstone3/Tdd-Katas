using System.Collections.Generic;

namespace MarsRover.Models
{
    public class WorldModel
    {
        public int[,] Grid { get; private set; }

        public WorldModel(int[,] grid)
        {
            Grid = grid;
        }

    }
}