namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            System.Console.WriteLine(isPrime(number) ? "YES" : "NO");
        }
        
        static public bool isPrime(long number)
        {
            if (number == 2) return true;
            if (number % 2 == 0 || number <= 1) return false;
            int limit = (int)Math.Sqrt(number);
            for (int i = 3; i <= limit; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}