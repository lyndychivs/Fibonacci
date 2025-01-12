namespace Fibonacci
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    /// <summary>
    /// The interface for Fibonacci.
    /// </summary>
    public interface IFibonacci
    {
        /// <summary>
        /// Gets the Fibonacci number at the specified index.
        /// </summary>
        /// <param name="n">The n-th index of Fibonacci as <see cref="int"/>.</param>
        /// <returns>The value of Fibonacci as <see cref="BigInteger"/>.</returns>
        /// <exception cref="ArgumentException"></exception>
        BigInteger Get(int n);

        /// <summary>
        /// Gets the Fibonacci sequence up to the specified length.
        /// </summary>
        /// <param name="length">The sequence length as <see cref="int"/>.</param>
        /// <returns>The Fibonacci sequence as <see cref="List{T}"/> of <see cref="BigInteger"/>.</returns>
        /// <exception cref="ArgumentException"></exception>
        List<BigInteger> GetSequence(int length);
    }
}