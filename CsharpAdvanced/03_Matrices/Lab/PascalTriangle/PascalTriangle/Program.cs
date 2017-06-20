using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxnumber = long.Parse(Console.ReadLine());

            for (long i = 0; i < maxnumber; i++)
            {
                long startNumber = 1;
                for (long j = 0; j <=i; j++)
                {
                    Console.Write(startNumber);
                    Console.Write(" ");
                    startNumber = startNumber*(i - j)/(j + 1);
                }
                Console.WriteLine();
            }
        }
    }
}
