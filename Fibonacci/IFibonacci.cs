namespace Fibonacci
{
    using System.Collections.Generic;
    using System.Numerics;

    public interface IFibonacci
    {
        BigInteger GetFibonacci(int n);

        List<BigInteger> GetFibonacciSequence(int length);
    }
}