namespace Fibonacci
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public class FibonacciIterative : IFibonacci
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

            BigInteger current = 0;
            BigInteger next = 1;

            for (int i = 0; i < n; i++)
            {
                BigInteger temp = current;
                current = next;
                next += temp;
            }

            return current;
        }

        public List<BigInteger> GetFibonacciSequence(int length)
        {
            if (length < 0)
            {
                throw new ArgumentException($"{nameof(length)} must be greater than or equal to 0.");
            }

            var sequence = new List<BigInteger>();
            for (int i = 0; i < length; i++)
            {
                sequence.Add(GetFibonacci(i));
            }

            return sequence;
        }
    }
}