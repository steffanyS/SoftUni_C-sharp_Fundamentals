using System;
using System.Linq;

namespace _02_Nature_Prophet
{
    class Program
    {
        static void Main(string[] args)
        {
            var rowCol = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var row = rowCol[0];
            var col = rowCol[1];

            var garden = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    garden[i, j] = 0;
                }
            }

            var input = Console.ReadLine();

            while (input!= "Bloom Bloom Plow")
            {
                var numbers= input.Split(' ').Select(int.Parse).ToArray();

                var flowerRow = numbers[0];
                var flowerCol = numbers[1];

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        if (i == flowerRow || j == flowerCol)
                        {
                            garden[i, j] += 1;
                        }
                    }
                }
                input = Console.ReadLine();
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(garden[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
