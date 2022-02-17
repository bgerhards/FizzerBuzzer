using System.ComponentModel.DataAnnotations;
using Xunit;

namespace FizzBuzz.Core.Tests;

public class FizzerBuzzerTests
{
    [Fact]
    public void CanaryTest()
    {
        const bool truthy = true;
        Assert.True(truthy);
    }
    
    [Fact]
    public void DivisibleBy3ReturnsFizz()
    {
        var fizzerBuzzer = new FizzerBuzzer();
        var response = fizzerBuzzer.Evaluate(3);
        Assert.Equal("Fizz", response);
    }
    
    [Fact]
    public void DivisibleBy3ReturnsFizz1()
    {
        var fizzerBuzzer = new FizzerBuzzer();
        var response = fizzerBuzzer.Evaluate(6);
        Assert.Equal("Fizz", response);
    }
    
    [Fact]
    public void DivisibleBy3ReturnsFizz2()
    {
        var fizzerBuzzer = new FizzerBuzzer();
        var response = fizzerBuzzer.Evaluate(9);
        Assert.Equal("Fizz", response);
    }
    
    [Fact]
    public void DivisibleBy5ReturnsBuzz()
    {
        var fizzerBuzzer = new FizzerBuzzer();
        var response = fizzerBuzzer.Evaluate(5);
        Assert.Equal("Buzz", response);
    }
    
    [Fact]
    public void DivisibleBy5ReturnsBuzz1()
    {
        var fizzerBuzzer = new FizzerBuzzer();
        var response = fizzerBuzzer.Evaluate(10);
        Assert.Equal("Buzz", response);
    }
    
    [Fact]
    public void DivisibleBy5ReturnsBuzz2()
    {
        var fizzerBuzzer = new FizzerBuzzer();
        var response = fizzerBuzzer.Evaluate(20);
        Assert.Equal("Buzz", response);
    }
    
    [Fact]
    public void DivisibleBy3and5ReturnsFizzBuzz()
    {
        var fizzerBuzzer = new FizzerBuzzer();
        var response = fizzerBuzzer.Evaluate(15);
        Assert.Equal("FizzBuzz", response);
    }
    
    [Fact]
    public void DivisibleBy3and5ReturnsFizzBuzz1()
    {
        var fizzerBuzzer = new FizzerBuzzer();
        var response = fizzerBuzzer.Evaluate(30);
        Assert.Equal("FizzBuzz", response);
    }
    
    [Fact]
    public void NotDivisibleBy3or5ReturnsInputNumber()
    {
        var fizzerBuzzer = new FizzerBuzzer();
        var response = fizzerBuzzer.Evaluate(11);
        Assert.Equal("11", response);
    }
    
    [Fact]
    public void NotDivisibleBy3or5ReturnsInputNumber1()
    {
        var fizzerBuzzer = new FizzerBuzzer();
        var response = fizzerBuzzer.Evaluate(14);
        Assert.Equal("14", response);
    }
}