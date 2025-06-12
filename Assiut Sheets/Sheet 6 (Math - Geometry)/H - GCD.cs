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