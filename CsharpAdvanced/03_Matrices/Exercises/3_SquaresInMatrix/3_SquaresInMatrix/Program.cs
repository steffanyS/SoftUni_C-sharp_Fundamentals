using System;
using System.Linq;

namespace _3_SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var rowCol = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var rows = rowCol[0];
            var cols = rowCol[1];

            var matrix = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var chars = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    {
                        matrix[i, j] = chars[j];
                    }
                }
            }

            var count = 0;

            for (int i = 0; i < rows-1; i++)
            {
                for (int j = 0; j < cols-1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1] && matrix[i + 1, j] == matrix[i + 1, j + 1] &&
                        matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
