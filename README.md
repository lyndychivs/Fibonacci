# lyndychivs.Fibonacci
![The Fibonacci Sequence as image](https://raw.githubusercontent.com/lyndychivs/Fibonacci/master/Resource/fibonacci.png)

The [Fibonacci Sequence](https://en.wikipedia.org/wiki/Fibonacci_sequence) in C# using recursion and iteration returning [BigInteger](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.biginteger) values.

## Tests & Examples
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
- [GitHub Packages - lyndychivs.Fibonacci](https://github.com/lyndychivs/Fibonacci/pkgs/nuget/lyndychivs.Fibonacci)
- [Nuget Packages - lyndychivs.Fibonacci](https://www.nuget.org/packages/lyndychivs.Fibonacci/)