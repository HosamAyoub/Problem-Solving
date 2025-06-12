namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int limit = (int)Math.Sqrt(n);
            int exponent = 0;
            Dictionary<int, int> factors = new Dictionary<int, int>();
            for (int i = 2; i <= limit; i++)
            {
                while (n % i == 0)
                {
                    n /= i;
                    exponent++;
                }

                if (exponent > 0)
                {
                    factors.Add(i, exponent);
                    exponent = 0;
                }
            }
            if (n != 1)
                factors.Add(n, 1);
            bool firstElement = true;
            foreach (var f in factors)
            {
                if (firstElement)
                {
                    System.Console.Write($"({f.Key}^{f.Value})");
                    firstElement = false;
                    continue;
                }
                System.Console.Write($"*({f.Key}^{f.Value})");
            }
        }
    }
}