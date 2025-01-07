# Ninja Wars

Ninja wars is a mini text game. Each player has a number of different attacks they can make. Each attack does different amounts of damage. The game ends when one ninja is completely out of health.

## Requirements

### Ninja

- A ninja should look to protect itself and deal some damage

```cs
public interface INinja
{
    void ProtectYourself(IWeapon weapon);
    int DealSomeDamage();
    IWeapon Weapon { get; }
}

public interface IWeapon
{
    int Attack();
}
```

### Battle Service

- A battle service should run a single turn.
  - Ninja 1 attacks ninja 2
  - Ninja 2 defends themself
  - Ninja 2 then attacks ninja 1
  - Ninja 1 defends themself

```cs
public interface IBattleService
{
    void Turn(INinja ninja1, INinja ninja2);
}
```

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
