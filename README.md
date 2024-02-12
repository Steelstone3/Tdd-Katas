# Banking Kata

This branch shows the solution and instructions for the "Banking" kata

## Functional Requirements

Kratos International Banking Group has tasked you to create a "Banking Account".

- The banking account will be able to print a statement
- The banking account will be able to make withdrawals
- The banking account will be able to make deposits

## Constraints

The bank account will take the following interface

```cs
public interface IAccountService
{
    void deposit(int amount) 
    void withdraw(int amount) 
    void printStatement()
}
```

## Example

Given a client makes a deposit of 1000 on 10-01-2012
And a deposit of 2000 on 13-01-2012
And a withdrawal of 500 on 14-01-2012
When they print their bank statement.

Then they would see:

Date | Amount | Balance |
--: | :--: | :--:
14/01/2012 | -500 | 2500
13/01/2012 | 2000 | 3000
10/01/2012 | 1000 | 1000
