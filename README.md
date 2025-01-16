[![Mutation testing badge](https://img.shields.io/endpoint?style=for-the-badge&url=https%3A%2F%2Fbadge-api.stryker-mutator.io%2FFibonacci)](https://dashboard.stryker-mutator.io/reports/github.com/lyndychivs/Fibonacci/master)

# lyndychivs.Fibonacci

![The Fibonacci Sequence as image](https://raw.githubusercontent.com/lyndychivs/Fibonacci/master/Resources/fibonacci.png)

The [Fibonacci Sequence](https://en.wikipedia.org/wiki/Fibonacci_sequence) in C# using recursion and iteration returning [BigInteger](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.biginteger) values.

## Tests & Examples
All Unit Tests can be found under the [Fibonacci.Tests](https://github.com/lyndychivs/Fibonacci/tree/master/Fibonacci.Tests) namesapce.

One Interface exists:

```csharp
public interface IFibonacci
{
    BigInteger Get(int n);

    List<BigInteger> GetSequence(int length);
}
```

There are two concrete implementations of this Interface.

#### [FibonacciIterative](https://github.com/lyndychivs/Fibonacci/blob/master/Fibonacci/FibonacciIterative.cs)

```csharp
var fibonacci = new FibonacciIterative();

BigInteger result = fibonacci.Get(5);

List<BigInteger> sequence = fibonacci.GetSequence(3);
```

#### [FibonacciRecursive](https://github.com/lyndychivs/Fibonacci/blob/master/Fibonacci/FibonacciRecursive.cs)

```csharp
var fibonacci = new FibonacciRecursive();

BigInteger result = fibonacci.Get(5);

List<BigInteger> sequence = fibonacci.GetSequence(3);
```

## Package
Available on:
- [GitHub Packages - lyndychivs.Fibonacci](https://github.com/lyndychivs/Fibonacci/pkgs/nuget/lyndychivs.Fibonacci)
- [Nuget Packages - lyndychivs.Fibonacci](https://www.nuget.org/packages/lyndychivs.Fibonacci/)
