using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfAllElementsOfMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var rowCol = Console.ReadLine().Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries).ToArray();
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


            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sum+=matrix[i, j] ;
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}
