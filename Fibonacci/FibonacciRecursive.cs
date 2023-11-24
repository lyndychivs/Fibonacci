namespace Fibonacci
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public class FibonacciRecursive : IFibonacci
    {
        public BigInteger GetFibonacci(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException($"{nameof(n)} must be greater than or equal to 0.");
            }

            if (n <= 1)
            {
                return n;
            }

            return GetFibonacci(n - 1) + GetFibonacci(n - 2);
        }

        public List<BigInteger> GetFibonacciSequence(int length)
        {
            if (length < 0)
            {
                throw new ArgumentException($"{nameof(length)} must be greater than or equal to 0.");
            }

            var sequence = new List<BigInteger>();

            return GetFibonacciSequence(length, sequence);
        }

        private List<BigInteger> GetFibonacciSequence(int length, List<BigInteger> sequence)
        {
            if (length == sequence.Count)
            {
                return sequence;
            }

            sequence.Add(GetFibonacci(sequence.Count));

            return GetFibonacciSequence(length, sequence);
        }
    }
}