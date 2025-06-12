using System.Numerics;

namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            BigInteger sum = 0;
            int start = Math.Min(numbers[0], numbers[1]);
            int end = Math.Max(numbers[0], numbers[1]);
            if (end % numbers[2] != 0)
                end -= end % numbers[2];
            if (start < numbers[2])
                start = numbers[2];
            if (start > numbers[2])
            {
                int i = 2, oldStart = start;
                while (start % numbers[2] != 0 || start < oldStart)
                {
                    start = numbers[2] * i;
                    i++;
                }
            }
            BigInteger n = ((end - start) / numbers[2]) + 1;
            sum = n * (start + end) / 2;
            System.Console.WriteLine(sum);
        }
    }
}