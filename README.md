# Ninja Wars

Ninja wars is a mini text game. Each player has a number of different attacks they can make. Each attack does different amounts of damage. The game ends when one ninja is completely out of health.

## Requirements

- [x] Local co-op
- [x] Two Ninjas (player controlled)
- [x] ASCII graphics
- [x] At least 1 attack move
- [ ] A win condition when one ninja is left

## Optional Requirements

- Fancy text graphics
- [ ] More complex damage system
  - [ ] Damage controller
  - [ ] IWeapon
    - [ ] Elements
- [ ] More than 1 attack move with different buffs/ debuffs
- [ ] (state machine) Game setup screen
- [ ] Teams of ninjas
- [ ] (state machine) Return to game setup screen on a win condition of one "team" left standing

## Running Ninja Wars

> cd ~/TDD-Kata/NinjaWars
>
> dotnet restore
>
> dotnet build
>
> dotnet run

## Tests

> cd ~/TDD-Kata/NinjaWarsTests
>
> dotnet restore
>
> dotnet build
>
> dotnet test

## Dependencies

Follow the steps for installing dotnet runtime for your given operating system.

> <https://dotnet.microsoft.com/en-us/download/dotnet/7.0>
