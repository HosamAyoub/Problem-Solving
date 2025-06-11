namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            
            /* from the n * (n + 1) / 2 = summation of n numbers
            lets assume summation is s we got that
            n^2 + n = 2s
            n^2 + n - 2s = 0 -> a second degree equation */
            System.Console.WriteLine((int)((-1 + Math.Sqrt(1 + 8 * number)) / 2));
        }
    }
}