using System;
using System.Linq;

namespace _4_MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var rowCol = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rows = rowCol[0];
            var cols = rowCol[1];

            var matrix = new long[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    {
                        matrix[i, j] = numbers[j];
                    }
                }
            }

            long maxSum = 0;
            var sum = 0;
            var maxRow = -1;
            var maxCol = -1;

            long currentSum = 0;

            for (int i = 0; i < rows - 2; i++)
            {
                for (int j = 0; j < cols - 2; j++)
                {
                    currentSum+= matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] +
                                     matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]
                                     + matrix[i+2,j]+ matrix[i+2,j+1]+matrix[i+2,j+2];
                    if (currentSum >= maxSum)
                    {
                        maxSum = currentSum;
                        maxRow = i;
                        maxCol = j;
                    }
                    currentSum = 0;
                }
            }

            Console.WriteLine("Sum = " + maxSum);

            for (int i = maxRow; i < maxRow + 3; i++)
            {
                for (int j = maxCol; j < maxCol + 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
