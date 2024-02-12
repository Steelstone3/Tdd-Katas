# Fizz Buzz Kata

This branch shows the solution and instructions for the "Fizz Buzz" kata

## Functional Requirements

Professor Sprite of Kratos' secret department of mathematics (just off the M56 between Helsby and Chester) has asked you to create a fizz buzz converter

The fizz buzz converter should do the following:

- If the number is a multiple of three, return the string "Fizz".
- If the number is a multiple of five, return the string "Buzz".
- If the number is a multiple of both three and five, return the string "FizzBuzz".

## Constraints

The fizz buzz converter will use the following interface

```cs
public interface IFizzBuzz 
{
    string FizzBuzzConverter(int number);
}
```

## Example

For example, given the numbers from 1 to 15 in order, the function would return:

> 1
>
> 2
>
> Fizz
>
> 4
>
> Buzz
>
> Fizz
>
> 7
>
> 8
>
> Fizz
>
> Buzz
>
> 11
>
> Fizz
>
> 13
>
> 14
>
> FizzBuzz
