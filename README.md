# Fibonacci
![The Fibonacci Sequence as image](./Resource/fibonacci.png)

The [Fibonacci Sequence](https://en.wikipedia.org/wiki/Fibonacci_sequence) in C# using recursion and iteration returning [BigInteger](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.biginteger?view=net-8.0) values.

## Tests & Use-case examples
All Unit Tests can be found under the [Fibonacci.Tests](https://github.com/lyndychivs/Fibonacci/tree/master/Fibonacci.Tests) namesapce.

One Interface exists:
```csharp
public interface IFibonacci
{
    BigInteger GetFibonacci(int n);

    List<BigInteger> GetFibonacciSequence(int length);
}
```

There are two concrete implementations of this Interface.
1. [FibonacciIterative](https://github.com/lyndychivs/Fibonacci/blob/master/Fibonacci/FibonacciIterative.cs)
2. [FibonacciRecursive](https://github.com/lyndychivs/Fibonacci/blob/master/Fibonacci/FibonacciRecursive.cs)

## Package
Available on:
- [GitHub Packages](https://github.com/lyndychivs/Fibonacci/pkgs/nuget/lyndychivs.Fibonacci)
- [Nuget Packages](https://www.nuget.org/packages/lyndychivs.Fibonacci/)