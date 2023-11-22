namespace Fibonacci
{
    public class FibonacciRecursive : IFibonacci
    {
        public int GetFibonacci(int n)
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

        public List<int> GetFibonacciSequence(int length)
        {
            if (length < 0)
            {
                throw new ArgumentException($"{nameof(length)} must be greater than or equal to 0.");
            }

            var sequence = new List<int>();
            for (int i = 0; i < length; i++)
            {
                sequence.Add(GetFibonacci(i));
            }

            return sequence;
        }
    }
}