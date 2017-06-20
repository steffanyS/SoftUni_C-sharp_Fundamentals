using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var set=new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                foreach (var element in input)
                {
                    if (!set.Contains(element))
                    {
                        set.Add(element);
                    }
                }
            }

            foreach (var element in set)
            {
                Console.Write(element+" ");
            }
        }
    }
}
