namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            if (number == 1)
            {
                System.Console.WriteLine(1);
                return;
            }
            long summationOfDivisors = number + 1;
            int limit = (int)Math.Sqrt(number);
            for (int i = 2; i <= limit; i++)
            {
                if (number % i == 0)
                {
                    summationOfDivisors += i;
                    if (number / i != i)
                        summationOfDivisors += number / i;
                }
            }
            System.Console.WriteLine(summationOfDivisors);
        }
    }
}