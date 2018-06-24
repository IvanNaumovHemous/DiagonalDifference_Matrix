using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            var matrix = GetSquareMatrix(size);
            var sumOfFirstDiagonal = GetFirstDiagonal(matrix);
            var sumOfSecondDiagonal = GetSecondDiagonal(matrix);

            Console.WriteLine(Math.Abs(sumOfFirstDiagonal - sumOfSecondDiagonal));
        }

        private static int GetSecondDiagonal(int[,] matrix)
        {
            var sumSecondDiagonal = 0;

            for (int i = 0, j = matrix.GetLength(1) - 1; i < matrix.GetLength(0); i++, j--)
            {
                sumSecondDiagonal += matrix[i, j];
            }

            return sumSecondDiagonal;
        }

        private static int GetFirstDiagonal(int[,] matrix)
        {
            var sumFirstDiagonal = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sumFirstDiagonal += matrix[i, i];
            }
            
            return sumFirstDiagonal;
        }

        private static int[,] GetSquareMatrix(int size)
        {
            var matrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            return matrix;
        }
    }
}
