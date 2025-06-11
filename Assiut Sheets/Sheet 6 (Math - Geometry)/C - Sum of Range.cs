using System.Numerics;

namespace ProblemSolving
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int start = numbers.Min();
            int end = numbers.Max();

            BigInteger all = getTotalSummations(start, end);
            BigInteger even = getEvenSummations(start, end);
            BigInteger odd = all - even;

            System.Console.WriteLine(all);
            System.Console.WriteLine(even);
            System.Console.WriteLine(odd);
        }
        
        public static BigInteger getTotalSummations(int start, int end)
        {
            BigInteger n = end - start + 1;
            return n * (start + end) / 2;
        }

        public static BigInteger getEvenSummations(int start, int end)
        {
            if (start % 2 != 0)
                start++;
            if (end % 2 != 0)
                end--;
            BigInteger n = (end - start) / 2 + 1;
            return n * (start + end) / 2;
        }
        
    }
}