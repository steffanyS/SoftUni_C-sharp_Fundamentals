using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToArray();
            var dict=new SortedDictionary<char, int>();

            foreach (var ch in input)
            {
                if (!dict.ContainsKey(ch))
                {
                    dict.Add(ch, 1);
                }
                else
                {
                    dict[ch] += 1;
                }
            }

            foreach (var key in dict.Keys)
            {
                Console.WriteLine("{0}: {1} time/s", key,dict[key]);
            }
        }
    }
}
