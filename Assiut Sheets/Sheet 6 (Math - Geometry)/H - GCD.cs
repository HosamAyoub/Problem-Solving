namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Calculate GCD and derive LCM from it */
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int gcd = GCD(numbers[0], numbers[1]);
            System.Console.WriteLine(gcd + " " + ((long)numbers[0] * numbers[1] / gcd));
        }

        public static int GCD(int a, int b)
        {
            if (a == 0)
                return b;
            if (b == 0)
                return a;

            int gcd = Math.Min(a, b);
            while (a % b != 0)
            {
                gcd = a % b;
                a = b;
                b = gcd;
            }
            return gcd;
        }
    }
}

// Calculate GCD and LCM individually
/*
using System.Numerics;

namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            System.Console.WriteLine(GCD(numbers[0], numbers[1]) + " " + LCD(numbers[0], numbers[1]));
        }
        
        public static int GCD(int a, int b)
        {
            if (a == 0)
                return b;
            if (b == 0)
                return a;
            int gcd = Math.Min(a, b);
            while (a % b != 0)
            {
                gcd = a % b;
                a = b;
                b = gcd;
            }
            return gcd;
        }
        
        public static BigInteger LCD(int a, int b)
        {
            Dictionary<int, int> factors = new Dictionary<int, int>();
            primeFactors(a, factors);
            primeFactors(b, factors);
            BigInteger lcd = 1;
            foreach (var f in factors)
            {
                lcd *= (BigInteger)Math.Pow(f.Key, f.Value);
            }
            return lcd;
        }
        
        public static void primeFactors(int n, Dictionary<int, int> factors)
        {
            int limit = (int)Math.Sqrt(n);
            int exponent = 0;
            for (int i = 2; i <= limit; i++)
            {
                while (n % i == 0)
                {
                    n /= i;
                    exponent++;
                }
                if (exponent > 0)
                {
                    if (factors.ContainsKey(i))
                    {
                        if (factors[i] < exponent)
                            factors[i] = exponent;
                    }
                    else
                    {
                        factors.Add(i, exponent);
                    }
                    exponent = 0;
                }
            }
            
            if (n != 1)
            {
                if (!factors.ContainsKey(n))
                    factors.Add(n, 1);
            }
        }
    }
}
*/
