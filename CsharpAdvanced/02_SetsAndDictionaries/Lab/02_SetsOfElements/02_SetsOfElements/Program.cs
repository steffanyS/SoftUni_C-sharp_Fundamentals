using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenght = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var set1=new HashSet<int>();
            var set2=new HashSet<int>();

            for (int i = 0; i < lenght[0]; i++)
            {
                set1.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < lenght[1]; i++)
            {
                set2.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var num in set1)
            {
                if (set2.Contains(num))
                {
                    Console.Write(num+" ");
                }
            }
        }
    }
}
