using System;
using System.Linq;

namespace SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var rowCol = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            int rows = int.Parse(rowCol[0]);
            int cols = int.Parse(rowCol[1]);

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var input = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            var maxSum = 0;
            var maxRow = -1;
            var maxCol = -1;

            for (int i = 0; i < rows-1; i++)
            {
                var currentSum = 0;
                
                for (int j = 0; j < cols-1; j++)
                {
                    currentSum+=matrix[i,j]+matrix[i,j+1]+matrix[i+1,j]+matrix[i + 1, j + 1];

                    if (currentSum>maxSum)
                    {
                        maxRow = i;
                        maxCol=j;
                        maxSum = currentSum;
                        
                    }
                    currentSum = 0;
                }
            }

            for (int i = maxRow; i <= maxRow+1; i++)
            {
                for (int j = maxCol; j <= maxCol + 1; j++)
                {
                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}
