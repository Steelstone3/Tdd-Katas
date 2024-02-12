# Mars Rover Kata

This branch shows the solution and instructions for the "Mars Rover" kata

## Functional Requirements

NASA has tasked you to create a "Mars Rover Controller".

- The rover should navigate a 10 * 10 grid with the following commands "M", "L" and "R"
  - "M" will move the rover in the current direction
  - "L" will turn the rover to the left by one cardinal direction
  - "R" will turn the rover to the right by one cardinal direction
  - Any other instruction should throw an exception
- The rover will be aware of the cardinal direction (N, E, S, W) it is facing
- The rover will wrap around if it hits a border
- The rover should print its location "X2:Y3:W"

## Constraints

The rover will take the follow interface

```cs
interface IMarsRover {
    String execute(String commands);
}
```

and have the following constructor arguments

```cs
public MarsRover(Grid grid) {
    ...
}
```

## Example

The following is an example of the application running

> Enter Command: MMRMMLM
>
> X2:Y3:N
