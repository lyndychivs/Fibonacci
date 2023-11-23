namespace Fibonacci
{
    public class FibonacciIterative : IFibonacci
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

            int current = 0;
            int next = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = current;
                current = next;
                next += temp;
            }

            return current;
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
            for (int i = 0; i < length; i++)
            {
                sequence.Add(GetFibonacci(i));
            }

            return sequence;
        }
    }
}