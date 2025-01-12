namespace Fibonacci
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    /// <summary>
    /// Generates Fibonacci using Iteration.
    /// </summary>
    public class FibonacciIterative : IFibonacci
    {
        /// <summary>
        /// Gets the Fibonacci number at the specified index.
        /// </summary>
        /// <param name="n">The n-th index of Fibonacci as <see cref="int"/>.</param>
        /// <returns>The value of Fibonacci as <see cref="BigInteger"/>.</returns>
        /// <exception cref="ArgumentException"></exception>
        public BigInteger Get(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException($"{nameof(n)} must be greater than or equal to 0.");
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

        /// <summary>
        /// Gets the Fibonacci sequence up to the specified length.
        /// </summary>
        /// <param name="length">The sequence length as <see cref="int"/>.</param>
        /// <returns>The Fibonacci sequence as <see cref="List{T}"/> of <see cref="BigInteger"/>.</returns>
        /// <exception cref="ArgumentException"></exception>
        public List<BigInteger> GetSequence(int length)
        {
            if (length < 0)
            {
                throw new ArgumentException($"{nameof(length)} must be greater than or equal to 0.");
            }

            var sequence = new List<BigInteger>();
            for (int i = 0; i < length; i++)
            {
                sequence.Add(Get(i));
            }

            return sequence;
        }
    }
}