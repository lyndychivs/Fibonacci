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

            if (n > 46)
            {
                throw new ArgumentException($"{nameof(n)} must be less than or equal to 46. (int32 does not support)");
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

            if (length > 46)
            {
                throw new ArgumentException($"{nameof(length)} must be less than or equal to 46. (int32 does not support)");
            }

            var sequence = new List<int>();

            return GetFibonacciSequence(length, sequence);
        }

        private List<int> GetFibonacciSequence(int length, List<int> sequence)
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