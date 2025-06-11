namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            System.Console.WriteLine(getQthValue(numbers[0], numbers[1], numbers[2]));
        }
        
        public static long getQthValue(long a, long b, long q)
        {
            q %= 3;
            if (q == 1)
                return a;
            else if (q == 2)
                return b;
            else
                return a ^ b;
        }
    }
}