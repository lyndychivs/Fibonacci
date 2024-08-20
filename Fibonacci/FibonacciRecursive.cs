namespace Fibonacci
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    /// <summary>
    /// Generate Fibonacci using Recursion
    /// </summary>
    public class FibonacciRecursive : IFibonacci
    {
        /// <summary>
        /// Get the Fibonacci number at the specified index
        /// </summary>
        /// <param name="n">The n-th index of Fibonacci as <see cref="int"/></param>
        /// <returns>The value of Fibonacci as <see cref="BigInteger"/></returns>
        /// <exception cref="ArgumentException"></exception>
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

        /// <summary>
        /// Get the Fibonacci sequence up to the specified length
        /// </summary>
        /// <param name="length">The length as <see cref="int"/></param>
        /// <returns>The Fibonacci sequence as <see cref="List{T}"/> of <see cref="BigInteger"/></returns>
        /// <exception cref="ArgumentException"></exception>
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