namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            System.Console.WriteLine(isPowerOf2(number) ? "YES" : "NO");
        }
        
        static public bool isPowerOf2(long number)
        {
            int exponent = (int)Math.Log(number, 2);
            return number == Math.Pow(2, exponent);
        }
    }
}