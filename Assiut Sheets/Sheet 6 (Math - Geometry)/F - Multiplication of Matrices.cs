namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lengthsOfMatrix1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[,] matrix1 = new int[lengthsOfMatrix1[0], lengthsOfMatrix1[1]];
            inputMatrix(matrix1, lengthsOfMatrix1[0], lengthsOfMatrix1[1]);

            int[] lengthsOfMatrix2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[,] matrix2 = new int[lengthsOfMatrix2[0], lengthsOfMatrix2[1]];
            inputMatrix(matrix2, lengthsOfMatrix2[0], lengthsOfMatrix2[1]);

            int[,] multiplicationResult = new int[lengthsOfMatrix1[0], lengthsOfMatrix2[1]];
            multiplicationResult = multiplyMatrices(matrix1, lengthsOfMatrix1[0], lengthsOfMatrix1[1], matrix2, lengthsOfMatrix2[0], lengthsOfMatrix2[1]);

            printMatrix(multiplicationResult, lengthsOfMatrix1[0], lengthsOfMatrix2[1]);
        }
        public static void inputMatrix(int[,] matrix, int rows, int columns)
        {
            int[] temp = new int[columns];
            for (int r = 0; r < rows; r++)
            {
                temp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for (int c = 0; c < columns; c++)
                {
                    matrix[r, c] = temp[c];
                }
            }
        }

        public static int[,] multiplyMatrices(int[,] matrix1, int r1, int c1, int[,] matrix2, int r2, int c2)
        {
            int[,] multiplicationResult = new int[r1, c2];
            int multiplication = 0;
            for (int r = 0; r < r1; r++)
            {
                for (int c = 0; c < c2; c++)
                {
                    for (int i = 0; i < c1; i++)
                    {
                        multiplicationResult[r, c] += matrix1[r, i] * matrix2[i, c];
                    }
                }
            }
            return multiplicationResult;
        }

        public static void printMatrix(int[,] matrix, int rows, int columns)
        {
            for (int r = 0; r < rows; r++)
            {
                System.Console.Write(matrix[r, 0]);
                for (int c = 1; c < columns; c++)
                {
                    System.Console.Write(" " + matrix[r, c]);
                }
                System.Console.WriteLine();
            }
        }
    }
}