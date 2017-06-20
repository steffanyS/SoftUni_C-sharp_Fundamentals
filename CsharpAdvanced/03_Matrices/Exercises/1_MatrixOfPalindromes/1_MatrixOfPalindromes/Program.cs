using System;
using System.Linq;

namespace _1_MatrixOfPalindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                        Console.Write(alphabet[i]);
                        Console.Write(alphabet[i+j]);
                        Console.Write(alphabet[i]);
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
