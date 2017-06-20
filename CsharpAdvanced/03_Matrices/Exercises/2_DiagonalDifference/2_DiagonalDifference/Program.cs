using System;
using System.Linq;

namespace _2_DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var matrix = new long[n, n];

            for (int i = 0; i < n; i++)
            {
                var numbers = Console.ReadLine().Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    {
                        matrix[i,j] = numbers[j];
                    }
                }
            }


            long primaryDiagonalSum = 0;
            long secondaryDiagonalSum = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        primaryDiagonalSum += matrix[i, j];
                    }
                }
            }

            long count = n-1;

            for (int i = 0; i < n; i++)
            {
                secondaryDiagonalSum += matrix[i, count];
                count--;
            }

            long diff = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
            Console.WriteLine(diff);

        }
    }
}
