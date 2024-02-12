# Conway's Game Of Life Kata

This branch shows the solution and instructions for the "Conway's Game Of Life" kata

## Functional Requirements

Ulric Conway has asked you to make a game of life with the following rules:

- Any live cell with fewer than two live neighbours dies, as if caused by under-population.
- Any live cell with two or three live neighbours lives on to the next generation.
- Any live cell with more than three live neighbours dies, as if by overcrowding.
- Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.

## Constraints

The game should be constructed with initial state of a two-dimensional array of boolean values, and a single public method to move to the next generation:

```cs
public class GameOfLife {
  public GameOfLife(boolean[][] board);
  public void nextGeneration();
}
```
