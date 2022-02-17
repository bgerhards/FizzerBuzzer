# FizzerBuzzer
## Yup, another one!

### Technologies:
- .NET 6
- C#
- XUnit

### Why?

This project was created to demonstrate TDD and to begin discussions of creating a Core/Shell approach to software development. The fundamentals are not far from our current understanding of application development but they help build up the progmatic approach to a cleaner product.

### So what am I trying to accomplish?

A single canary test has been provided. Using TDD, build up additional tests to create a class that evaluates an input (any integer) and spits out `Fizz`, `Buzz`, `FizzBuzz`, or the input number. The rules are as follows:

```
Scenario: Number is divisible by 3, returns "Fizz"
Given I have a number divisible by 3
When I provide this number to my evaluation tool
Then it returns me with the string "Fizz"
```

```
Scenario: Number is divisible by 3, returns "Fizz"
Given I have a number divisible by 5
When I provide this number to my evaluation tool
Then it returns me with the string "Buzz"
```

```
Scenario: Number is divisible by 3, returns "Fizz"
Given I have a number divisible by 3
  And the number is divisible by 5
When I provide this number to my evaluation tool
Then it returns me with the string "FizzBuzz"
```

```
Scenario: Number is not divisible by 3 or 5, returns number provided
Given I have a number that is not divisible by 3
  And the number is not divisible by 5
When I provide this number to my evaluation tool
Then it returns me with the number provided
```